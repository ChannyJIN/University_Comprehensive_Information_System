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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace universityP
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public Form1()
        {
            InitializeComponent();

            passwordTextBox.PasswordChar = '*';
        }

        //로그인 버튼
        private void loginButton_Click(object sender, EventArgs e)
        {

            String idNum = idNumTextBox.Text.ToString();
            //교번,학번이 숫자인지 검사
            if (!int.TryParse(idNum, out _))
            {
                MessageBox.Show("학번 및 교번을 확인해주세요(숫자)");
                return;
            }
            

            String passwd = passwordTextBox.Text;
            String table = comboBox1.Text.ToString();

            //관리자 로그인
            if(table=="관리자" && idNum=="9999" && passwd == "0317")
            {
                mainAdmin f = new mainAdmin();
                MessageBox.Show($"관리자님 환영합니다.", "로그인성공");
                this.Hide();
                f.ShowDialog();
                this.Close();
                return;
            }

            SHA256 hash1 = new SHA256Managed();
            byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(passwd));

            // 16진수 형태로 문자열 결합
            StringBuilder sb1 = new StringBuilder();
            foreach (byte b1 in bytes1)
                sb1.AppendFormat("{0:x2}", b1);

            // 입력값의 해시결과
            String crypted_pw = sb1.ToString();

            //콘솔창에 띄워줌
            Console.WriteLine(crypted_pw);
            //admin passwd 

            String query = "";
            if (table == "학생")
            {
                query = $"select 이름 from {table} where 학번='{idNum}' and 비밀번호='{crypted_pw}'";
            }
            else if(table == "교수")
            {
                query = $"select 이름 from {table} where 교수번호='{idNum}' and 비밀번호='{crypted_pw}'";
            }

            

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();

            if (!read.Read())
            {
                MessageBox.Show("가입 정보가 없습니다.", "로그인실패");
                if (conn != null)
                {
                    conn.Close();
                }
                return;
            }

            String name = read.GetString(0);
            conn.Close();

            //비밀번호가 0000이면 비밀번호 변경 띄우기
            if (passwd == "0000")
            {
                changePW f = new changePW(table,idNum,name);
                this.Hide();
                MessageBox.Show("비밀번호를 변경해주세요.");
                f.ShowDialog();
                this.Close();
            }

            
            //바꾸기
            if (passwd != "0000")
            {
                if (table == "학생")
                {
                    
                    mainStudent f = new mainStudent(idNum);
                    MessageBox.Show($"{name} 학생 환영합니다.", "로그인성공");
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else if (table == "교수")
                {
                    
                    mainProfessor f = new mainProfessor(idNum);
                    MessageBox.Show($"{name} 교수님 환영합니다.", "로그인성공");
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
            
        }

        //회원가입 버튼
        private void joinButton_Click(object sender, EventArgs e)
        {
            join f = new join();
            f.ShowDialog();
        }


        //학생,교수,관리자 콤보박스
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //아이디 텍스트 박스
        private void idNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //비밀번호 텍스트박스
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
