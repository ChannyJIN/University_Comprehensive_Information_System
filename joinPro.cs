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
using System.Xml.Linq;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Collections;
using System.Reflection.Emit;

namespace universityP
{
    public partial class joinPro : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        String table = "";
        bool check=false;
        public joinPro(String table)
        {
            InitializeComponent();
            this.table = table;
        }
      
        private void joinButton_Click(object sender, EventArgs e)
        {
            //중복검사 여부
            if (!check)
            {
                MessageBox.Show("중복 검사를 해주세요.");
                return;
            }

            String id = idNumTextBox.Text.ToString();
            String name = nameTextBox.Text.ToString();
            //비밀번호 hash
            String passwd = "0000";
            SHA256 hash1 = new SHA256Managed();
            byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(passwd));
            // 16진수 형태로 문자열 결합
            StringBuilder sb1 = new StringBuilder();
            foreach (byte b1 in bytes1)
                sb1.AppendFormat("{0:x2}", b1);

            String major = majorTextBox.Text.ToString();
            //쿼리문
            String query = "INSERT INTO 교수 VALUES('" + id + "','" + name + "','" + sb1 + "','" + major + "')";

            //데이터베이스 연결
            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("회원가입되었습니다.", "회원가입 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    
                    conn.Close(); //데이터베이스 연결 해제
                    Close();
                }
            }

        }
        private void testButton_Click(object sender, EventArgs e)
        {
            String id = idNumTextBox.Text.ToString();
            //교번,학번이 숫자인지 검사
            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("학번 및 교번을 확인해주세요(숫자)");
                return;
            }


            String query = $"select 교수번호 from {table} where 교수번호='{id}'";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();

            if (!read.Read())
            {
                MessageBox.Show("가입 정보가 없습니다.");
                if (conn != null)
                {
                    check = true;
                    conn.Close();
                    
                }
                return;
            }
            else
            {
                MessageBox.Show("이미 가입한 회원입니다.");
            }
        }
        private void joinPro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
