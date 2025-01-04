using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universityP
{

    public partial class consultSelectStudent : Form
    {
        String idNum = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public consultSelectStudent(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum; 
        }

        private void consultSelectStudent_Load(object sender, EventArgs e)
        {

        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            consultingBox.Clear();
            consultingDate.Clear();

            String query = $"select 상담.상담일자, 상담.상담내용, 교수.이름 AS 담당교수이름 from 학생 join 상담 ON 상담.학번 = 학생.학번 join 교수 ON 교수.교수번호 = 학생.지도교수 where 학생.학번='{idNum}'";

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();

            if (!read.Read())
            {
                MessageBox.Show("상담 내역이 없습니다.");
                if (conn != null)
                {
                    conn.Close();
                }
                return;
            }

            consultingDate.Text = read.GetDateTime(0).ToString("yyyy-MM-dd");
            consultingBox.Text = read.GetValue(1).ToString();
            textBox1.Text = read.GetValue(2).ToString();
            conn.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainStudent f = new mainStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
