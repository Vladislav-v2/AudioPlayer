using System;

namespace AudioPlayer
{
    partial class AudioPlayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioPlayer));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.slVol = new MB.Controls.ColorSlider();
            this.slTime = new MB.Controls.ColorSlider();
            this.panTrack = new System.Windows.Forms.Panel();
            this.labTrackInfo = new System.Windows.Forms.Label();
            this.labTrackVol = new System.Windows.Forms.Label();
            this.labTimeLen = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.RepeatImgList = new System.Windows.Forms.ImageList(this.components);
            this.btnEject = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.ProgIcon = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.MusicStateImgList = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSongs = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.MusicImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlayList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panTrack.SuspendLayout();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgIcon)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Bce форматы|*.mp3; *.m4a; *.mp4; *.ogg; *.opus; *.ac3; *.ape; *.mpc; *.flac; *.w" +
    "ma; *.tta; *.alac; *.wv;\"";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.pictureBox3);
            this.ControlPanel.Controls.Add(this.slVol);
            this.ControlPanel.Controls.Add(this.slTime);
            this.ControlPanel.Controls.Add(this.panTrack);
            this.ControlPanel.Controls.Add(this.labTrackVol);
            this.ControlPanel.Controls.Add(this.labTimeLen);
            this.ControlPanel.Controls.Add(this.labTime);
            this.ControlPanel.Controls.Add(this.btnPlay);
            this.ControlPanel.Controls.Add(this.btnNext);
            this.ControlPanel.Controls.Add(this.btnPrevious);
            this.ControlPanel.Controls.Add(this.btnShuffle);
            this.ControlPanel.Controls.Add(this.btnRepeat);
            this.ControlPanel.Controls.Add(this.btnEject);
            this.ControlPanel.Controls.Add(this.btnPause);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.Location = new System.Drawing.Point(0, 265);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(726, 87);
            this.ControlPanel.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(15, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // slVol
            // 
            this.slVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BarInnerColor = System.Drawing.Color.LavenderBlush;
            this.slVol.BarOuterColor = System.Drawing.Color.RoyalBlue;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.ElapsedInnerColor = System.Drawing.Color.MidnightBlue;
            this.slVol.ElapsedOuterColor = System.Drawing.Color.MintCream;
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(597, 22);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(117, 17);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 18;
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVol_Scroll);
            // 
            // slTime
            // 
            this.slTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BarInnerColor = System.Drawing.Color.LavenderBlush;
            this.slTime.BarOuterColor = System.Drawing.Color.RoyalBlue;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.ElapsedInnerColor = System.Drawing.Color.MidnightBlue;
            this.slTime.ElapsedOuterColor = System.Drawing.Color.MintCream;
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(12, 22);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(579, 17);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 18;
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // panTrack
            // 
            this.panTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTrack.Controls.Add(this.labTrackInfo);
            this.panTrack.Location = new System.Drawing.Point(64, 42);
            this.panTrack.Name = "panTrack";
            this.panTrack.Size = new System.Drawing.Size(396, 35);
            this.panTrack.TabIndex = 17;
            // 
            // labTrackInfo
            // 
            this.labTrackInfo.AutoSize = true;
            this.labTrackInfo.Location = new System.Drawing.Point(10, 9);
            this.labTrackInfo.Name = "labTrackInfo";
            this.labTrackInfo.Size = new System.Drawing.Size(0, 13);
            this.labTrackInfo.TabIndex = 0;
            // 
            // labTrackVol
            // 
            this.labTrackVol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labTrackVol.AutoSize = true;
            this.labTrackVol.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AudioPlayer.Properties.Settings.Default, "TrackVal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labTrackVol.Location = new System.Drawing.Point(693, 6);
            this.labTrackVol.Name = "labTrackVol";
            this.labTrackVol.Size = new System.Drawing.Size(13, 13);
            this.labTrackVol.TabIndex = 16;
            this.labTrackVol.Text = global::AudioPlayer.Properties.Settings.Default.TrackVal;
            // 
            // labTimeLen
            // 
            this.labTimeLen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTimeLen.AutoSize = true;
            this.labTimeLen.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AudioPlayer.Properties.Settings.Default, "labTimeLenVal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labTimeLen.Location = new System.Drawing.Point(560, 6);
            this.labTimeLen.Name = "labTimeLen";
            this.labTimeLen.Size = new System.Drawing.Size(34, 13);
            this.labTimeLen.TabIndex = 14;
            this.labTimeLen.Text = global::AudioPlayer.Properties.Settings.Default.labTimeLenVal;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AudioPlayer.Properties.Settings.Default, "labTimeVal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labTime.Location = new System.Drawing.Point(22, 6);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(34, 13);
            this.labTime.TabIndex = 15;
            this.labTime.Text = global::AudioPlayer.Properties.Settings.Default.labTimeVal;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(515, 45);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 35);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(556, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseDown);
            this.btnNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseUp);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(474, 45);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrevious_MouseDown);
            this.btnPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPrevious_MouseUp);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = global::AudioPlayer.Properties.Resources.shuffle_icon;
            this.btnShuffle.Location = new System.Drawing.Point(638, 42);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(35, 35);
            this.btnShuffle.TabIndex = 6;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepeat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.ImageIndex = 0;
            this.btnRepeat.ImageList = this.RepeatImgList;
            this.btnRepeat.Location = new System.Drawing.Point(597, 45);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(35, 35);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // RepeatImgList
            // 
            this.RepeatImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("RepeatImgList.ImageStream")));
            this.RepeatImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.RepeatImgList.Images.SetKeyName(0, "icon_repeat0.png");
            this.RepeatImgList.Images.SetKeyName(1, "icon_repeat.png");
            this.RepeatImgList.Images.SetKeyName(2, "icon_repeat1.png");
            // 
            // btnEject
            // 
            this.btnEject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEject.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEject.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEject.Image = ((System.Drawing.Image)(resources.GetObject("btnEject.Image")));
            this.btnEject.Location = new System.Drawing.Point(679, 45);
            this.btnEject.Name = "btnEject";
            this.btnEject.Size = new System.Drawing.Size(35, 35);
            this.btnEject.TabIndex = 7;
            this.btnEject.UseVisualStyleBackColor = true;
            this.btnEject.Click += new System.EventHandler(this.btnEject_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(515, 45);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 35);
            this.btnPause.TabIndex = 11;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.DragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragPanel.Controls.Add(this.ProgIcon);
            this.DragPanel.Controls.Add(this.btnMax);
            this.DragPanel.Controls.Add(this.btnCollapse);
            this.DragPanel.Controls.Add(this.btnExit);
            this.DragPanel.Controls.Add(this.btnMin);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(726, 26);
            this.DragPanel.TabIndex = 7;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            // 
            // ProgIcon
            // 
            this.ProgIcon.Image = global::AudioPlayer.Properties.Resources.music_icon_32x32;
            this.ProgIcon.Location = new System.Drawing.Point(0, 0);
            this.ProgIcon.Name = "ProgIcon";
            this.ProgIcon.Size = new System.Drawing.Size(24, 24);
            this.ProgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgIcon.TabIndex = 6;
            this.ProgIcon.TabStop = false;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::AudioPlayer.Properties.Resources.maximize_24x24;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(674, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.TabIndex = 4;
            this.btnMax.TabStop = false;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapse.BackgroundImage = global::AudioPlayer.Properties.Resources.collapse_256;
            this.btnCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCollapse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(649, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(25, 25);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.TabStop = false;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = global::AudioPlayer.Properties.Resources.exit_24x24;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(699, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::AudioPlayer.Properties.Resources.minimize_24x24;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(674, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // MusicStateImgList
            // 
            this.MusicStateImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MusicStateImgList.ImageStream")));
            this.MusicStateImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.MusicStateImgList.Images.SetKeyName(0, "volume_icon_512.png");
            this.MusicStateImgList.Images.SetKeyName(1, "icon-volume_24x24.png");
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnSongs);
            this.pnlMenu.Controls.Add(this.btnAlbums);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 26);
            this.pnlMenu.MaximumSize = new System.Drawing.Size(140, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(35, 239);
            this.pnlMenu.TabIndex = 9;
            // 
            // btnSongs
            // 
            this.btnSongs.FlatAppearance.BorderSize = 0;
            this.btnSongs.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSongs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongs.Image = global::AudioPlayer.Properties.Resources.music_songs;
            this.btnSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.Location = new System.Drawing.Point(0, 89);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(135, 40);
            this.btnSongs.TabIndex = 2;
            this.btnSongs.Text = "Songs";
            this.btnSongs.UseVisualStyleBackColor = true;
            // 
            // btnAlbums
            // 
            this.btnAlbums.FlatAppearance.BorderSize = 0;
            this.btnAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbums.Image = global::AudioPlayer.Properties.Resources.music_album1;
            this.btnAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbums.Location = new System.Drawing.Point(0, 43);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(135, 40);
            this.btnAlbums.TabIndex = 1;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::AudioPlayer.Properties.Resources.menu_icon;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(135, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MusicImageList
            // 
            this.MusicImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.MusicImageList.ImageSize = new System.Drawing.Size(128, 128);
            this.MusicImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(35, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 40);
            this.panel2.TabIndex = 10;
            // 
            // PlayList
            // 
            this.PlayList.AllowDrop = true;
            this.PlayList.BackColor = System.Drawing.Color.PowderBlue;
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.PlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayList.FullRowSelect = true;
            this.PlayList.HideSelection = false;
            this.PlayList.LargeImageList = this.MusicStateImgList;
            this.PlayList.Location = new System.Drawing.Point(35, 66);
            this.PlayList.MultiSelect = false;
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(691, 199);
            this.PlayList.TabIndex = 11;
            this.PlayList.TileSize = new System.Drawing.Size(550, 30);
            this.PlayList.UseCompatibleStateImageBehavior = false;
            this.PlayList.View = System.Windows.Forms.View.Tile;
            this.PlayList.DoubleClick += new System.EventHandler(this.btnPlay_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AudioPlayer.Properties.Resources.settings_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 199);
            this.button1.MinimumSize = new System.Drawing.Size(135, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(726, 352);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panTrack.ResumeLayout(false);
            this.panTrack.PerformLayout();
            this.DragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgIcon)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label labTimeLen;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnEject;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Label labTrackVol;
        private System.Windows.Forms.Panel panTrack;
        private System.Windows.Forms.Label labTrackInfo;
        private System.Windows.Forms.ImageList MusicStateImgList;
        private MB.Controls.ColorSlider slVol;
        private MB.Controls.ColorSlider slTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ImageList RepeatImgList;
        private System.Windows.Forms.PictureBox ProgIcon;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ImageList MusicImageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.ListView PlayList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
    }
}

