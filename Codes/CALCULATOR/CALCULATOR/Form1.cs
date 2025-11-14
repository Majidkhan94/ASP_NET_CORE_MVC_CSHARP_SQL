namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            char[] operators = { '+', '-', '*', '/' };
            int opIndex = expression.IndexOfAny(operators);

            if (opIndex > 0)
            {
                double num1 = Convert.ToDouble(expression.Substring(0, opIndex));
                double num2 = Convert.ToDouble(expression.Substring(opIndex + 1));
                char op = expression[opIndex];
                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        break;
                    default:
                        textBox1.Text = "Invalid";
                        return;
                }

                textBox1.Text = result.ToString();
            }
        }
    }
}
