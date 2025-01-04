namespace universityP
{
    partial class joinPro
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
            this.testButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idNumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(459, 122);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(97, 23);
            this.testButton.TabIndex = 22;
            this.testButton.Text = "중복 조회";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(297, 340);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(104, 35);
            this.joinButton.TabIndex = 21;
            this.joinButton.Text = "회원가입";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(224, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "학과";
            // 
            // majorTextBox
            // 
            this.majorTextBox.Location = new System.Drawing.Point(297, 228);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(147, 25);
            this.majorTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(187, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "최초 등록시 비밀번호는 0000입니다.";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(297, 178);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 25);
            this.nameTextBox.TabIndex = 15;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.nameLabel.Location = new System.Drawing.Point(224, 181);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(224, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "교번";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idNumTextBox
            // 
            this.idNumTextBox.Location = new System.Drawing.Point(297, 123);
            this.idNumTextBox.Name = "idNumTextBox";
            this.idNumTextBox.Size = new System.Drawing.Size(147, 25);
            this.idNumTextBox.TabIndex = 12;
            // 
            // joinPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 453);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idNumTextBox);
            this.Name = "joinPro";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.joinPro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idNumTextBox;
    }
}