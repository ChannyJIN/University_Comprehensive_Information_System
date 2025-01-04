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
using System.Xml.Linq;

namespace universityP
{
    public partial class sugangStudent : Form
    {
        String idNum = "";
        String addQ = "";
        String subName = "";
        String subNum = "";
        int cnt = 0;
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=0317;User ID=jin"; //oracle 서버 연결
        public sugangStudent(String idNum)
        {
            InitializeComponent();
            this.idNum = idNum; 
        }

        private void sugangStudent_Load(object sender, EventArgs e)
        {

        }
        //전체조회버튼
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            checkClear();
            dataGridView1.Rows.Clear();
            String query = $"SELECT 과목.학과이름, 과목.과목이름, 개설과목.과목번호, 개설과목.연도 ,과목.대상학년,개설과목.학기,과목.이수학점, 교수.이름 AS 담당교수 FROM 과목 JOIN 개설과목 ON 과목.과목번호 = 개설과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호";
            updatedb(query);
        }
        //학과별 조회버튼
        private void subButton_Click(object sender, EventArgs e)
        {
            checkClear();
            dataGridView1.Columns.RemoveAt(6);
            dataGridView1.Rows.Clear();
            String query = $"SELECT 과목.학과이름, 과목.과목이름, 개설과목.과목번호, 개설과목.연도 ,과목.대상학년,개설과목.학기, 과목.이수학점, 교수.이름 AS 담당교수 FROM 과목 JOIN 개설과목 ON 과목.과목번호 = 개설과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 where 과목.학과이름 = '{textBox1.Text}'";
            updatedb(query);
        }
        //학년별 조회 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            //checkClear();
            
            dataGridView1.Rows.Clear();
            if(textBox1.Text.Length > 0)
            {
                addQ = $"and 과목.학과이름 = '{textBox1.Text}'";
            }
            String query = $"SELECT 과목.학과이름, 과목.과목이름, 개설과목.과목번호, 개설과목.연도,과목.대상학년, 개설과목.학기, 과목.이수학점, 교수.이름 AS 담당교수 FROM 과목 JOIN 개설과목 ON 과목.과목번호 = 개설과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 where 과목.대상학년 = '{textBox2.Text}' {addQ}";
            updatedb(query);
        }
        //신청한 과목
        private void button5_Click(object sender, EventArgs e)
        {
            checkClear();
            dataGridView1.Rows.Clear();
            String query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년 , 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 학생.학번 = '{idNum}'";
            updatedb3(query);
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
                dataGridView1.ColumnCount = 9;

                //필드명 받아오는 반복문
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[8]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 8; i++) // 필드 수만큼 반복
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
        private void updatedb3(String query)
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
                dataGridView1.ColumnCount = 9;

                //필드명 받아오는 반복문
                for (int i = 0; i < 9; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[9]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 9; i++) // 필드 수만큼 반복
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
            mainStudent f = new mainStudent(idNum);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query2 = $"select 학년 from 학생 where 학번='{idNum}'";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query2;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OleDbDataReader read = cmd.ExecuteReader();
            if (!read.Read())
            {
                MessageBox.Show("대상학년 없음");
                if (conn != null)
                {
                    conn.Close();
                }
                return;
            }

            String gradeStudent = read.GetString(0);
            conn.Close();

            dataGridView1.Rows.Clear();
            String query = $"SELECT 과목.학과이름, 과목.과목이름, 개설과목.과목번호, 개설과목.연도,개설과목.학기,과목.이수학점,과목.대상학년,교수.이름 AS 담당교수 FROM 과목 JOIN 개설과목 ON 과목.과목번호 = 개설과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 과목.과목번호 IN (SELECT 과목.과목번호 FROM 과목 JOIN 학생 ON 과목.학과이름 = 학생.학과이름 WHERE 학생.학번 = '{idNum}' and 과목.대상학년 = '{gradeStudent}')";
            updatedb2(query);
        }
        
        
        private void updatedb2(String query)
        {
            dataGridView1.Rows.Clear();
            
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open(); // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = query; // member 테이블
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // 결과
                dataGridView1.ColumnCount = 8; // 총 6개의 열

                // 필드명 받아오는 반복문
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                // 체크박스 열 추가
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "선택";
                dataGridView1.Columns.Add(checkBoxColumn);

                // 행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[9]; // 필드수 + 1(체크박스)만큼 오브젝트 배열

                    for (int i = 0; i < 8; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트 배열에 데이터 저장
                    }

                    // 마지막 열의 데이터를 추가
                    obj[8] = false; // 초기값은 체크 안 된 상태

                    dataGridView1.Rows.Add(obj); // 데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // 에러 메세지 
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetCheckedRowsValues();
        }
        private void checkClear()
        {
            int checkBoxColumnIndex = -1;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column is DataGridViewCheckBoxColumn)
                {
                    checkBoxColumnIndex = column.Index;
                    break;
                }
            }

            // 체크박스 열이 있다면 제거
            if (checkBoxColumnIndex != -1)
            {
                dataGridView1.Columns.RemoveAt(checkBoxColumnIndex);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text= subName;
            subNum = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            

        }
        private void GetCheckedRowsValues()
        {
            List<string[]> checkedRowsValues = new List<string[]>();
            int cnt = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // 체크박스 열의 셀을 가져오기
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["선택"] as DataGridViewCheckBoxCell;

                // 체크된 행인지 확인
                if (Convert.ToBoolean(checkBoxCell?.Value))
                {
                    // 체크된 행의 2, 3, 4번째 열 값 가져오기
                    string[] values = new string[4];
                    
                    values[0] = row.Cells[2].Value.ToString(); // 2번째 열
                    values[1] = row.Cells[3].Value.ToString(); // 3번째 열
                    values[2] = row.Cells[4].Value.ToString(); // 4번째 열
                    values[3] = row.Cells[1].Value.ToString();
                    
                    checkedRowsValues.Add(values);
                }
            }

            // 가져온 값들을 사용하거나 출력
            foreach (var values in checkedRowsValues)
            {
                Console.WriteLine($"학번 : {idNum}, 과목번호: {values[0]}, 연도: {values[1]}, 학기: {values[2]} 신청한 총학점:{cnt}");
                //MessageBox.Show($"학번 : {idNum}, 과목이름: {values[3]}, 연도: {values[1]}, 학기: {values[2]} 신청한 총학점:{cnt}");

                String query = $"insert into 수강 values('{idNum}','{values[0]}', '{values[1]}', {values[2]},'B',null)";                 //성적은 디폴트 B  , 승인은 NULL값

                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();
                    cnt += 3;
                    MessageBox.Show($"수강신청 완료 !! 학번 : {idNum}, 과목이름: {values[3]}, 연도: {values[1]}, 학기: {values[2]} 신청한 총학점:{cnt}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("이미 수강중입니다. Error: " + ex.Message); //에러 메세지 
                    
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

        private void button6_Click(object sender, EventArgs e)
        {
            String query = $"delete from 수강 where 학번 ='{idNum}' and 과목번호 = '{subNum}'";

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("신청이 취소됐습니다.");
                dataGridView1.Rows.Clear();
                query = $"SELECT 학생.학번, 학생.이름, 수강.성적, 과목.대상학년 , 개설과목.과목번호, 과목.과목이름, 개설과목.담당교수번호 ,교수.이름 AS 담당교수이름 ,수강.승인 AS 승인여부 FROM 학생 JOIN 수강 ON 학생.학번 = 수강.학번 JOIN 개설과목 ON 수강.과목번호 = 개설과목.과목번호 JOIN 과목 ON 개설과목.과목번호 = 과목.과목번호 JOIN 교수 ON 개설과목.담당교수번호 = 교수.교수번호 WHERE 학생.학번 = '{idNum}'";
                updatedb(query);
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
