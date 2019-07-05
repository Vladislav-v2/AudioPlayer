namespace AudioPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.slTime = new MB.Controls.ColorSlider();
            this.panTrack = new System.Windows.Forms.Panel();
            this.labTrackInfo = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnEject = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.picCollap = new System.Windows.Forms.PictureBox();
            this.picMaxim = new System.Windows.Forms.PictureBox();
            this.picMinim = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.PlayList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.slVol = new MB.Controls.ColorSlider();
            this.labTrackVal = new System.Windows.Forms.Label();
            this.labTimeLen = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.ControlPanel.SuspendLayout();
            this.panTrack.SuspendLayout();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCollap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.ControlPanel.Controls.Add(this.slVol);
            this.ControlPanel.Controls.Add(this.slTime);
            this.ControlPanel.Controls.Add(this.panTrack);
            this.ControlPanel.Controls.Add(this.labTrackVal);
            this.ControlPanel.Controls.Add(this.labTimeLen);
            this.ControlPanel.Controls.Add(this.labTime);
            this.ControlPanel.Controls.Add(this.btnPlay);
            this.ControlPanel.Controls.Add(this.btnNext);
            this.ControlPanel.Controls.Add(this.btnPrevious);
            this.ControlPanel.Controls.Add(this.btnRepeat);
            this.ControlPanel.Controls.Add(this.btnEject);
            this.ControlPanel.Controls.Add(this.btnPause);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.Location = new System.Drawing.Point(0, 272);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(600, 87);
            this.ControlPanel.TabIndex = 6;
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(12, 22);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(461, 17);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 18;
            this.slTime.Text = "colorSlider1";
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // panTrack
            // 
            this.panTrack.Controls.Add(this.labTrackInfo);
            this.panTrack.Location = new System.Drawing.Point(12, 45);
            this.panTrack.Name = "panTrack";
            this.panTrack.Size = new System.Drawing.Size(371, 35);
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
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(430, 45);
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
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(471, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(389, 45);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepeat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeat.Image")));
            this.btnRepeat.Location = new System.Drawing.Point(512, 45);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(35, 35);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnEject
            // 
            this.btnEject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEject.Image = ((System.Drawing.Image)(resources.GetObject("btnEject.Image")));
            this.btnEject.Location = new System.Drawing.Point(553, 45);
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
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(430, 45);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 35);
            this.btnPause.TabIndex = 11;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragPanel.Controls.Add(this.picCollap);
            this.DragPanel.Controls.Add(this.picMaxim);
            this.DragPanel.Controls.Add(this.picMinim);
            this.DragPanel.Controls.Add(this.picExit);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(600, 26);
            this.DragPanel.TabIndex = 7;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            // 
            // picCollap
            // 
            this.picCollap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCollap.Image = ((System.Drawing.Image)(resources.GetObject("picCollap.Image")));
            this.picCollap.Location = new System.Drawing.Point(516, 0);
            this.picCollap.Name = "picCollap";
            this.picCollap.Size = new System.Drawing.Size(26, 26);
            this.picCollap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCollap.TabIndex = 0;
            this.picCollap.TabStop = false;
            this.picCollap.Click += new System.EventHandler(this.picCollap_Click);
            // 
            // picMaxim
            // 
            this.picMaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaxim.Image = ((System.Drawing.Image)(resources.GetObject("picMaxim.Image")));
            this.picMaxim.Location = new System.Drawing.Point(544, 0);
            this.picMaxim.Name = "picMaxim";
            this.picMaxim.Size = new System.Drawing.Size(26, 26);
            this.picMaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaxim.TabIndex = 0;
            this.picMaxim.TabStop = false;
            this.picMaxim.Click += new System.EventHandler(this.picMaxim_Click);
            // 
            // picMinim
            // 
            this.picMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinim.Image = ((System.Drawing.Image)(resources.GetObject("picMinim.Image")));
            this.picMinim.Location = new System.Drawing.Point(544, 0);
            this.picMinim.Name = "picMinim";
            this.picMinim.Size = new System.Drawing.Size(26, 26);
            this.picMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinim.TabIndex = 0;
            this.picMinim.TabStop = false;
            this.picMinim.Visible = false;
            this.picMinim.Click += new System.EventHandler(this.picMinim_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(572, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 26);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // PlayList
            // 
            this.PlayList.AllowDrop = true;
            this.PlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.PlayList.FullRowSelect = true;
            this.PlayList.HideSelection = false;
            this.PlayList.Location = new System.Drawing.Point(0, 28);
            this.PlayList.MultiSelect = false;
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(588, 238);
            this.PlayList.TabIndex = 8;
            this.PlayList.TileSize = new System.Drawing.Size(560, 30);
            this.PlayList.UseCompatibleStateImageBehavior = false;
            this.PlayList.View = System.Windows.Forms.View.Tile;
            this.PlayList.DoubleClick += new System.EventHandler(this.btnPlay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon-volume_24x24.png");
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(479, 22);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(109, 17);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 18;
            this.slVol.Text = "colorSlider1";
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVol_Scroll);
            // 
            // labTrackVal
            // 
            this.labTrackVal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labTrackVal.AutoSize = true;
            this.labTrackVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AudioPlayer.Properties.Settings.Default, "TrackVal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labTrackVal.Location = new System.Drawing.Point(569, 6);
            this.labTrackVal.Name = "labTrackVal";
            this.labTrackVal.Size = new System.Drawing.Size(13, 13);
            this.labTrackVal.TabIndex = 16;
            this.labTrackVal.Text = global::AudioPlayer.Properties.Settings.Default.TrackVal;
            // 
            // labTimeLen
            // 
            this.labTimeLen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTimeLen.AutoSize = true;
            this.labTimeLen.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AudioPlayer.Properties.Settings.Default, "labTimeLenVal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labTimeLen.Location = new System.Drawing.Point(439, 6);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 359);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.panTrack.ResumeLayout(false);
            this.panTrack.PerformLayout();
            this.DragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCollap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
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
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picCollap;
        private System.Windows.Forms.PictureBox picMaxim;
        private System.Windows.Forms.PictureBox picMinim;
        private System.Windows.Forms.Label labTrackVal;
        private System.Windows.Forms.Panel panTrack;
        private System.Windows.Forms.Label labTrackInfo;
        private System.Windows.Forms.ListView PlayList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MB.Controls.ColorSlider slVol;
        private MB.Controls.ColorSlider slTime;
    }
}

