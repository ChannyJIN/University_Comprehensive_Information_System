using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universityP
{
    public partial class mainStudent : Form
    {
        String idNum = "";
        String table = "";
        String name = "";
        
        public mainStudent(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum; 
        }
        //수강신청
        private void button1_Click(object sender, EventArgs e)
        {
            sugangStudent f = new sugangStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        //성적조회
        private void button2_Click(object sender, EventArgs e)
        {
            gradeSelectStudent f = new gradeSelectStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        //상담조회
        private void button3_Click(object sender, EventArgs e)
        {
            consultSelectStudent f =new consultSelectStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changePW f = new changePW(table, idNum, name);
            
            MessageBox.Show("비밀번호를 변경해주세요.");
            f.ShowDialog();
            
        }
    }
}
