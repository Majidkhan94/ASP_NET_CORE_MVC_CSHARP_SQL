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
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(416, 39);
            label1.TabIndex = 0;
            label1.Text = "STUDENT DETAILS THROUGH CLASSES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 75);
            label2.Name = "label2";
            label2.Size = new Size(92, 39);
            label2.TabIndex = 1;
            label2.Text = "SIMPLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 75);
            label3.Name = "label3";
            label3.Size = new Size(161, 39);
            label3.TabIndex = 2;
            label3.Text = "OVERLOADING";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 129);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 203);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 338);
            button1.Name = "button1";
            button1.Size = new Size(265, 46);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(283, 338);
            button2.Name = "button2";
            button2.Size = new Size(261, 46);
            button2.TabIndex = 6;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 129);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 203);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(550, 338);
            button3.Name = "button3";
            button3.Size = new Size(456, 46);
            button3.TabIndex = 9;
            button3.Text = "SUBMIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(550, 129);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(456, 203);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(769, 75);
            label4.Name = "label4";
            label4.Size = new Size(89, 39);
            label4.TabIndex = 7;
            label4.Text = "ARRAY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 493);
            Controls.Add(button3);
            Controls.Add(textBox3);
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
        private Button button3;
        private TextBox textBox3;
        private Label label4;
    }
}
