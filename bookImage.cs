using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using universityP;
using System.Xml;
using System.Xml.Linq;
namespace 이미지처리
{
    public partial class bookImage : Form
    {
        String idNum = "";
        String subNum = "0003";
        String subName = "";
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=0317;User ID=jin"; //oracle 서버 연결
        // BLOB 를 다루기 위해서는 반드시 Provider=OraOLEDB.Oracle 
        Image image = null;
        Image thumnail_img = null;

        public bookImage(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum;
        }
        public bool ThumbnailCallback()
        {
            return true;
        }
        //사진 추가
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\user\Pictures";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string image_file = string.Empty;
                image_file = dialog.FileName;
                txtPicture.Text = image_file;
                image = Bitmap.FromFile(image_file);
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);//썸네일 만들기
                thumnail_img =image.GetThumbnailImage(400,400, callback, new IntPtr()); //썸네일 만들기
                pictureBox1.Image = thumnail_img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else return;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                if (image == null)
                {
                    MessageBox.Show("이미지 == NULL");
                    return;

                }
                else
                {
                    cmd.CommandText = $"update 개설과목  set 교재 = :image_var WHERE 과목번호 = '{subNum}'";

                    byte[] bytes = imageToByteArray(image);
                    OleDbParameter para = new OleDbParameter();
                    para.OleDbType = OleDbType.LongVarBinary;
                    para.ParameterName = ":image_var";
                    para.Direction = ParameterDirection.Input;
                    para.SourceColumn = "product_image";
                    para.Size = bytes.Length;
                    para.Value = bytes;
                    cmd.Parameters.Add(para);
                }
                /*                                                                  
                        FileStream fs =new FileStream(txtPicture.Text, FileMode.Open, FileAccess.Read);
                        byte[] b = new byte[fs.Length - 1];
                        fs.Read(b, 0, b.Length);
                        fs.Close();
                        OleDbParameter para = new OleDbParameter();
                        para.ParameterName = ":image_var";
                        para.DbType = OleDbType.Binary;
                        para.Direction = ParameterDirection.Input;
                        para.SourceColumn = "product_image";
                        para.Size = b.Length;
                     para.Value = b;
                   cmd.Parameters.Add(para);
                */
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                cmd.Parameters.Clear();
                conn.Close();
                subNumBox2.Text = "";
                subNameBox2.Text = "";
                txtPicture.Text = ""; //추가
                pictureBox1.Image = null; //추가
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
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private byte[] imageToByteArray(Image img)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] b = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            ImageConverter imageConverter = new ImageConverter();
            Image img = (Image)imageConverter.ConvertFrom(bytes);
            return img;
        }

        

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            image frm = new image(image);
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String query = $"SELECT 개설과목.과목번호, 과목.과목이름, 개설과목.학기, 교수.이름 AS 담당교수이름 FROM 개설과목 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 개설과목.담당교수번호 = '{idNum}'";
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
                dataGridView1.ColumnCount = 5;

                //필드명 받아오는 반복문
                for (int i = 0; i < 4; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[4]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 4; i++) // 필드 수만큼 반복
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

        private void backButton_Click(object sender, EventArgs e)
        {
            mainProfessor f = new mainProfessor(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subNum = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            subName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            subNumBox2.Text = subNum.ToString();
            subNameBox2.Text = subName;
            Console.WriteLine(subNum);
            conn = new OleDbConnection(connectionString);

            pictureBox1.Image = null;
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = $"select 교재 from 개설과목 where 과목번호 = '{subNum}'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                if (read.Read())
                {
                    if (read.GetValue(0).ToString() != "")  //이미지가 없으면
                    {
                        image = ByteArrayToImage((byte[])read.GetValue(0));
                        Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr()); //썸네일 만들기
                        pictureBox1.Image = thumnail_img;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                       
                    }
                }

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
                }
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
