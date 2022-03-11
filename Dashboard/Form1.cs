using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalytics.Height;
            PnlNav.Top = BtnAnalytics.Top;
            PnlNav.Left = BtnAnalytics.Left;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Btncalender_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Btncalender.Height;
            PnlNav.Top = Btncalender.Top;
            PnlNav.Left = Btncalender.Left;
            Btncalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Btncontact_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Btncontact.Height;
            PnlNav.Top = Btncontact.Top;
            PnlNav.Left = Btncontact.Left;
            Btncontact.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Btnsettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Btnsettings.Height;
            PnlNav.Top = Btnsettings.Top;
            PnlNav.Left = Btnsettings.Left;
            Btnsettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btncalender_Leave(object sender, EventArgs e)
        {
            Btncalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btncontact_Leave(object sender, EventArgs e)
        {
            Btncontact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btnsettings_Leave(object sender, EventArgs e)
        {
            Btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
