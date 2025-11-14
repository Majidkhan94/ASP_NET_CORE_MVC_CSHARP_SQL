namespace ARRAY_FOR_WHILE_DOWHILE_FOREACH_LOOP
{

    public partial class Form1 : Form
    {
        string[] customer = new string[] { "Customer-1", "Customer-2", "Customer-3", "Customer-4", "Customer-5" };
        string result;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = customer[0] + Environment.NewLine +
                     customer[1] + Environment.NewLine +
                     customer[2] + Environment.NewLine +
                     customer[3] + Environment.NewLine +
                     customer[4];

            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < customer.Length; i++)
            {
                textBox2.Text += customer[i].ToString() + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < customer.Length)
            {
                textBox3.Text += customer[i].ToString() + Environment.NewLine;
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                textBox4.Text += customer[i].ToString() + Environment.NewLine;
                i++;
            }
            while (i < customer.Length);
        }

        private void button5_Click(object sender, EventArgs e)
        {
         

            foreach (var cust in customer)
            {
                textBox5.Text += cust + Environment.NewLine;
            }
        }
    }
}
