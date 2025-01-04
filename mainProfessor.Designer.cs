namespace universityP
{
    partial class mainProfessor
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
            this.imageInput = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.selectMyStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageInput
            // 
            this.imageInput.Location = new System.Drawing.Point(38, 218);
            this.imageInput.Name = "imageInput";
            this.imageInput.Size = new System.Drawing.Size(181, 105);
            this.imageInput.TabIndex = 0;
            this.imageInput.Text = "교재 사진 등록";
            this.imageInput.UseVisualStyleBackColor = true;
            this.imageInput.Click += new System.EventHandler(this.imageInput_Click);
            // 
            // gradeButton
            // 
            this.gradeButton.Location = new System.Drawing.Point(263, 218);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(181, 105);
            this.gradeButton.TabIndex = 2;
            this.gradeButton.Text = "수강 명부 조회 및 성적관리";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // selectMyStudent
            // 
            this.selectMyStudent.Location = new System.Drawing.Point(497, 218);
            this.selectMyStudent.Name = "selectMyStudent";
            this.selectMyStudent.Size = new System.Drawing.Size(181, 105);
            this.selectMyStudent.TabIndex = 3;
            this.selectMyStudent.Text = "지도학생 조회 및 상담 입력";
            this.selectMyStudent.UseVisualStyleBackColor = true;
            this.selectMyStudent.Click += new System.EventHandler(this.selectMyStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(242, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 116;
            this.label1.Text = "종합정보시스템";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(120, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "                                                                               ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 117;
            this.button1.Text = "비밀번호 변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectMyStudent);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.imageInput);
            this.Name = "mainProfessor";
            this.Text = "mainProfesor";
            this.Load += new System.EventHandler(this.mainProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imageInput;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Button selectMyStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}