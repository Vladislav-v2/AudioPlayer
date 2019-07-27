using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class AudioPlayer : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.slMax = slTime.Maximum;
            if (PlayList.SelectedItems.Count != 0)
                Properties.Settings.Default.PlaySelect = PlayList.Items.IndexOf(PlayList.SelectedItems[0]);
            Properties.Settings.Default.slVal = slTime.Value;
            Properties.Settings.Default.slVolume = slVol.Value;
            Properties.Settings.Default.Stream = BassLike.Stream;
            Properties.Settings.Default.loopChannel = BassLike.loop;
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
