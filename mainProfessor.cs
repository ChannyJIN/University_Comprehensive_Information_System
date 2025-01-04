using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 이미지처리;

namespace universityP
{
    public partial class mainProfessor : Form
    {
        String idNum = "";
        String table = "";
        String name = "";
        public mainProfessor(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum;
        }


        private void selectMyStudent_Click(object sender, EventArgs e)
        {
            myStudent f = new myStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void gradeButton_Click(object sender, EventArgs e)
        {
            selectGrade f = new selectGrade(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void imageInput_Click(object sender, EventArgs e)
        {
            bookImage f = new bookImage(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void selectSugang_Click(object sender, EventArgs e)
        {

        }

        private void mainProfessor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePW f = new changePW(table, idNum, name);
            
            MessageBox.Show("비밀번호를 변경해주세요.");
            f.ShowDialog();
            
        }
    }
}
