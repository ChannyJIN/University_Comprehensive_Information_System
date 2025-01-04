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
    public partial class subInsertAdmin : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public subInsertAdmin()
        {
            InitializeComponent();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {

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

        private void selectAllButton_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            String query = $"select * from 과목";
            updatedb2(query);
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            String query = $"select * from 과목 where 학과이름 = '{textBox1.Text}'";
            updatedb2(query);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainAdmin f = new mainAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            text2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            text3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            text4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            text5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            text6.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            text7.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String query = $"insert into 과목 values('{text1.Text}','{text2.Text}', '{text3.Text}', '{text4.Text}', '{text5.Text}', '{text6.Text}', '{text7.Text}')";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("교과목을 추가했습니다.");

                String query2 = $"select * from 과목";
                updatedb2(query2);

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

        private void button1_Click(object sender, EventArgs e)
        {
            String query = $"delete 과목 where 과목번호 = '{text1.Text}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("교과목을 삭제했습니다.");
                String query2 = $"select * from 과목";
                updatedb2(query2);

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
