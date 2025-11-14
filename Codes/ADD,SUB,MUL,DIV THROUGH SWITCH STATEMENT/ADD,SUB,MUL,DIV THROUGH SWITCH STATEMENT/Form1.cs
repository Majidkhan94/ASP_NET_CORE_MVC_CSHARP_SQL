namespace ADD_SUB_MUL_DIV_THROUGH_SWITCH_STATEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(textBox1.Text);
            int Num2 = Convert.ToInt32(textBox2.Text);
            string sign = textBox7.Text;
            int result = 0;
            switch (sign)
            {
                case "+":
                result = Num1 + Num2;
                textBox3.Text = result.ToString();
                break;

                case "-":
                    result = Num1 - Num2;
                    textBox4.Text = result.ToString();
                    break;

                case "*":
                    result = Num1 * Num2;
                    textBox6.Text = result.ToString();
                    break;

                case "/":
                    result = Num1 / Num2;
                    textBox5.Text = result.ToString();
                    break;

            }

        }
    }
}
