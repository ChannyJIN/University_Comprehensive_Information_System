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
    public partial class mainAdmin : Form
    {
        public mainAdmin()
        {
            InitializeComponent();
        }
        //학과등록
        private void button5_Click(object sender, EventArgs e)
        {
            majorAdmin f = new majorAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        //수강승인
        private void sugang_Click(object sender, EventArgs e)
        {
            sugangAdmin f = new sugangAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subInputAdmin f = new subInputAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentAdmin f = new studentAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            subInsertAdmin f = new subInsertAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proAdmin f = new proAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
