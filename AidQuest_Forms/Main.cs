using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AidQuest_Forms
{
    public partial class Main : Form
    {
        private Form activeForm = null;
        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pMDIForm.Controls.Add(childForm);
            pMDIForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGame()) ;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCreateNew());
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLeaderBoard());
        }
    }
}
