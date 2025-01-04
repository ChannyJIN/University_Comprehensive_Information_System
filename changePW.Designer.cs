namespace universityP
{
    partial class changePW
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
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.pwCheckTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwChangeTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(395, 154);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(150, 25);
            this.pwTextBox.TabIndex = 0;
            // 
            // pwCheckTextBox
            // 
            this.pwCheckTextBox.Location = new System.Drawing.Point(395, 201);
            this.pwCheckTextBox.Name = "pwCheckTextBox";
            this.pwCheckTextBox.Size = new System.Drawing.Size(150, 25);
            this.pwCheckTextBox.TabIndex = 1;
            this.pwCheckTextBox.TextChanged += new System.EventHandler(this.pwCheckTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(243, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(219, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호 확인";
            // 
            // pwChangeTextBox
            // 
            this.pwChangeTextBox.Location = new System.Drawing.Point(288, 266);
            this.pwChangeTextBox.Name = "pwChangeTextBox";
            this.pwChangeTextBox.Size = new System.Drawing.Size(174, 49);
            this.pwChangeTextBox.TabIndex = 4;
            this.pwChangeTextBox.Text = "비밀번호 변경";
            this.pwChangeTextBox.UseVisualStyleBackColor = true;
            this.pwChangeTextBox.Click += new System.EventHandler(this.pwChangeTextBox_Click);
            // 
            // changePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 452);
            this.Controls.Add(this.pwChangeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwCheckTextBox);
            this.Controls.Add(this.pwTextBox);
            this.Name = "changePW";
            this.Text = "changePW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.TextBox pwCheckTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pwChangeTextBox;
    }
}