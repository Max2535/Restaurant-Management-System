using DevExpress.Utils;
using DevExpress.XtraEditors;
using RM.Data;
using RM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class fmtLogin : DevExpress.XtraEditors.XtraForm
    {
        public fmtLogin()
        {
            InitializeComponent();
            panelControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void fmtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                login();
            }
        }

        private void login()
        {
            if (!DataContext.IsValidUser(txtUser.Text, txtPass.Text))
            {
                // Creates a new instance of the XtraMessageBoxArgs class.
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();

                // Sets AllowHtmlText to true to allow HTML formatting in the message box text.
                args.AllowHtmlText = DefaultBoolean.True;

                // Sets the size of the image displayed in the message box.
                //svgImageCollection1.ImageSize = new Size(24, 24);

                // Sets the SVG images to be displayed in the message box.
                //args.HtmlImages = svgImageCollection1;

                // Sets the caption of the message box.
                args.Caption = "Error";

                // Sets the message to be displayed in the message box.
                args.Text = "<b>username หรือ password ไม่ถูกต้อง<b>";

                // Sets the buttons to be displayed in the message box.
                args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };

                // Displays the message box with the specified arguments.
                XtraMessageBox.Show(args);
            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }
    }
}
