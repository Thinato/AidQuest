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
    public partial class FrmCreateNew : Form
    {
        Conexao con = new Conexao();
        private int Difficulty;
        public FrmCreateNew()
        {
            InitializeComponent();
            UpdateList();
            cmbCorrectAnswer.SelectedIndex = 0;
            Difficulty = 1;
        }

        private void btnEraseQuestion_Click(object sender, EventArgs e)
        {
            if (listQuestions.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma pergunta primeiro.");
                return;
            }
            else
            {
                int id = Convert.ToInt32(listQuestions.SelectedItem.ToString().Substring(0,3));
                EraseQuestion(id);
            }
        }
        private void EraseQuestion(int ID)
        {
            try
            {
                con.Connect();

                string command = "DELETE FROM questions WHERE ID=" + ID;
                SQLiteCommand cmd = new SQLiteCommand(command, con.connection);
                cmd.ExecuteNonQuery();
                
                con.Disconnect();
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateList()
        {
            try
            {
                con.Connect();
                listQuestions.Items.Clear();
                string query = "select ID, QUESTION from questions";
                SQLiteDataAdapter data = new SQLiteDataAdapter(query, con.connection);
                DataTable table = new DataTable();
                data.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    listQuestions.Items.Add(row[0].ToString().PadLeft(3, '0') + ": " + row[1].ToString());
                }




                con.Disconnect();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCorrectAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetColors();
            switch (cmbCorrectAnswer.SelectedIndex)
            {
                case 0:
                    lblAnswerA.ForeColor = Color.Gold;
                    txtAnswerA.BackColor = Color.FromArgb(90, 90, 90);
                    break;
                case 1:
                    lblAnswerB.ForeColor = Color.Gold;
                    txtAnswerB.BackColor = Color.FromArgb(90, 90, 90);
                    break;
                case 2:
                    lblAnswerC.ForeColor = Color.Gold;
                    txtAnswerC.BackColor = Color.FromArgb(90, 90, 90);
                    break;
                case 3:
                    lblAnswerD.ForeColor = Color.Gold;
                    txtAnswerD.BackColor = Color.FromArgb(90, 90, 90);
                    break;
            }
        }
        private void ResetColors()
        {
            lblAnswerA.ForeColor = Color.White;
            lblAnswerB.ForeColor = Color.White;
            lblAnswerC.ForeColor = Color.White;
            lblAnswerD.ForeColor = Color.White;

            txtAnswerA.BackColor = Color.FromArgb(50,50,50);
            txtAnswerB.BackColor = Color.FromArgb(50,50,50);
            txtAnswerC.BackColor = Color.FromArgb(50,50,50);
            txtAnswerD.BackColor = Color.FromArgb(50,50,50);
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Connect();

                // check limits
                if (string.IsNullOrEmpty(txtQuestion.Text))
                {
                    MessageBox.Show("A pergunta não pode estar vazia");
                    return;
                }
                switch (cmbCorrectAnswer.SelectedItem)
                {
                    case "A":
                        if (string.IsNullOrEmpty(txtAnswerA.Text))
                            { MessageBox.Show("A resposta não pode ser ''"); return; }
                        break;
                    case "B":
                        if (txtAnswerB.Text == "none")
                            { MessageBox.Show("A resposta não pode ser 'none'"); return; }
                            break;
                    case "C":
                        if (txtAnswerC.Text == "none")
                            { MessageBox.Show("A resposta não pode ser 'none'"); return; }
                            break;
                    case "D":
                        if (txtAnswerD.Text == "none")
                            { MessageBox.Show("A resposta não pode ser 'none'"); return; }
                        break;
                }


                string command =  "INSERT INTO questions (QUESTION, ANSWER1, ANSWER2, ANSWER3, ANSWER4, CORRECT) " +
                                $"VALUES ('{txtQuestion.Text.Trim()}', '{txtAnswerA.Text.Trim()}', '{txtAnswerB.Text.Trim()}', '{txtAnswerC.Text.Trim()}', '{txtAnswerD.Text.Trim()}', {cmbCorrectAnswer.SelectedIndex + 1}  )";
                SQLiteCommand cmd = new SQLiteCommand(command, con.connection);
                cmd.ExecuteNonQuery();
                con.Disconnect();
                UpdateList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string prompt = 
                "Lista - Ao clicar em um item da lista você pode ver o que a pergunta diz, mas não pode atualiza-la, você precisa apaga-la primeiro e criar uma nova;\n\n" +
                "none - Significa que essa resposta não será utilizada, deixe como \"none\" para quando a pergunta tiver menos de 4 respostas.";

            MessageBox.Show(prompt,"Ajuda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(listQuestions.SelectedItem.ToString().Substring(0, 3));
                FillControls(id);
            }catch
            {
                UpdateList();
            }
        }

        private void FillControls(int ID)
        {
            try
            {
                con.Connect();

                string query = "select * from questions where ID=" + ID;
                SQLiteDataAdapter data = new SQLiteDataAdapter(query, con.connection);
                DataTable table = new DataTable();
                data.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    txtQuestion.Text = row[1].ToString();
                    txtAnswerA.Text = row[2].ToString();
                    txtAnswerB.Text = row[3].ToString();
                    txtAnswerC.Text = row[4].ToString();
                    txtAnswerD.Text = row[5].ToString();
                    cmbCorrectAnswer.SelectedIndex = Convert.ToInt32(row[6]) - 1;
                    
                }



                con.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Textbox Placeholders
        private void txtAnswerB_Enter(object sender, EventArgs e)
        {
            if (txtAnswerB.Text == "none")
            {
                txtAnswerB.Text = "";
            }
        }

        private void txtAnswerB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswerB.Text))
            {
                txtAnswerB.Text = "none";
            }
        }

        private void txtAnswerC_Enter(object sender, EventArgs e)
        {
            if (txtAnswerC.Text == "none")
            {
                txtAnswerC.Text = "";
            }
        }

        private void txtAnswerC_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswerC.Text))
            {
                txtAnswerC.Text = "none";
            }
        }

        private void txtAnswerD_Enter(object sender, EventArgs e)
        {
            if (txtAnswerD.Text == "none")
            {
                txtAnswerD.Text = "";
            }
        }

        private void txtAnswerD_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswerD.Text))
            {
                txtAnswerD.Text = "none";
            }
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSaveCurrent_Click(object sender, EventArgs e)
        {
            try 
            {
                con.Connect();

                int id = Convert.ToInt32(listQuestions.SelectedItem.ToString().Substring(0, 3));
                string command =   "update questions " +
                                $"set QUESTION='{txtQuestion.Text}', ANSWER1='{txtAnswerA.Text}', ANSWER2='{txtAnswerB.Text}', ANSWER3='{txtAnswerC.Text}', ANSWER4='{txtAnswerD.Text}', CORRECT={cmbCorrectAnswer.SelectedIndex + 1}, DIFF={Difficulty} " +
                                 "where ID="+id+";";
                SQLiteCommand cmd = new SQLiteCommand(command, con.connection);
                cmd.ExecuteNonQuery();

                con.Disconnect();
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picDiff1_Click(object sender, EventArgs e)
        {
            SetDifficulty(1);
        }

        private void picDiff2_Click(object sender, EventArgs e)
        {
            SetDifficulty(2);
        }

        private void picDiff3_Click(object sender, EventArgs e)
        {
            SetDifficulty(3);
        }
        private void SetDifficulty(int diff)
        {
            Difficulty = diff;
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
    }
}
