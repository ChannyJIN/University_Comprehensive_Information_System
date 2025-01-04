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
    public partial class gradeSelectStudent : Form
    {
        String idNum = "";
        String subNum = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public gradeSelectStudent(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum;
        }

        private void gradeSelectStudent_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainStudent f = new mainStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.이름 AS 학생이름, 학생.학번 AS 학생학번, 과목.과목이름, 수강.연도 AS 수강연도, 수강.학기 AS 수강학기, 수강.성적 AS 수강성적 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 과목 ON 수강.과목번호 = 과목.과목번호 WHERE 학생.학번 = '{idNum}'";
            updatedb(query);
        }
        private void updatedb(String query)
        {
            dataGridView1.Rows.Clear();
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = query; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //결과
                dataGridView1.ColumnCount = 6;

                //필드명 받아오는 반복문
                for (int i = 0; i < 6; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[6]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 6; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


        }
    }
}
