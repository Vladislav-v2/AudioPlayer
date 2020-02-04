using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class AudioPlayer : Form
    {
        public AudioPlayer()
        {
            InitializeComponent();
            Vars.Link = this;
            //Vars.SetInputFormat();
            BassLike.InitBasss(BassLike.HZ);
            FormatsLoad();
            FilesLoad();
            slVol.MouseWheel += VolumeMouseWheel;//действие на прокрутки колесом мыши
        }

        private void VolumeMouseWheel(object sender, MouseEventArgs e)
        {
            slVol_Scroll(this, null);
        }

        Stopwatch st = new Stopwatch(); //время удержание кнопки перемота
        private int TimeShah = 2;// перематывание трека на 2 единицы

        private List<string> validFileFormat = new List<string>();

        private void FilesLoad()
        {
            string[] temp = Directory.EnumerateFiles(@"D:\Music\Нова").ToArray();
            for (int i = 0; i < temp.Count(); i++)
            {
                if (validFileFormat.Contains(Path.GetExtension(temp[i])))
                {
                    Vars.Files.Add(temp[i]);
                    TagModel TM = new TagModel(temp[i]);
                    ListViewItem lvi = new ListViewItem();
                    if (TM.Pictute != null)
                        MusicImageList.Images.Add(TM.Pictute);
                    else MusicImageList.Images.Add(Properties.Resources.misic);
                    lvi.Text = PlayList.Items.Count + 1 + " : " + TM.Artist + " - " + TM.Title;
                    lvi.SubItems.Add(Path.GetExtension(temp[i]).Trim('.').ToUpper() + "::" + TM.Year + "::" + TM.BitRate + "btr::" + TM.Channels);
                    lvi.ImageIndex = 0;

                    PlayList.Items.Add(lvi);
                }
            }
            if (temp.Count() != 0)
            {
                try
                {
                    labTrackInfo.Text = PlayList.Items[Properties.Settings.Default.PlaySelect].Text
                        + "\n" + PlayList.Items[Properties.Settings.Default.PlaySelect].SubItems[1].Text;
                }
                catch (ArgumentOutOfRangeException)
                {
                    labTrackInfo.Text = PlayList.Items[0].Text + "\n" + PlayList.Items[0].SubItems[1].Text;
                }
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
                lvi.SubItems.Add(Path.GetExtension(tmp[i]).Trim('.').ToUpper() + "::" + TM.Year + "::" + TM.Channels);
                lvi.ImageIndex = 0;
                PlayList.Items.Add(lvi);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((PlayList.Items.Count != 0) && (PlayList.SelectedItems.Count == 1))
            {
                string current = Vars.Files[PlayList.Items.IndexOf(PlayList.SelectedItems[0])];
                Vars.CurrentTrackNumber = PlayList.Items.IndexOf(PlayList.SelectedItems[0]);
                if (BassLike.Play(current, BassLike.Volume))
                {
                    labTrackInfo.Text = PlayList.Items[Vars.CurrentTrackNumber].Text
                      + "\n" + PlayList.Items[Vars.CurrentTrackNumber].SubItems[1].Text;
                    labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
                    labTimeLen.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString("mm':'ss");
                    slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                    slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                    timer1.Enabled = true;
                    if (MusicImageList.Images[Vars.CurrentTrackNumber] != null)
                        pictureBox3.Image = MusicImageList.Images[Vars.CurrentTrackNumber];
                btnPause.BringToFront();
                    }
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
            btnPlay.BringToFront();
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
            if (BassLike.EndPlayList)
            {
                Vars.CurrentTrackNumber = 0;
                PlayList.Items[0].Selected = true;
                if (btnRepeat.ImageIndex == 1)
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
            labTrackVol.Text = slVol.Value.ToString();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            switch (btnRepeat.ImageIndex)
            {
                case 2:
                    {
                        btnRepeat.ImageIndex = 0;
                        BassLike.loop_channel(0);
                    } break;
                case 1:
                    {
                        btnRepeat.ImageIndex = 2;
                        BassLike.loop_channel(4);
                    } break;
                case 0:
                    {
                        btnRepeat.ImageIndex = 1;
                        BassLike.loop_channel(0);
                    } break;
                default:
                    break;
            }
        }

        private void btnNext_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                st.Start();
                TimeShah = 2;
                timer2.Enabled = true;
            }
        }

        private void btnNext_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                st.Stop();
                timer2.Enabled = false;
                if (st.ElapsedMilliseconds < 500)
                {
                    NextTrack();
                }
                st.Reset();
            }
        }

        private void NextTrack()
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
            {
                if (BassLike.EndPlayList)
                {
                    btnStop_Click(this, new EventArgs());
                    Vars.CurrentTrackNumber = 0;
                    PlayList.Items[0].Selected = true;
                    BassLike.EndPlayList = false;
                    btnPlay.BringToFront();
                    if (btnRepeat.ImageIndex == 1)
                        btnPlay_Click(this, null);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                slTime.Value += TimeShah;
                BassLike.SetPosOfScroll(BassLike.Stream, slTime.Value);
                labTime.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString("mm':'ss");
            }
            catch (ArgumentOutOfRangeException)
            {
                timer2.Enabled = false;
                if (slTime.Value >= slTime.Maximum)
                {
                    NextTrack();
                    return;
                }
                if (slTime.Value <= slTime.Minimum)
                    btnStop_Click(this, null);
            }
        }

        private void btnPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                st.Start();
                TimeShah = -2;
                timer2.Enabled = true;
            }
        }

        private void btnPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                st.Stop();
                timer2.Enabled = false;
                if (st.ElapsedMilliseconds < 500)
                {
                    PreviousTrack();
                }
                st.Reset();
            }
        }

        private void PreviousTrack()
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 35) pnlMenu.Width = 150; else pnlMenu.Width = 35;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (btnShuffle.Image == Properties.Resources.shuffle_icon0)
                btnShuffle.Image = Properties.Resources.shuffle_icon;
            else
                btnShuffle.Image = Properties.Resources.shuffle_icon0;
        }
    }
}