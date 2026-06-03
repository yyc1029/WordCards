namespace WordCards
{
    partial class frmWordCards
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWordCards));
            this.sssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.timePlayer = new System.Windows.Forms.Timer(this.components);
            this.sssWord.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sssWord
            // 
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.sssWord.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.sssWord.Location = new System.Drawing.Point(0, 640);
            this.sssWord.Name = "sssWord";
            this.sssWord.Size = new System.Drawing.Size(1335, 40);
            this.sssWord.TabIndex = 0;
            // 
            // tsslMessage
            // 
            this.tsslMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(103, 30);
            this.tsslMessage.Text = "載入中...";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlLeft.Controls.Add(this.lstWordList);
            this.pnlLeft.Controls.Add(this.txtSearch);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 640);
            this.pnlLeft.TabIndex = 1;
            // 
            // lstWordList
            // 
            this.lstWordList.BackColor = System.Drawing.Color.White;
            this.lstWordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 37;
            this.lstWordList.Location = new System.Drawing.Point(0, 43);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(300, 597);
            this.lstWordList.TabIndex = 1;
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            this.lstWordList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstWordList_MouseDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 10.125F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 43);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.Controls.Add(this.txtHelp);
            this.palMain.Controls.Add(this.trkSpeed);
            this.palMain.Controls.Add(this.lblSpeed);
            this.palMain.Controls.Add(this.lblProgress);
            this.palMain.Controls.Add(this.btnShuffle);
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Controls.Add(this.txtExplain);
            this.palMain.Controls.Add(this.txtPhonogram);
            this.palMain.Controls.Add(this.txtWord);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Font = new System.Drawing.Font("微軟正黑體", 10.125F);
            this.palMain.Location = new System.Drawing.Point(300, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(1035, 640);
            this.palMain.TabIndex = 2;
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("微軟正黑體", 8.25F);
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.txtHelp.Location = new System.Drawing.Point(782, 542);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(253, 95);
            this.txtHelp.TabIndex = 9;
            this.txtHelp.Text = "Enter：下一個　\r\nSpace：重複播放\r\n雙擊清單可編輯單字";
            // 
            // trkSpeed
            // 
            this.trkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trkSpeed.Location = new System.Drawing.Point(759, 446);
            this.trkSpeed.Maximum = 5;
            this.trkSpeed.Minimum = 1;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(249, 90);
            this.trkSpeed.TabIndex = 7;
            this.trkSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkSpeed.Value = 2;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblSpeed.Location = new System.Drawing.Point(788, 409);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(264, 55);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "播放速度：2s";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblProgress.Location = new System.Drawing.Point(32, 598);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(180, 28);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "0 / 0";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("微軟正黑體", 10.875F);
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(759, 314);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(249, 53);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "🔀  亂序：關";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnAutoPlay.FlatAppearance.BorderSize = 0;
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPlay.Font = new System.Drawing.Font("微軟正黑體", 10.875F);
            this.btnAutoPlay.ForeColor = System.Drawing.Color.White;
            this.btnAutoPlay.Location = new System.Drawing.Point(759, 245);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(249, 63);
            this.btnAutoPlay.TabIndex = 4;
            this.btnAutoPlay.Text = "▶  播放";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::WordCards.Properties.Resources.WordCards_Logo;
            this.picLogo.Location = new System.Drawing.Point(759, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(249, 227);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtExplain.Location = new System.Drawing.Point(32, 202);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(721, 379);
            this.txtExplain.TabIndex = 2;
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.BackColor = System.Drawing.Color.White;
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.txtPhonogram.Location = new System.Drawing.Point(32, 135);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(721, 50);
            this.txtPhonogram.TabIndex = 1;
            this.txtPhonogram.Text = "ˋæbəkəs";
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.txtWord.Location = new System.Drawing.Point(32, 28);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(721, 100);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "abacus";
            // 
            // timePlayer
            // 
            this.timePlayer.Interval = 2000;
            this.timePlayer.Tick += new System.EventHandler(this.timePlayer_Tick);
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1335, 680);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.sssWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "frmWordCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "單字卡";
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.sssWord.ResumeLayout(false);
            this.sssWord.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sssWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstWordList;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Timer timePlayer;
    }
}
