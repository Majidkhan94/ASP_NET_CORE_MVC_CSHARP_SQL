namespace TABLE_WITH_FOR_LOOP
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 39);
            label1.TabIndex = 1;
            label1.Text = "TABLE WITH FOR-LOOP AND METHOD";
            // 
            // button1
            // 
            button1.Location = new Point(127, 431);
            button1.Name = "button1";
            button1.Size = new Size(174, 23);
            button1.TabIndex = 2;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 136);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "TABLE NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 196);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "SHOW TABLE:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 193);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 216);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(155, 82);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 6;
            label4.Text = "FOR LOOP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(757, 72);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 12;
            label5.Text = "METHOD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(643, 186);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "SHOW TABLE:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(729, 183);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 216);
            textBox3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(660, 126);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 9;
            label7.Text = "TABLE NO:";
            // 
            // button2
            // 
            button2.Location = new Point(729, 421);
            button2.Name = "button2";
            button2.Size = new Size(174, 23);
            button2.TabIndex = 8;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(729, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 496);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Button button2;
        private TextBox textBox4;
    }
}
