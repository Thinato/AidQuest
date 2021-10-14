using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace AidQuest_Forms
{
    public partial class Main : Form
    {
        private Form activeForm = null;
        public Main()
        {
            InitializeComponent();
            CreateDB();
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
        private void CreateDB()
        {
            if (!File.Exists(".\\AidQuest"))
            {
                SQLiteConnection.CreateFile("AidQuest.db");
                SQLiteConnection connection = new SQLiteConnection("Data Source=AidQuest.db");
                connection.Open();
                string createQuestions = "CREATE TABLE \"questions\" (\"ID\"    INTEGER NOT NULL, \"QUESTION\"  TEXT, \"ANSWER1\"   TEXT NOT NULL DEFAULT 'Sem resposta', \"ANSWER2\"   TEXT NOT NULL DEFAULT 'none', \"ANSWER3\"   TEXT NOT NULL DEFAULT 'none', \"ANSWER4\"   TEXT NOT NULL DEFAULT 'none', \"CORRECT\"   INTEGER, \"DIFF\"  INTEGER NOT NULL DEFAULT 1, PRIMARY KEY(\"ID\" AUTOINCREMENT)); ";
                SQLiteCommand commandQuestions = new SQLiteCommand(createQuestions, connection);
                commandQuestions.ExecuteNonQuery();
                
                string createScoreboard = "CREATE TABLE \"scoreboard\" (\"ID\"    INTEGER NOT NULL, \"NAME\"  TEXT NOT NULL DEFAULT 'unnamed', \"POINTS\"    INTEGER NOT NULL DEFAULT 0, \"DATE\"  TEXT, PRIMARY KEY(\"ID\" AUTOINCREMENT)); ";
                SQLiteCommand commandScoreboard = new SQLiteCommand(createScoreboard, connection);



            }
        }
    }
}
