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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace universityP
{
    public partial class myStudent : Form
    {
        String studentId = "";
        String idNum = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public myStudent(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum; 
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.학번, 학생.이름, 학생.학년, 학생.학과이름, 교수.이름 as 지도교수 FROM 학생 INNER JOIN 교수 ON 학생.지도교수 = 교수.교수번호 where 교수번호 = '{idNum}'";
            updatedb(query);
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String grade = textBox1.Text.ToString() ;
            String query = $"SELECT 학생.학번, 학생.이름, 학생.학년, 학생.학과이름, 교수.이름 as 지도교수 FROM 학생 INNER JOIN 교수 ON 학생.지도교수 = 교수.교수번호 where 학년 = '{grade}' and 교수번호 = '{idNum}'";
            updatedb(query);

        }
        private void updatedb(String query)
        {
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
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[5]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 5; i++) // 필드 수만큼 반복
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
            consultingBox.Clear();
            consultingDate.Clear();

            //학번을 id에 저장
            studentId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(studentId);
            String query = $"select 상담일자, 상담내용 from 상담 where 학번='{studentId}'";

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
            conn.Close();
        }
        //상담 내역 추가 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            String consultDate = consultingDate.Text.ToString();
            String consultBox = consultingBox.Text.ToString();
            String query = $"insert into 상담 values('{studentId}','{consultDate}', '{consultBox}')";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("상담내역을 추가했습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가, 수정, 삭제중 다시 확인해주세요. Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {

                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        //상담 내역 삭제 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            String consultDate = consultingDate.Text.ToString();
            String consultBox = consultingBox.Text.ToString();
            String query = $"delete from 상담 where 학번 ='{studentId}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("상담내역을 삭제했습니다.");
                consultingBox.Clear();
                consultingDate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가, 수정, 삭제중 다시 확인해주세요. Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        //상담 내역 수정 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            String consultDate = consultingDate.Text.ToString();
            String consultBox = consultingBox.Text.ToString();
            String query = $"UPDATE 상담 SET 상담일자 = '{consultDate}', 상담내용 = '{consultBox}' WHERE 학번 = '{studentId}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("상담내역을 수정했습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가, 수정, 삭제중 다시 확인해주세요. Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainProfessor f = new mainProfessor(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void consultingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultingDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
