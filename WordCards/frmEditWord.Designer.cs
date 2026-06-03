namespace WordCards
{
    partial class frmEditWord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpWord      = new System.Windows.Forms.GroupBox();
            this.txtWord      = new System.Windows.Forms.TextBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.grpExplain   = new System.Windows.Forms.GroupBox();
            this.txtExplain   = new System.Windows.Forms.TextBox();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnCancel    = new System.Windows.Forms.Button();

            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.SuspendLayout();

            // ── 單字 ──
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpWord.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.grpWord.Location = new System.Drawing.Point(30, 30);
            this.grpWord.Name = "grpWord";
            this.grpWord.Size = new System.Drawing.Size(620, 100);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字（唯讀）";

            this.txtWord.BackColor = System.Drawing.Color.FromArgb(236, 239, 241);
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWord.Enabled = false;
            this.txtWord.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.txtWord.Location = new System.Drawing.Point(20, 38);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(578, 44);
            this.txtWord.TabIndex = 0;

            // ── 音標 ──
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpPhonogram.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.grpPhonogram.Location = new System.Drawing.Point(30, 148);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Size = new System.Drawing.Size(620, 100);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";

            this.txtPhonogram.BackColor = System.Drawing.Color.White;
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(0, 105, 92);
            this.txtPhonogram.Location = new System.Drawing.Point(20, 38);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(578, 44);
            this.txtPhonogram.TabIndex = 0;

            // ── 音檔路徑 ──
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpSoundPath.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.grpSoundPath.Location = new System.Drawing.Point(30, 266);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Size = new System.Drawing.Size(620, 100);
            this.grpSoundPath.TabIndex = 2;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";

            this.txtSoundPath.BackColor = System.Drawing.Color.White;
            this.txtSoundPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoundPath.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtSoundPath.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.txtSoundPath.Location = new System.Drawing.Point(20, 38);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(578, 42);
            this.txtSoundPath.TabIndex = 0;

            // ── 解釋 ──
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpExplain.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.grpExplain.Location = new System.Drawing.Point(30, 384);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Size = new System.Drawing.Size(620, 270);
            this.grpExplain.TabIndex = 3;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";

            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.txtExplain.Location = new System.Drawing.Point(20, 38);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(578, 210);
            this.txtExplain.TabIndex = 0;

            // ── 儲存按鈕 ──
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(440, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "💾  儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // ── 取消按鈕 ──
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(236, 239, 241);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.btnCancel.Location = new System.Drawing.Point(30, 675);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;

            // ── 表單 ──
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 755);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpSoundPath);
            this.Controls.Add(this.grpPhonogram);
            this.Controls.Add(this.grpWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 820);
            this.Name = "frmEditWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "編輯單字";

            this.grpWord.ResumeLayout(false);
            this.grpWord.PerformLayout();
            this.grpPhonogram.ResumeLayout(false);
            this.grpPhonogram.PerformLayout();
            this.grpSoundPath.ResumeLayout(false);
            this.grpSoundPath.PerformLayout();
            this.grpExplain.ResumeLayout(false);
            this.grpExplain.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.GroupBox grpPhonogram;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.GroupBox grpSoundPath;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.GroupBox grpExplain;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
