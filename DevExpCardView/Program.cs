using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpCardView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo ci = null;
            switch (1)
            {
                case 1:
                    ci = new CultureInfo("en-US");
                    break;
                case 2:
                    ci = new CultureInfo("ar-AE");
                    break;
                default:
                    ci = new CultureInfo("en-US");
                    break;
            }
            if (ci != null)
            {
                ci.DateTimeFormat.FullDateTimePattern = "dd/MM/yyyy hh:mm:ss tt";
                ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                ci.DateTimeFormat.ShortTimePattern = "hh:mm:ss tt";
                ci.DateTimeFormat.AMDesignator = "AM";
                ci.DateTimeFormat.PMDesignator = "PM";
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = ci;
            }
            else
            {
                MessageBox.Show("Error in Setting UI Language!");
                Application.Exit();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
