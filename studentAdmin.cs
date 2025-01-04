﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universityP
{
    public partial class studentAdmin : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        String passwd = "";
        StringBuilder sb1 = new StringBuilder();
        public studentAdmin()
        {
            InitializeComponent();
            passwd = "0000";
            SHA256 hash1 = new SHA256Managed();
            byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(passwd));
            // 16진수 형태로 문자열 결합
            foreach (byte b1 in bytes1)
                sb1.AppendFormat("{0:x2}", b1);
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            String query = $"select 학번, 이름, 학년, 지도교수, 학과이름 from 학생";
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
                dataGridView2.ColumnCount = 5;

                //필드명 받아오는 반복문
                for (int i = 0; i < 5; i++)
                {
                    dataGridView2.Columns[i].Name = read.GetName(i);
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

                    dataGridView2.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            String query = $"select 학번, 이름, 학년, 지도교수, 학과이름 from 학생 where 학과이름 = '{text5.Text}'";
            updatedb2(query);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            text2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            text3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            text4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            text5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String query = $"insert into 학생 values('{text1.Text}','{text2.Text}','{text3.Text}', '{sb1}', '{text4.Text}','{text5.Text}')";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("학생을 추가했습니다.");

                String query2 = $"select 학번, 이름, 학년, 지도교수, 학과이름 from 학생";
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

        private void button2_Click(object sender, EventArgs e)
        {
            String query = $"UPDATE 학생 SET 학번 = '{text1.Text}',이름 = '{text2.Text}', 학년 = '{text3.Text}', 지도교수 = '{text4.Text}', 학과이름 = '{text5.Text}' WHERE 학번 = '{text1.Text}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("학생정보를 수정했습니다.");
                String query2 = $"select 학번, 이름, 학년, 지도교수, 학과이름 from 학생";
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

        private void button4_Click(object sender, EventArgs e)
        {
            String query = $"delete 학생 where 학번 = '{text1.Text}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("학생을 삭제했습니다.");
                String query2 = $"select 학번, 이름, 학년, 지도교수, 학과이름 from 학생";
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

        private void backButton_Click(object sender, EventArgs e)
        {
            mainAdmin f = new mainAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
