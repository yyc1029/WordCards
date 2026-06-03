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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmWordCards));

            // ── 宣告控制項 ──
            this.sssWord     = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft     = new System.Windows.Forms.Panel();
            this.txtSearch   = new System.Windows.Forms.TextBox();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain     = new System.Windows.Forms.Panel();
            this.txtWord     = new System.Windows.Forms.TextBox();
            this.txtPhonogram= new System.Windows.Forms.TextBox();
            this.txtExplain  = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.picLogo     = new System.Windows.Forms.PictureBox();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.btnShuffle  = new System.Windows.Forms.Button();
            this.lblSpeed    = new System.Windows.Forms.Label();
            this.trkSpeed    = new System.Windows.Forms.TrackBar();
            this.txtHelp     = new System.Windows.Forms.TextBox();
            this.timePlayer  = new System.Windows.Forms.Timer(this.components);

            this.sssWord.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════
            //  狀態列
            // ════════════════════════════════
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.sssWord.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsslMessage });
            this.sssWord.Location = new System.Drawing.Point(0, 489);
            this.sssWord.Name = "sssWord";
            this.sssWord.Size = new System.Drawing.Size(1174, 40);
            this.sssWord.TabIndex = 0;

            this.tsslMessage.ForeColor = System.Drawing.Color.FromArgb(176, 190, 197);
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(150, 30);
            this.tsslMessage.Text = "載入中...";

            // ════════════════════════════════
            //  左側面板
            // ════════════════════════════════
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlLeft.Controls.Add(this.lstWordList);   // Fill（先加）
            this.pnlLeft.Controls.Add(this.txtSearch);    // Top （後加，先佔位）
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 489);
            this.pnlLeft.TabIndex = 1;

            // 搜尋框
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 10.125F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 44);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // 單字清單
            this.lstWordList.BackColor = System.Drawing.Color.White;
            this.lstWordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 37;
            this.lstWordList.Location = new System.Drawing.Point(0, 44);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(300, 445);
            this.lstWordList.TabIndex = 1;
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            this.lstWordList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstWordList_MouseDoubleClick);

            // ════════════════════════════════
            //  主內容區
            // ════════════════════════════════
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
            this.palMain.Size = new System.Drawing.Size(874, 489);
            this.palMain.TabIndex = 2;

            // 單字（大標題）
            this.txtWord.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.txtWord.Location = new System.Drawing.Point(32, 28);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(560, 97);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "abacus";

            // 音標
            this.txtPhonogram.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.txtPhonogram.BackColor = System.Drawing.Color.White;
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(0, 105, 92);
            this.txtPhonogram.Location = new System.Drawing.Point(32, 135);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(560, 50);
            this.txtPhonogram.TabIndex = 1;
            this.txtPhonogram.Text = "ˋæbəkəs";

            // 解釋
            this.txtExplain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.txtExplain.Location = new System.Drawing.Point(32, 202);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(560, 228);
            this.txtExplain.TabIndex = 2;
            this.txtExplain.Text = "";

            // 進度標籤
            this.lblProgress.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;
            this.lblProgress.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(120, 144, 156);
            this.lblProgress.Location = new System.Drawing.Point(32, 447);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(180, 28);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "0 / 0";

            // Logo
            this.picLogo.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            this.picLogo.Image = global::WordCards.Properties.Resources.WordCards_Logo;
            this.picLogo.Location = new System.Drawing.Point(636, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(165, 165);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;

            // ▶ 播放按鈕
            this.btnAutoPlay.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            this.btnAutoPlay.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnAutoPlay.FlatAppearance.BorderSize = 0;
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPlay.Font = new System.Drawing.Font("微軟正黑體", 10.875F);
            this.btnAutoPlay.ForeColor = System.Drawing.Color.White;
            this.btnAutoPlay.Location = new System.Drawing.Point(636, 204);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(174, 52);
            this.btnAutoPlay.TabIndex = 4;
            this.btnAutoPlay.Text = "▶  播放";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);

            // 🔀 亂序按鈕
            this.btnShuffle.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("微軟正黑體", 10.875F);
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(636, 272);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(174, 52);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "🔀  亂序：關";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);

            // 速度標籤
            this.lblSpeed.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            this.lblSpeed.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.lblSpeed.Location = new System.Drawing.Point(636, 344);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(174, 28);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "播放速度：2s";

            // 速度滑桿
            this.trkSpeed.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            this.trkSpeed.Location = new System.Drawing.Point(618, 370);
            this.trkSpeed.Maximum = 5;
            this.trkSpeed.Minimum = 1;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(210, 45);
            this.trkSpeed.TabIndex = 7;
            this.trkSpeed.TickFrequency = 1;
            this.trkSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkSpeed.Value = 2;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);

            // 操作說明
            this.txtHelp.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("微軟正黑體", 8.25F);
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.txtHelp.Location = new System.Drawing.Point(618, 428);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(222, 48);
            this.txtHelp.TabIndex = 9;
            this.txtHelp.Text = "Enter：下一個　Space：重複播放\r\n雙擊清單可編輯單字";

            // 計時器
            this.timePlayer.Interval = 2000;
            this.timePlayer.Tick += new System.EventHandler(this.timePlayer_Tick);

            // ════════════════════════════════
            //  表單
            // ════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 529);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
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
