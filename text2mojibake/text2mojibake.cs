using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2mojibake
{
    public partial class text2mojibake : Form
    {

        public text2mojibake()
        {
            this.InitializeComponent();
            if(Properties.Settings.Default.ConvertHistory == null)
            {
                Properties.Settings.Default.ConvertHistory = new System.Collections.Specialized.StringCollection();
            }
            this.InitializeEncodings();
            this.UpdateOriginalCombo();
        }

        private void EncodingType_SelectedIndexChanged(object sender, EventArgs e) => this.MojibakeRunner();

        private void DecodingType_SelectedIndexChanged(object sender, EventArgs e) => this.MojibakeRunner();

        private void OriginalTextHolder_KeyUp(object sender, KeyEventArgs e) => this.MojibakeRunner();

        private string CreateMojibake(string text, Encoding EncodeType, Encoding DecodeType) => DecodeType.GetString(EncodeType.GetBytes(text));

        private void MojibakeRunner()
        {
            if(string.IsNullOrEmpty(this.EncodingType.Text) || 
                string.IsNullOrEmpty(this.DecodingType.Text) ||
                string.IsNullOrEmpty(this.OriginalTextHolder.Text))
            {
                return;
            }
            Encoding Enc = Encoding.GetEncoding(this.EncodingType.Text);
            Encoding Dec = Encoding.GetEncoding(this.DecodingType.Text);
            this.OutputTextHolder.Text = this.CreateMojibake(this.OriginalTextHolder.Text, Enc, Dec);
            if (!Properties.Settings.Default.ConvertHistory.Contains(this.OriginalTextHolder.Text))
            {
                Properties.Settings.Default.ConvertHistory.Add(this.OriginalTextHolder.Text);
            }
            this.UpdateOriginalCombo();
        }

        private void UpdateOriginalCombo()
        {
            this.OriginalTextHolder.Items.Clear();
            foreach (string v in Properties.Settings.Default.ConvertHistory)
            {
                this.OriginalTextHolder.Items.Add(v);
            }
        }

        private void InitializeEncodings()
        {
            EncodingInfo[] infos = Encoding.GetEncodings();
            foreach(EncodingInfo v in infos)
            {
                this.EncodingType.Items.Add(v.Name);
                this.DecodingType.Items.Add(v.Name);
            }
        }

        private void text2mojibake_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            using(AboutBox box = new AboutBox())
            {
                box.ShowDialog();
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.OutputTextHolder.Text))
            {
                Clipboard.SetText(this.OutputTextHolder.Text);
                MessageBox.Show(Properties.Resources.ResourceManager.GetString("CompleteCopyingDescription"),
                    Properties.Resources.ResourceManager.GetString("CompleteCopyingTitle"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OriginalTextHolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OpenBigEdit((TextBox)sender);
        }

        private void OpenBigEdit(TextBox targetControl)
        {
            using (BigEditor editor = new BigEditor())
            {
                editor.SetText(this.OriginalTextHolder.Text);
                editor.ShowDialog();
                if (editor.Modified && !targetControl.ReadOnly)
                {
                    targetControl.Text = editor.ModifiedText;
                }
            }
        }

        private void OutputTextHolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OpenBigEdit((TextBox)sender);
        }

        private void text2mojibake_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F9 && e.Control)
            {
                Properties.Settings.Default.ConvertHistory = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.ConvertHistory.Add("こんにちは");
                Properties.Settings.Default.ConvertHistory.Add("ありがとう");
                Properties.Settings.Default.ConvertHistory.Add("こんばんは");
                this.UpdateOriginalCombo();
            }
        }
    }
}
