using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Vars.Link = this;
            Vars.SetInputFormat();
            BassLike.InitBasss(BassLike.HZ);
            repState = repeatState[0];
            FormatsLoad();
            FilesLoad();

        }

        private void FormatsLoad()
        {
            invalidFileFormat.Add(".mp3");
            invalidFileFormat.Add(".m4a");
            invalidFileFormat.Add(".mp4");
            invalidFileFormat.Add(".ogg");
            invalidFileFormat.Add(".opus");
            invalidFileFormat.Add(".ac3");
            invalidFileFormat.Add(".ape");
            invalidFileFormat.Add(".mpc");
            invalidFileFormat.Add(".flac");
            invalidFileFormat.Add(".wma");
            invalidFileFormat.Add(".tta");
            invalidFileFormat.Add(".alac");
            invalidFileFormat.Add(".wv");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wnsg, int wparm, int lparam);

        char[] repeatState = { '0', '1', '2' };
        public static char repState;

        private List<string> invalidFileFormat = new List<string>();

        private void FilesLoad()
        {
            PlayList.LargeImageList = imageList1;
            string[] temp = Directory.EnumerateFiles(@"D:\Music\Нова").ToArray();
            for (int i = 0; i < temp.Count(); i++)
            {
                if (invalidFileFormat.Contains(Path.GetExtension(temp[i])))
                {
                    Vars.Files.Add(temp[i]);
                    TagModel TM = new TagModel(temp[i]);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = PlayList.Items.Count + 1 + " : " + TM.Artist + " - " + TM.Title;
                    lvi.SubItems.Add(Path.GetExtension(temp[i])+"::"+TM.Year+"::"+TM.Channels);
                    lvi.ImageIndex = 0;
                    PlayList.Items.Add(lvi);
                }              
            }
            if (temp.Count() != 0)
            { 
                labTrackInfo.Text = PlayList.Items[Properties.Settings.Default.PlaySelect].Text
                    + "\n"+ PlayList.Items[Properties.Settings.Default.PlaySelect].SubItems[1].Text;
            }
        }

        private void btnEject_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Vars.Files.Add(tmp[i]);
                TagModel TM = new TagModel(tmp[i]);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = PlayList.Items.Count + 1 + " : " + TM.Artist + " - " + TM.Title;
                lvi.SubItems.Add(Path.GetExtension(tmp[i]) + "::" + TM.Year + "::" + TM.Channels);
                lvi.ImageIndex = 0;
                PlayList.Items.Add(lvi);
            }
            //PlayList.Items[0].Selected = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((PlayList.Items.Count != 0) && (PlayList.SelectedItems.Count == 1))
            {
                string current = Vars.Files[PlayList.Items.IndexOf(PlayList.SelectedItems[0])];
                Vars.CurrentTrackNumber = PlayList.Items.IndexOf(PlayList.SelectedItems[0]);
                labTrackInfo.Text = PlayList.Items[Vars.CurrentTrackNumber].Text 
                    + "\n" + PlayList.Items[Vars.CurrentTrackNumber].SubItems[1].Text;
                BassLike.Play(current, BassLike.Volume);
                labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
                labTimeLen.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString("mm':'ss");
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                timer1.Enabled = true;
                btnPause.BringToFront();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            BassLike.Pause();
            btnPlay.BringToFront();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            labTime.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);

            if (BassLike.ToNextTrack())
            {
                PlayList.Items[Vars.CurrentTrackNumber].Selected = true;

                labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
                labTimeLen.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString("mm':'ss");
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);

            }

            if(BassLike.EndPlayList)
            {
                Vars.CurrentTrackNumber = 0;
                PlayList.Items[0].Selected = true;
                if (repState == repeatState[1])
                {
                    btnPlay_Click(this, null);
                }
                else
                {
                    btnStop_Click(this, new EventArgs());
                    btnPlay.BringToFront();
                }                       
                BassLike.EndPlayList = false;
            }
        }

        private void slTime_Scroll(object sender, ScrollEventArgs e)//изминение позиции трека
        {
            BassLike.SetPosOfScroll(BassLike.Stream, slTime.Value);
            labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
        }

        private void slVol_Scroll(object sender, ScrollEventArgs e)//изминение ромкости
        {
            BassLike.SetVolumeStream(BassLike.Stream, slVol.Value);
            labTrackVal.Text = slVol.Value.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e) //следующий трек
        {
            slTime.Value = 0;
            if (BassLike.NextTrack())
            {
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                PlayList.Items[Vars.CurrentTrackNumber].Selected = true;
                labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
                labTimeLen.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString("mm':'ss");
                labTrackInfo.Text = PlayList.Items[Vars.CurrentTrackNumber].Text
                    + "\n" + PlayList.Items[Vars.CurrentTrackNumber].SubItems[1].Text;
                btnPause.BringToFront();
            }

            if (PlayList.Items.Count != 0)
                if (BassLike.EndPlayList)
                {
                    btnStop_Click(this, new EventArgs());
                    Vars.CurrentTrackNumber = 0;
                    PlayList.Items[0].Selected = true;
                    BassLike.EndPlayList = false;
                    btnPlay.BringToFront();
                    if (repState != repeatState[0])
                        btnPlay_Click(this, null);
                }
        }

        private void btnPrevious_Click(object sender, EventArgs e)//предыдущий трек 
        {
            if (PlayList.Items.Count != 0)
            {
                slTime.Value = 0;
                BassLike.PreviousTrack();
                PlayList.Items[Vars.CurrentTrackNumber].Selected = true;
                btnPause.BringToFront();
                labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
                labTimeLen.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString("mm':'ss");
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                labTrackInfo.Text = PlayList.Items[Vars.CurrentTrackNumber].Text +
                    "\n" + PlayList.Items[Vars.CurrentTrackNumber].SubItems[1].Text;
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if(repState == repeatState[0])
            {
                repState = repeatState[1];
                btnRepeat.Image = Properties.Resources.icon_repeat;
                return;
            }
            if(repState == repeatState[1])
            {
                repState = repeatState[2];
                btnRepeat.Image = Properties.Resources.icon_repeat1;
                BassLike.loop_channel(4);
                return;
            }
            if(repState == repeatState[2])
            {
                repState = repeatState[0];
                btnRepeat.Image = Properties.Resources.icon_repeat0;
                BassLike.loop_channel(0);         
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picMinim.Visible = false;
            picMaxim.Visible = true;
        }

        private void picMaxim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picMaxim.Visible = false;
            picMinim.Visible = true;
        }

        private void picCollap_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.slMax = slTime.Maximum;
            Properties.Settings.Default.PlaySelect = PlayList.Items.IndexOf(PlayList.SelectedItems[0]);
            Properties.Settings.Default.slVal = slTime.Value;
            Properties.Settings.Default.slVolume = slVol.Value;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayList.Items[Properties.Settings.Default.PlaySelect].Selected = true;
            slTime.Maximum = Properties.Settings.Default.slMax;
            slTime.Value = Properties.Settings.Default.slVal;
            slVol.Value = Properties.Settings.Default.slVolume;
            BassLike.Volume = slVol.Value;
        }
    }
}