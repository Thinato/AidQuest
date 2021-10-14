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
    public partial class FrmLeaderBoard : Form
    {
        Conexao con = new Conexao();
        public FrmLeaderBoard()
        {
            InitializeComponent();
            UpdateTable();
        }
        private void UpdateTable()
        {
            try
            {
                con.Connect();

                string query = "select NAME as Nome, POINTS as Pontos, DATE as Data " +
                               "from scoreboard ORDER BY POINTS DESC";
                SQLiteDataAdapter data = new SQLiteDataAdapter(query, con.connection);
                DataTable table = new DataTable();

                table.Columns.Add("Posição");
                data.Fill(table);
                int j = 1;
                foreach (DataRow row in table.Rows)
                {
                    row[0] = j;
                    j++;
                }

                for (int i = 10; i < table.Rows.Count; i++)
                {
                    table.Rows.Remove(table.Rows[i]);
                }
                
                dgLeaderBoard.DataSource = table;
                dgLeaderBoard.RowHeadersVisible = false;
                dgLeaderBoard.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgLeaderBoard.Columns[0].Width = 100;
                dgLeaderBoard.Columns[1].Width = 159;
                dgLeaderBoard.Columns[2].Width = 100;
                dgLeaderBoard.Columns[3].Width = 100;

                con.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
