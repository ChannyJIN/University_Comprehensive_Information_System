namespace 이미지처리
{
    partial class bookImage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.label125 = new System.Windows.Forms.Label();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.subNameBox2 = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.subNumBox2 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Green;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(126, 369);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 51);
            this.btnOK.TabIndex = 100;
            this.btnOK.Text = "등록 및 정정";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(614, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 42);
            this.label2.TabIndex = 104;
            this.label2.Text = "교재 사진추가";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(611, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 15);
            this.label1.TabIndex = 102;
            this.label1.Text = "                                                                               ";
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.label3);
            this.panel18.Controls.Add(this.pictureBox1);
            this.panel18.Controls.Add(this.btnOK);
            this.panel18.Controls.Add(this.btnAddPicture);
            this.panel18.Controls.Add(this.label125);
            this.panel18.Controls.Add(this.txtPicture);
            this.panel18.Controls.Add(this.subNameBox2);
            this.panel18.Controls.Add(this.label122);
            this.panel18.Controls.Add(this.label119);
            this.panel18.Controls.Add(this.subNumBox2);
            this.panel18.Location = new System.Drawing.Point(613, 165);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(444, 466);
            this.panel18.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 105;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(126, 221);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.Color.Green;
            this.btnAddPicture.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddPicture.ForeColor = System.Drawing.Color.White;
            this.btnAddPicture.Location = new System.Drawing.Point(341, 173);
            this.btnAddPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(95, 31);
            this.btnAddPicture.TabIndex = 6;
            this.btnAddPicture.Text = "첨부";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(19, 179);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(74, 15);
            this.label125.TabIndex = 12;
            this.label125.Text = "*교재사진";
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(110, 175);
            this.txtPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(223, 25);
            this.txtPicture.TabIndex = 5;
            // 
            // subNameBox2
            // 
            this.subNameBox2.Location = new System.Drawing.Point(112, 111);
            this.subNameBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subNameBox2.Name = "subNameBox2";
            this.subNameBox2.Size = new System.Drawing.Size(129, 25);
            this.subNameBox2.TabIndex = 1;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(21, 114);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(59, 15);
            this.label122.TabIndex = 3;
            this.label122.Text = "*과목명";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(19, 49);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(74, 15);
            this.label119.TabIndex = 2;
            this.label119.Text = "*과목번호";
            // 
            // subNumBox2
            // 
            this.subNumBox2.Location = new System.Drawing.Point(112, 49);
            this.subNumBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subNumBox2.Name = "subNumBox2";
            this.subNumBox2.Size = new System.Drawing.Size(129, 25);
            this.subNumBox2.TabIndex = 0;
            this.subNumBox2.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Green;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(12, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 50);
            this.backButton.TabIndex = 111;
            this.backButton.Text = "<-뒤로가기";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.UseWaitCursor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("굴림", 11F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(300, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 42);
            this.button2.TabIndex = 110;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(158, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 109;
            this.label5.Text = "담당 과목";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(494, 537);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 709);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel18);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bookImage";
            this.Text = "이미지등록 및 검색";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.TextBox subNameBox2;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.TextBox subNumBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

