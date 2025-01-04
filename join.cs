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
    public partial class join : Form
    {
        String table = "";
        public join()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = "학생";
            joinStudent f = new joinStudent(table);
            this.Hide();
            f.ShowDialog();
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = "교수";
            joinPro f = new joinPro(table);
            this.Hide();
            f.ShowDialog();
            this.Close ();
        }
    }
}
