using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WordCards
{
    public partial class frmWordCards : Form
    {
        // ─── 資料 ───
        WordCollection _WordList = new WordCollection();
        List<WordItem> _DisplayList = new List<WordItem>();

        // ─── 播放 ───
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        string strWordFile = "WordCards.txt";
        bool isPlay = false;

        // ─── 亂序 ───
        bool _isShuffled = false;
        Random _rnd = new Random();

        // ─── Win32：TextBox 提示文字 ───
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        private const uint EM_SETCUEBANNER = 0x1501;

        public frmWordCards()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════
        //  顯示 / 播放
        // ════════════════════════════════════════

        private void ShowWord(WordItem word)
        {
            txtWord.Text = word.Word;
            txtPhonogram.Text = word.Phonogram;
            txtExplain.Text = word.Explain;
        }

        private void PlayWord(WordItem word)
        {
            if (File.Exists(word.SoundPath))
            {
                wmp.URL = word.SoundPath;
                wmp.settings.autoStart = false;
                wmp.settings.mute = false;
                wmp.controls.play();
            }
            else
            {
                tsslMessage.Text = $"⚠  找不到音檔：{word.SoundPath}";
            }
        }

        private void PlaySelectedWord()
        {
            if (lstWordList.SelectedItem == null || _DisplayList.Count == 0) return;
            int idx = lstWordList.SelectedIndex;
            if (idx < 0 || idx >= _DisplayList.Count) return;

            ShowWord(_DisplayList[idx]);
            PlayWord(_DisplayList[idx]);
            UpdateProgress(idx);
        }

        // ════════════════════════════════════════
        //  清單管理
        // ════════════════════════════════════════

        /// <summary>根據搜尋文字 + 亂序設定更新顯示清單</summary>
        private void UpdateWordList()
        {
            string search = txtSearch.Text.Trim().ToLower();

            IEnumerable<WordItem> filtered = _WordList;
            if (!string.IsNullOrEmpty(search))
            {
                filtered = _WordList.Where(w =>
                    w.Word.ToLower().Contains(search) ||
                    w.Explain.ToLower().Contains(search));
            }

            _DisplayList = filtered.ToList();

            if (_isShuffled)
            {
                // Fisher-Yates shuffle
                for (int i = _DisplayList.Count - 1; i > 0; i--)
                {
                    int j = _rnd.Next(i + 1);
                    var tmp = _DisplayList[i];
                    _DisplayList[i] = _DisplayList[j];
                    _DisplayList[j] = tmp;
                }
            }

            lstWordList.BeginUpdate();
            lstWordList.Items.Clear();
            foreach (WordItem item in _DisplayList)
                lstWordList.Items.Add(item);
            lstWordList.EndUpdate();

            // 更新狀態列
            if (_DisplayList.Count != _WordList.Count && _WordList.Count > 0)
                tsslMessage.Text = $"篩選顯示 {_DisplayList.Count} / {_WordList.Count} 個單字";
            else
                tsslMessage.Text = $"共 {_WordList.Count} 個單字";
        }

        /// <summary>更新進度標籤</summary>
        private void UpdateProgress(int idx)
        {
            int total = _DisplayList.Count;
            lblProgress.Text = total > 0
                ? $"{(idx >= 0 ? idx + 1 : 1):N0} / {total:N0}"
                : "0 / 0";
        }

        private void NextWordList()
        {
            lstWordList.Focus();
            if (_DisplayList.Count == 0) return;

            if (lstWordList.SelectedIndex + 1 >= lstWordList.Items.Count)
                lstWordList.SelectedIndex = 0;
            else
                lstWordList.SelectedIndex++;

            // 保持選取項在畫面中間
            int rows = lstWordList.Height / lstWordList.GetItemHeight(0);
            if (lstWordList.SelectedIndex >= rows / 2)
                lstWordList.TopIndex = lstWordList.SelectedIndex - rows / 2;
        }

        // ════════════════════════════════════════
        //  載入
        // ════════════════════════════════════════

        private void frmWordCards_Load(object sender, EventArgs e)
        {
            // 設定搜尋框提示文字（Win32 cue banner）
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, (IntPtr)1, "🔍  搜尋單字 / 解釋...");

            if (!File.Exists(strWordFile))
            {
                MessageBox.Show($"找不到單字檔\n{strWordFile}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            string[] lines = File.ReadAllLines(strWordFile, Encoding.UTF8);
            _WordList.LoadFromStringArray(lines);

            if (_WordList.Count > 0)
            {
                UpdateWordList();
                lstWordList.SelectedIndex = 0;
                ShowWord(_DisplayList[0]);
                UpdateProgress(0);
            }
        }

        // ════════════════════════════════════════
        //  事件：清單
        // ════════════════════════════════════════

        private void lstWordList_Click(object sender, EventArgs e)
        {
            if (isPlay) btnAutoPlay.PerformClick(); // 停止自動播放
            if (lstWordList.SelectedItem != null && lstWordList.SelectedItem.ToString().Length != 0)
                PlaySelectedWord();
        }

        private void lstWordList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstWordList.Focus();
            int idx = lstWordList.SelectedIndex;
            if (idx < 0 || idx >= _DisplayList.Count) return;

            frmEditWord edit = new frmEditWord(_DisplayList[idx]);
            if (edit.ShowDialog(this) == DialogResult.Yes)
            {
                PlaySelectedWord();
                _WordList.SaveToFile(strWordFile);
            }
        }

        // ════════════════════════════════════════
        //  事件：按鈕
        // ════════════════════════════════════════

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            lstWordList.Focus();
            if (!isPlay)
            {
                btnAutoPlay.Text = "⏹  停止";
                isPlay = true;
                PlaySelectedWord();
                timePlayer.Start();
            }
            else
            {
                btnAutoPlay.Text = "▶  播放";
                isPlay = false;
                timePlayer.Stop();
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            lstWordList.Focus();
            _isShuffled = !_isShuffled;

            if (_isShuffled)
            {
                btnShuffle.Text = "🔀  亂序：開";
                btnShuffle.BackColor = Color.FromArgb(46, 125, 50);   // 深綠
            }
            else
            {
                btnShuffle.Text = "🔀  亂序：關";
                btnShuffle.BackColor = Color.FromArgb(96, 125, 139);  // 藍灰
            }

            UpdateWordList();
            if (lstWordList.Items.Count > 0)
            {
                lstWordList.SelectedIndex = 0;
                ShowWord(_DisplayList[0]);
                UpdateProgress(0);
            }
            else
            {
                txtWord.Text = txtPhonogram.Text = txtExplain.Text = "";
                UpdateProgress(-1);
            }
        }

        // ════════════════════════════════════════
        //  事件：搜尋
        // ════════════════════════════════════════

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_WordList.Count == 0) return;
            if (isPlay) btnAutoPlay.PerformClick(); // 搜尋時停止自動播放

            UpdateWordList();
            if (lstWordList.Items.Count > 0)
            {
                lstWordList.SelectedIndex = 0;
                ShowWord(_DisplayList[0]);
                UpdateProgress(0);
            }
            else
            {
                txtWord.Text = "";
                txtPhonogram.Text = "";
                txtExplain.Text = "沒有符合的單字";
                UpdateProgress(-1);
            }
        }

        // ════════════════════════════════════════
        //  事件：速度
        // ════════════════════════════════════════

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            timePlayer.Interval = trkSpeed.Value * 1000;
            lblSpeed.Text = $"播放速度：{trkSpeed.Value}s";
        }

        // ════════════════════════════════════════
        //  事件：計時器 / 鍵盤
        // ════════════════════════════════════════

        private void timePlayer_Tick(object sender, EventArgs e)
        {
            NextWordList();
            PlaySelectedWord();
        }

        private void frmWordCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Focused) return; // 搜尋中不觸發
            if (isPlay) return;

            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    NextWordList();
                    PlaySelectedWord();
                    e.Handled = true;
                    break;
                case (char)Keys.Space:
                    if (lstWordList.SelectedIndex >= 0)
                        PlaySelectedWord();
                    e.Handled = true;
                    break;
            }
        }
    }
}
