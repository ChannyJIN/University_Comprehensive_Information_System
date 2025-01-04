using System;
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
using System.Xml.Linq;


namespace universityP
{
    public partial class changePW : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결

        String table = "";
        String name = "";
        String idNum = "";
        public changePW(String table, string idNum, String name)
        {
            InitializeComponent();
            pwTextBox.PasswordChar = '*';
            pwCheckTextBox.PasswordChar = '*';
            
            this.table = table;
            this.idNum = idNum;
            this.name = name;   
        }

        private void pwChangeTextBox_Click(object sender, EventArgs e)
        {
            
            String passwd = pwTextBox.Text.ToString();
            String passwdCheck = pwCheckTextBox.Text.ToString();
            String query = "";
            bool check=false;

            //비밀번호 암호화
            SHA256 hash1 = new SHA256Managed();
            byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(passwd));

            // 16진수 형태로 문자열 결합
            StringBuilder sb1 = new StringBuilder();
            foreach (byte b1 in bytes1)
                sb1.AppendFormat("{0:x2}", b1);

            // 입력값의 해시결과
            String crypted_pw = sb1.ToString();
            
            if (passwd == passwdCheck && passwd!="0000")
            {
                //쿼리문 만들기
                if (table=="학생")
                {
                    query = $"update 학생 set 비밀번호 = '{crypted_pw}' where 학번 = '{idNum}'";
                }
                else if (table == "교수")
                {
                    query = $"update 교수 set 비밀번호 = '{crypted_pw}' where 교수번호 = '{idNum}'";
                }

                //쿼리문 적용
                try
                {
                    conn = new OleDbConnection(connectionString);
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("비밀번호가 변경되었습니다.");
                    check = true;
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
                if (check)
                {
                    if (table == "학생")
                    {
                        mainStudent f = new mainStudent(idNum);
                        this.Hide();
                        MessageBox.Show($"{name} 학생 환영합니다.", "로그인성공");
                        f.ShowDialog();
                        this.Close();

                    }
                    else if (table == "교수")
                    {
                        mainProfessor f = new mainProfessor(idNum);
                        this.Hide();
                        MessageBox.Show($"{name} 교수님 환영합니다.", "로그인성공");
                        f.ShowDialog();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("비밀번호를 확인해주세요.");
            }
        }

        private void pwCheckTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
