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
    public partial class subInputAdmin : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public subInputAdmin()
        {
            InitializeComponent();
        }

        //개설과목 조회
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 과목.학과이름, 과목.과목이름, 개설과목.과목번호, 개설과목.연도 ,과목.대상학년,개설과목.학기,과목.이수학점, 교수.이름 AS 담당교수 FROM 과목 JOIN 개설과목 ON 과목.과목번호 = 개설과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호";
            updatedb(query);
        }
        //개설과목 학과별 조회
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 과목.학과이름, 과목.과목이름, 개설과목.과목번호, 개설과목.연도 ,과목.대상학년,개설과목.학기,과목.이수학점, 교수.이름 AS 담당교수 FROM 과목 JOIN 개설과목 ON 과목.과목번호 = 개설과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 where 과목.학과이름 = '{textBox2.Text}'";
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
        //과목조회
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            String query = $"select * from 과목";
            updatedb2(query);
        }
        //과목 학과별
        private void gradeButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            String query = $"select * from 과목 where 학과이름 = '{textBox1.Text}'";
            updatedb2(query);
        }
        private void updatedb2(String query)
        {
            dataGridView2.Rows.Clear();
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = query; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //결과
                dataGridView2.ColumnCount = 8;

                //필드명 받아오는 반복문
                for (int i = 0; i < 7; i++)
                {
                    dataGridView2.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[7]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 7; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView2.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        //개설과목 등록
        private void button3_Click(object sender, EventArgs e)
        {
            String subNum=subNumBox.Text;
            String year = yearBox.Text;
            String sem = semBox.Text;
            String proNum = proBox.Text;
            String query = $"insert into 개설과목 values('{subNum}','{year}', '{sem}', '{proNum}', NULL)";

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
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            mainAdmin f = new mainAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void subNumBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
