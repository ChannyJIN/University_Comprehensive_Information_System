using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universityP
{
    public partial class selectGrade : Form
    {
        String idNum = "";
        String studentId = "";
        String subNum = "";
        String grade = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public selectGrade(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum; 
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 개설과목.학기, 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 개설과목.담당교수번호 = '{idNum}'";
            updatedb(query);
        }

        private void subButton_Click_1(object sender, EventArgs e)
        {
            String sub = textBox1.Text.ToString();
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 개설과목.학기, 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 개설과목.담당교수번호 = '{idNum}' and 과목이름 = '{sub}'";
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
                dataGridView1.ColumnCount = 9;

                //필드명 받아오는 반복문
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[8]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 8; i++) // 필드 수만큼 반복
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
            
            //학번을 id에 저장
            studentId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            subNum = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Console.WriteLine(studentId);
            Console.WriteLine(subNum);
            String query = $"select 학생.학번, 학생.이름, 수강.성적 from 학생 join 수강 on 학생.학번 = 수강.학번 where 학생.학번 = '{studentId}' and 수강.과목번호 = '{subNum}'";

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();

            if (!read.Read())
            {
                MessageBox.Show("오류");
                if (conn != null)
                {
                    conn.Close();
                }
                return;
            }

            numLabel.Text = read.GetValue(0).ToString();
            nameLabel.Text = read.GetValue(1).ToString();
            comboBox1.Text = read.GetValue(2).ToString();
            conn.Close();
        }
        private void gradeUpdateButton_Click(object sender, EventArgs e)
        {
            grade = comboBox1.Text.ToString();
            Console.WriteLine(studentId);
            Console.WriteLine(subNum);
            Console.WriteLine(grade);
            String query = $"UPDATE 수강 SET 성적 = '{grade}' WHERE 학번 = '{studentId}' and 과목번호 = '{subNum}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("수정했습니다.");
                String selectQuery = $"SELECT 학생.학번, 학생.이름, 수강.성적, 개설과목.학기, 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 개설과목.담당교수번호 = '{idNum}'";
                updatedb(selectQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("다시 확인해주세요. Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }


            //String query = $"UPDATE 수강 SET 성적 = '{grade}' WHERE 학번 = '{idNum}' and 과목번호 = '{subNum}'";

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainProfessor f = new mainProfessor(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
