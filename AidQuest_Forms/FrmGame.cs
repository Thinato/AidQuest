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

namespace AidQuest_Forms
{
    public partial class FrmGame : Form
    {
        Conexao con = new Conexao();
        Random rand = new Random();
        private float Time;
        private string TimeM, TimeS;
        private int Points, CurrentAnswer, CurrentDifficulty;
        
        public FrmGame()
        {
            InitializeComponent();
            GenerateQuestion();
            timer1.Enabled = true;
            pGameOver.Visible = false;
            Time = 10.0f;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time <= 0f)
            {
                timer1.Stop();
                MessageBox.Show("Tempo esgotado!\nSua pontuação foi: " + Points );
                GameOver();
            }
            Time -= 0.1f;
            TimeM = Math.Floor(Time / 60).ToString("0");
            TimeS = (Time % 60).ToString("00.#");
            //string TimeF = Time.ToString(":.0");
            lblTime.Text = $"Tempo: {TimeM}:{TimeS}";
        }
        private void Difficulty(int diff)
        {
            switch (diff)
            {
                case 1:
                    picDiff2.Image = Properties.Resources.star_unfilled;
                    picDiff3.Image = Properties.Resources.star_unfilled;
                    break;
                case 2:
                    picDiff2.Image = Properties.Resources.star_filled;
                    picDiff3.Image = Properties.Resources.star_unfilled;
                    break;
                case 3:
                    picDiff2.Image = Properties.Resources.star_filled;
                    picDiff3.Image = Properties.Resources.star_filled;
                    break;

            }
        }
        private void GameOver()
        {
            

            pGameOver.Visible = true;
            pGameOver.Location = new Point((this.Width / 2) - (pGameOver.Width / 2), (this.Height / 2) - (pGameOver.Height / 2));
        }
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }
        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                con.Connect();
                DateTime time = DateTime.Now;
                string command = "INSERT INTO scoreboard (NAME, POINTS, DATE) " +
                              $"VALUES ('{txtNome.Text.Trim()}', {Points}, '{time.ToString("dd/MM/yy")}')";
                SQLiteCommand cmd = new SQLiteCommand(command, con.connection);
                cmd.ExecuteNonQuery();
                con.Disconnect();
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(4);
        }

        private void GenerateQuestion()
        {
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            btnAnswer4.Enabled = true;
            try
            {
                con.Connect();

                string query = "SELECT * FROM questions;";
                SQLiteDataAdapter data = new SQLiteDataAdapter(query, con.connection);
                DataTable table = new DataTable();
                data.Fill(table);
                int qID = rand.Next(table.Rows.Count);
                lblQuestion.Text = table.Rows[qID][1].ToString();

                btnAnswer1.Text = table.Rows[qID][2].ToString();
                btnAnswer2.Text = table.Rows[qID][3].ToString();
                btnAnswer3.Text = table.Rows[qID][4].ToString();
                btnAnswer4.Text = table.Rows[qID][5].ToString();

                if (btnAnswer3.Text == "none")
                    btnAnswer3.Enabled = false;
                if (btnAnswer4.Text == "none")
                    btnAnswer4.Enabled = false;

                CurrentAnswer = Convert.ToInt32(table.Rows[qID][6]);

                CurrentDifficulty = Convert.ToInt32(table.Rows[qID][7]);
                Difficulty(Convert.ToInt32(table.Rows[qID][7]));
                


                con.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CheckAnswer(int answer)
        {
            if (CurrentAnswer == answer)
            {
                Points += CurrentDifficulty * 10;
                Time += 2f;
                lblLastPoints.Text = "+" + (CurrentDifficulty * 10).ToString();
                lblLastPoints.ForeColor = Color.FromArgb(128, 255, 128);
            }
            else
            {
                Points -= (4 - CurrentDifficulty) * 10;
                lblLastPoints.Text = "-" + ((4 - CurrentDifficulty) * 10).ToString();
                lblLastPoints.ForeColor = Color.FromArgb(255, 128, 128);
            }
            if (Points <= 0)
                Points = 0;
            lblPoints.Text = "Points: " + Points;
            GenerateQuestion();
        }
    }
}
