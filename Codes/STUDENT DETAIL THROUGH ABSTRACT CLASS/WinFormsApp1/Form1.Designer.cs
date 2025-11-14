namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 39);
            label1.TabIndex = 0;
            label1.Text = "STUDENT DETAIL THROUGH ABSTRACT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(633, 145);
            label2.Name = "label2";
            label2.Size = new Size(193, 39);
            label2.TabIndex = 1;
            label2.Text = "HR DEPARTMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 145);
            label3.Name = "label3";
            label3.Size = new Size(230, 39);
            label3.TabIndex = 2;
            label3.Text = "ADMIN DEPARTMENT";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 198);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 204);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 408);
            button1.Name = "button1";
            button1.Size = new Size(222, 39);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(633, 408);
            button2.Name = "button2";
            button2.Size = new Size(222, 39);
            button2.TabIndex = 6;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(633, 198);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 204);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 210);
            label4.Name = "label4";
            label4.Size = new Size(161, 120);
            label4.TabIndex = 7;
            label4.Text = "ID = \"100\";\r\nName = \"Majid\";\r\nEmail = \"Majid@gmail.com\";\r\nPhone = \"000000000\";\r\nDepartment = \"ICIT\";\r\nSemester = \"4th\";\r\nResume = \"Resume\";\r\nPerformance = \"Good\";\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(366, 145);
            label5.Name = "label5";
            label5.Size = new Size(140, 31);
            label5.TabIndex = 8;
            label5.Text = "STUDENT DETAIL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 518);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
    }
}
