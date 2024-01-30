using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_GAME
{
    public partial class save_score : Form
    {

        public SqlConnection CON;
        public SqlDataAdapter Adapter;
        public DataTable DT;
        public string playerxscore;
        public string playeroscore;
        public string Playerx;
        public string Playero;
        public save_score(string _playerx,string _playero, String _playerxscore,string _playeroscore)
        {
            this.Playerx = _playerx;
            this.Playero= _playero;
            this.playerxscore = _playerxscore;
            this.playeroscore = _playeroscore;
            CON = new SqlConnection("Server =DESKTOP-5G0EL89\\SQLEXPRESS; DataBase = XO-game; Trusted_Connection = True ; TrustServerCertificate = True");
            Adapter=new SqlDataAdapter();
            DT = new DataTable();

            InitializeComponent();
        }

        private void save_score_Load(object sender, EventArgs e)
        {
            SqlCommand selectcmd = new SqlCommand("select*from savescore;", CON);
            Adapter.SelectCommand = selectcmd;
            Adapter.Fill(DT);
            dgv_saveScores.DataSource = DT;

            SaveGame();
            RefreshData();
        }
        public void SaveGame()
        {
            string insertCommand = "INSERT INTO savescore (playerx, playero,playerxscore,playeroscore,Gamedate) VALUES (@PlayerxName, @playeroName,@playerxScore,@playeroScore,@time)";
            Adapter.InsertCommand = new SqlCommand(insertCommand, CON);
            DataTable Dt2 = new DataTable();
            Adapter.Fill(Dt2);
            Adapter.InsertCommand.Parameters.AddWithValue("@PlayerxName", Playerx);
            Adapter.InsertCommand.Parameters.AddWithValue("@playerxScore", playerxscore);
            Adapter.InsertCommand.Parameters.AddWithValue("@playeroName", Playero);
            Adapter.InsertCommand.Parameters.AddWithValue("@playeroScore", playeroscore);
            Adapter.InsertCommand.Parameters.AddWithValue("@time", DateTime.Now);

            CON.Open();
            Adapter.InsertCommand.ExecuteNonQuery();
            CON.Close();
            //RefreshData();
        }
        private void RefreshData()
        {
            SqlCommand selectcmd = new SqlCommand("SELECT * FROM savescore;", CON);
            Adapter.SelectCommand = selectcmd;
            DT.Clear(); // Clear the existing data in the DataTable
            Adapter.Fill(DT);
            dgv_saveScores.DataSource = DT;
        }
    }
   
}
