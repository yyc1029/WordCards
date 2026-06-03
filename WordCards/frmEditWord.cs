using System;
using System.Windows.Forms;

namespace WordCards
{
    public partial class frmEditWord : Form
    {
        public WordItem Word { get; set; } = null;

        public frmEditWord(WordItem word)
        {
            InitializeComponent();

            this.Word = word;
            txtWord.Text       = word.Word;
            txtPhonogram.Text  = word.Phonogram;
            txtSoundPath.Text  = word.SoundPath;
            txtExplain.Text    = word.Explain;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Word.Phonogram = txtPhonogram.Text;
            Word.SoundPath = txtSoundPath.Text;
            Word.Explain   = txtExplain.Text;
        }
    }
}
