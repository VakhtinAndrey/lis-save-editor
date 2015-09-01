using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeIsStrangeSaveEditor.Win
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            lblVersion.Text = string.Format("Version: {0}", AppHelper.GetApplicationVersionShortStr());

            var sb = new StringBuilder();
            sb.AppendLine("Thanks to:");
            sb.AppendLine(" • Eliot van Uytfanghe aka Eliot");
            sb.AppendLine(" • Wasteland Ghost aka wghost81");
            sb.AppendLine(" • Konstantin Nosov aka Gildor");
            sb.AppendLine(" • Kelnor277");
            sb.AppendLine(" • And my lovely girlfriend");
            sb.AppendLine();
            lblThanks.Text = sb.ToString();
        }

        private void llEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:smile.voronezh@gmail.com?subject=Life is Strange Save Editor");
        }
    }
}