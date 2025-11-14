namespace AGE_VERIFICATION_PROJECT
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
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 45);
            label1.TabIndex = 0;
            label1.Text = "AGE VERIFICATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 64);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 1;
            label2.Text = "IF YOU ARE UNDER 18 YOU ARE NOT ELIGIBLE";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(363, 175);
            button1.Name = "button1";
            button1.Size = new Size(292, 32);
            button1.TabIndex = 2;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(367, 113);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 30);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 123);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 4;
            label3.Text = "ENTER YOUR AGE:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 502);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
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
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}
