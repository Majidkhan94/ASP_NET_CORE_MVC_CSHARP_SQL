namespace TABLE_WITH_FOR_LOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int tablenum = Convert.ToInt32(textBox1.Text);

            for (var i = 1; i <= 10; i++)
            {
                textBox2.Text += tablenum + "x" + i.ToString() + "=" + (tablenum * i) + Environment.NewLine;



            }
        }


        public void showtable()
        {

            
            int tablenum2 = Convert.ToInt32(textBox4.Text);
            
            for (var j = 1; j <= 10; j++)
            {
                textBox3.Text += tablenum2 + "x" + j.ToString() + "=" + (tablenum2 * j) + Environment.NewLine;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            showtable();
            

        }
    }
}