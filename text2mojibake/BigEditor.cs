using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2mojibake
{
    public partial class BigEditor : Form
    {
        public string ModifiedText
        {
            get => this.textBox1.Text;
        }
        public bool Modified
        {
            get => this.textBox1.Modified;
        }
        
        public BigEditor()
        {
            this.InitializeComponent();
        }

        public void SetText(string text) => this.textBox1.Text = text;
    }
}
