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
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWord
            // 
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.grpWord.Location = new System.Drawing.Point(30, 30);
            this.grpWord.Name = "grpWord";
            this.grpWord.Size = new System.Drawing.Size(620, 129);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字（唯讀）";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWord.Enabled = false;
            this.txtWord.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.txtWord.Location = new System.Drawing.Point(20, 46);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(578, 54);
            this.txtWord.TabIndex = 0;
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPhonogram
            // 
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.grpPhonogram.Location = new System.Drawing.Point(30, 165);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Size = new System.Drawing.Size(620, 114);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.BackColor = System.Drawing.Color.White;
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.txtPhonogram.Location = new System.Drawing.Point(20, 46);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(578, 54);
            this.txtPhonogram.TabIndex = 0;
            this.txtPhonogram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpSoundPath
            // 
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpSoundPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.grpSoundPath.Location = new System.Drawing.Point(30, 285);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Size = new System.Drawing.Size(620, 120);
            this.grpSoundPath.TabIndex = 2;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.BackColor = System.Drawing.Color.White;
            this.txtSoundPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoundPath.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtSoundPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtSoundPath.Location = new System.Drawing.Point(20, 57);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(578, 43);
            this.txtSoundPath.TabIndex = 0;
            this.txtSoundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpExplain
            // 
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.grpExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.grpExplain.Location = new System.Drawing.Point(30, 411);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Size = new System.Drawing.Size(620, 315);
            this.grpExplain.TabIndex = 3;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtExplain.Location = new System.Drawing.Point(20, 38);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(578, 257);
            this.txtExplain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(440, 732);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "💾  儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnCancel.Location = new System.Drawing.Point(30, 732);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmEditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 796);
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
