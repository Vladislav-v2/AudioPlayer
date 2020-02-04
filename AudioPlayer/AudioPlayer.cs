using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class AudioPlayer : Form
    {
        private void FormatsLoad()
        {
            validFileFormat.Add(".mp3");
            validFileFormat.Add(".m4a");
            validFileFormat.Add(".mp4");
            validFileFormat.Add(".ogg");
            validFileFormat.Add(".opus");
            validFileFormat.Add(".ac3");
            validFileFormat.Add(".ape");
            validFileFormat.Add(".mpc");
            validFileFormat.Add(".flac");
            validFileFormat.Add(".wma");
            validFileFormat.Add(".tta");
            validFileFormat.Add(".alac");
            validFileFormat.Add(".wv");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wnsg, int wparm, int lparam);

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.slMax = slTime.Maximum;
            if (PlayList.SelectedItems.Count != 0)
                Properties.Settings.Default.PlaySelect = PlayList.Items.IndexOf(PlayList.SelectedItems[0]);
            Properties.Settings.Default.slVal = slTime.Value;
            Properties.Settings.Default.slVolume = slVol.Value;
            Properties.Settings.Default.Stream = BassLike.Stream;
            Properties.Settings.Default.loopChannel = BassLike.loop;
            Properties.Settings.Default.repState = btnRepeat.ImageIndex;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayList.Items[Properties.Settings.Default.PlaySelect].Selected = true;
            slTime.Maximum = Properties.Settings.Default.slMax;
            slTime.Value = Properties.Settings.Default.slVal;
            slVol.Value = Properties.Settings.Default.slVolume;
            BassLike.loop = Properties.Settings.Default.loopChannel;
            BassLike.Stream = Properties.Settings.Default.Stream;
            btnRepeat.ImageIndex = Properties.Settings.Default.repState;
            BassLike.Volume = slVol.Value;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMin.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnMin.Visible = false;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}