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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace universityP
{
    public partial class sugangAdmin : Form
    {
        String studentId = "";
        String subName = "";
        String Name = "";
        String grade = "";
        String subNum = "";
        String addQ = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public sugangAdmin()
        {
            InitializeComponent();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년 , 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호";
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
                for (int i = 0; i < 9; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[9]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 9; i++) // 필드 수만큼 반복
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

        private void majorSelectButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년, 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 where 과목.학과이름 = '{textBox1.Text}'";
            updatedb(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBox1.Text.Length > 0)
            {
                addQ = $"and 과목.학과이름 = '{textBox1.Text}'";
            }
            String query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년, 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 where 과목.대상학년 = '{textBox2.Text}' {addQ}";
            updatedb(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            grade = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            subName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            subNum = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            numLabel.Text = studentId;
            nameLabel.Text = Name;
            gradeLabel.Text = grade;
            subLabel.Text = subName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainAdmin f = new mainAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void gradeUpdateButton_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(studentId);
            
            String query = $"UPDATE 수강 SET 승인 = 'TRUE' WHERE 학번 = '{studentId}'and 과목번호='{subNum}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("승인완료됐습니다.");
                String selectQuery = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년 , 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호";
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
        }
        //승인 취소 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(studentId);

            String query = $"DELETE 수강 WHERE 학번 = '{studentId}'and 과목번호='{subNum}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("신청이 취소됐습니다.");
                String selectQuery = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년 , 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호";
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
        }
    }
}
