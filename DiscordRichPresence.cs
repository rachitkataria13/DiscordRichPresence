using DiscordRPC;
using DiscordRPC.Message;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Button = DiscordRPC.Button;

namespace Discord_Rich_Presence
{
    public partial class DiscordRichPresence : Form
    {
        public DiscordRichPresence()
        {
            InitializeComponent();
        }

        private void DRP_Load(object sender, EventArgs e)
        {
            notificationIcon.MouseDoubleClick += notificationIcon_MouseDoubleClick;
            btnStop.Enabled = false;
            btnStart.Enabled = false;
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            this.ActiveControl = applicationId;
        }

        public DiscordRpcClient Client { get; private set; }

        private Timestamps timestamps = null;
        private Party party = null;
        private List<Button> btnItems = new List<Button>();
        private void applicationId_TextChanged(object sender, EventArgs e)
        {
            if (applicationId.Text.Length == 18)
            {
                String appId = applicationId.Text.ToString();
                try
                {
                    largeImage.Items.Clear();
                    smallImage.Items.Clear();
                    getImages(true, appId);
                    getImages(false, appId);
                    btnStart.Enabled = true;
                    startToolStripMenuItem.Enabled = true;
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.StackTrace.ToString());
                    btnStart.Enabled = false;
                    startToolStripMenuItem.Enabled = false;
                    MessageBox.Show(appId + " is not a proper Application ID\nPlease check and re-enter the Application ID", "Error!");
                }
            }
            else
            {
                btnStart.Enabled = false;
                startToolStripMenuItem.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Cleanup();
        }

        //Dispose client
        void Cleanup()
        {
            Client.Dispose();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
            toolStripStatus.Text = "Status: Stopped";
        }
        void Start()
        {
            Client = new DiscordRpcClient(applicationId.Text.ToString(), autoEvents: false);
            Client.SetPresence(new RichPresence()
            {
                Details = detail.Text.ToString(),
                State = status.Text.ToString(),
                Assets = new Assets()
                {
                    LargeImageKey = largeImage.Text.ToString(),
                    LargeImageText = largeImageText.Text.ToString(),
                    SmallImageKey = smallImage.Text.ToString(),
                    SmallImageText = smallImageText.Text.ToString()
                },
                Party = party,
                Timestamps = timestamps,
                Buttons = btnItems.ToArray()
            });
            Client.Initialize();
            toolStripStatus.Text = "Status: Running";
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cleanup();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startPresence();
        }
        void getImages(bool sizeLarge, String appId)
        {
            var json = new WebClient().DownloadString("https://discordapp.com/api/oauth2/applications/" + appId + "/assets");
            Console.WriteLine(json);
            JArray parsedJson = JArray.Parse(json);
            for (int i = 0; i < parsedJson.Count; i++)
            {
                if (sizeLarge)
                {
                    largeImage.Items.Add(parsedJson[i]["name"].ToString());
                }
                else
                {
                    smallImage.Items.Add(parsedJson[i]["name"].ToString());
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startPresence();
        }

        private void checkTimeStamps()
        {

            if (String.IsNullOrEmpty(endTimeminutes.Text.ToString()))
            {
                cbTimeLeft.Checked = false;
            }
            Timestamps ts = new Timestamps();
            if (cbTimeElapsed.Checked && cbTimeLeft.Checked)
            {
                ts = new Timestamps()
                {
                    Start = DateTime.UtcNow,
                    End = DateTime.UtcNow + TimeSpan.FromMinutes(Int32.Parse(endTimeminutes.Text.ToString()))
                };
                timestamps = ts;
            }
            else if (cbTimeElapsed.Checked)
            {
                ts = new Timestamps()
                {
                    Start = DateTime.UtcNow,
                    End = null
                };
                timestamps = ts;
            }
            else
            {
                ts = new Timestamps()
                {
                    Start = null,
                    End = null
                };
                timestamps = ts;
            }
        }

        private void checkParty()
        {
            if (cbParty.Checked)
            {
                party = new Party()
                {
                    ID = Secrets.CreateFriendlySecret(new Random()),
                    Size = (int)partyCurrent.Value,
                    Max = (int)partyMax.Value,
                    Privacy = Party.PrivacySetting.Public
                };
            }
            else
            {
                party = null;
            }
        }
        private bool CheckButtons()
        {
            btnItems.Clear();
            if (cbButtons.Checked && !String.IsNullOrEmpty(txtLabel.Text) && !String.IsNullOrEmpty(txtUrl.Text))
            {
                try
                {
                    btnItems.Add(new Button() { Label = txtLabel.Text, Url = txtUrl.Text });

                }
                catch (ArgumentException ae)
                {
                    cbButtons.Checked = false;
                    MessageBox.Show("Enter Proper URL. Format: deep://link or https://your.web.site\nTry again with a valid url.");
                    System.Console.WriteLine(ae.ToString());
                }
                if (btnItems.Count > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                cbButtons.Checked = false;
                MessageBox.Show("Disabled Buttons\nMust Enter Data for Label and URL");
                return false;
            }
        }
        private void startPresence()
        {
            checkTimeStamps();
            checkParty();
            if (CheckButtons()) {
                Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                startToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
            }
            
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (this.WindowState.Equals(FormWindowState.Minimized))
            {
                ShowInTaskbar = false;
                notificationIcon.ShowBalloonTip(1000);
            }
            if (this.WindowState.Equals(FormWindowState.Normal))
            {
                ShowInTaskbar = true;
            }
        }

        private void notificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void cbTimeLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimeLeft.Checked)
            {
                endTimeminutes.Enabled = true;
            }
            else
            {
                endTimeminutes.Enabled = false;
            }
        }

        private void endTimeminutes_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(endTimeminutes.Text, "[^0-9]"))
            {
                endTimeminutes.Text = endTimeminutes.Text.Remove(endTimeminutes.Text.Length - 1);
            }
        }

        private void cbTimeElapsed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimeElapsed.Checked)
            {
                cbTimeLeft.Enabled = true;
            }
            else
            {
                cbTimeLeft.Checked = false;
                cbTimeLeft.Enabled = false;
            }
        }

        private void cbParty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbParty.Checked)
            {
                partyCurrent.Enabled = true;
                partyMax.Enabled = true;
            }
            else
            {
                partyCurrent.Enabled = false;
                partyMax.Enabled = false;
            }
        }

        private void partyCurrent_ValueChanged(object sender, EventArgs e)
        {
            if (partyCurrent.Value < 1)
            {
                partyCurrent.Value = 1;
            }
            partyMax.Minimum = partyCurrent.Value;
        }

        private void partyMax_ValueChanged(object sender, EventArgs e)
        {
            if (partyMax.Value < 1 || partyCurrent.Value > partyMax.Value)
            {
                partyMax.Value = partyCurrent.Value;
            }
        }

        private void cbButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (cbButtons.Checked)
            {
                txtLabel.Enabled = true;
                txtUrl.Enabled = true;
            }
            else
            {
                txtLabel.Enabled = false;
                txtUrl.Enabled = false;
            }
        }
    }
}
