namespace universityP
{
    partial class consultSelectStudent
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
            this.label4 = new System.Windows.Forms.Label();
            this.consultingDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.consultingBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(166, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "상담 일자";
            // 
            // consultingDate
            // 
            this.consultingDate.Location = new System.Drawing.Point(169, 575);
            this.consultingDate.Name = "consultingDate";
            this.consultingDate.Size = new System.Drawing.Size(209, 25);
            this.consultingDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(306, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "상담 내용";
            // 
            // consultingBox
            // 
            this.consultingBox.BackColor = System.Drawing.Color.White;
            this.consultingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consultingBox.Location = new System.Drawing.Point(169, 171);
            this.consultingBox.Multiline = true;
            this.consultingBox.Name = "consultingBox";
            this.consultingBox.Size = new System.Drawing.Size(362, 350);
            this.consultingBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(279, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 53);
            this.label1.TabIndex = 108;
            this.label1.Text = "상담내역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(121, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "                                                                               ";
            // 
            // selectAllButton
            // 
            this.selectAllButton.BackColor = System.Drawing.Color.Green;
            this.selectAllButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectAllButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectAllButton.Location = new System.Drawing.Point(564, 282);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(169, 74);
            this.selectAllButton.TabIndex = 109;
            this.selectAllButton.Text = "조회";
            this.selectAllButton.UseVisualStyleBackColor = false;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Green;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(25, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 50);
            this.backButton.TabIndex = 110;
            this.backButton.Text = "<-뒤로가기";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.UseWaitCursor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(411, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 112;
            this.label5.Text = "지도교수";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 575);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 25);
            this.textBox1.TabIndex = 111;
            // 
            // consultSelectStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 651);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.consultingDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.consultingBox);
            this.Name = "consultSelectStudent";
            this.Text = "consultSelectStudent";
            this.Load += new System.EventHandler(this.consultSelectStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox consultingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox consultingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}