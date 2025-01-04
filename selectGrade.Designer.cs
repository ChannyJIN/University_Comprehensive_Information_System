namespace universityP
{
    partial class selectGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradeUpdateButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(330, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "과목별 수강 명부 조회";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(969, 693);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selectAllButton
            // 
            this.selectAllButton.BackColor = System.Drawing.Color.Green;
            this.selectAllButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectAllButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectAllButton.Location = new System.Drawing.Point(1033, 129);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(169, 74);
            this.selectAllButton.TabIndex = 11;
            this.selectAllButton.Text = "전체 조회";
            this.selectAllButton.UseVisualStyleBackColor = false;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.Green;
            this.subButton.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subButton.Location = new System.Drawing.Point(1302, 163);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(130, 40);
            this.subButton.TabIndex = 10;
            this.subButton.Text = "과목별 조회";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.subButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1342, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1287, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "과목";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("돋움", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numLabel.Location = new System.Drawing.Point(1099, 384);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(58, 23);
            this.numLabel.TabIndex = 12;
            this.numLabel.Text = "학번";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("돋움", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(1215, 384);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 23);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1099, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "성적";
            // 
            // gradeUpdateButton
            // 
            this.gradeUpdateButton.BackColor = System.Drawing.Color.Green;
            this.gradeUpdateButton.Font = new System.Drawing.Font("굴림", 14F);
            this.gradeUpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradeUpdateButton.Location = new System.Drawing.Point(1156, 579);
            this.gradeUpdateButton.Name = "gradeUpdateButton";
            this.gradeUpdateButton.Size = new System.Drawing.Size(154, 41);
            this.gradeUpdateButton.TabIndex = 16;
            this.gradeUpdateButton.Text = "성적 수정";
            this.gradeUpdateButton.UseVisualStyleBackColor = false;
            this.gradeUpdateButton.Click += new System.EventHandler(this.gradeUpdateButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(1189, 487);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Green;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(12, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 50);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "<-뒤로가기";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.UseWaitCursor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(1026, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 42);
            this.label3.TabIndex = 108;
            this.label3.Text = "성적 정정";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1015, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 15);
            this.label4.TabIndex = 107;
            this.label4.Text = "                                                                               ";
            // 
            // selectGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 783);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gradeUpdateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "selectGrade";
            this.Text = "gradeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gradeUpdateButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}