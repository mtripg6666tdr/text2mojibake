using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2mojibake
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            string DefaultCulture = "ja";
            if(File.Exists(Helper.GetFullPath("locale.lc"))){
                DefaultCulture = File.ReadAllText(Helper.GetFullPath("locale.lc"));
            }
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(DefaultCulture);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new text2mojibake());
        }
    }
}
