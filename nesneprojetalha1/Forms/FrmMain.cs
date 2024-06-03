using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesneprojetalha1.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
      


        void OpenForm(Form f)
        {
         panel2.Controls.Clear();
         f.TopLevel = false;
         panel2.Controls.Add(f);
         f.WindowState = FormWindowState.Maximized;
         f.BackColor = SystemColors.ActiveCaption;
         f.FormBorderStyle = FormBorderStyle.None;
         f.ForeColor = SystemColors.HotTrack;
         f.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenForm(new FrmBlocks());
            lbTitle.Text = "Bloklar Tablosu";
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBlocks());
            lbTitle.Text = "Bloklar Tablosu";
        }

        private void btnCarPark_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCarPark());
            lbTitle.Text = "Otopark Tablosu";
        }

        private void btnDoorman_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDoorman());
            lbTitle.Text = "Kapıcı Tablosu";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
