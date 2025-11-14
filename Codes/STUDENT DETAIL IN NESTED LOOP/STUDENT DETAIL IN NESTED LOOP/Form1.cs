using System.Security.Cryptography.X509Certificates;

namespace STUDENT_DETAIL_IN_NESTED_LOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            

        private void button1_Click(object sender, EventArgs e)
        {
            string[] customers = new string[3];

            customers[0] = "ID: 101  Name: Customer1  Phone: 11111111111";
            customers[1] = "ID: 102  Name: Customer2  Phone: 22222222222";
            customers[2] = "ID: 103  Name: Customer3  Phone: 33333333333";
            
            for (int i = 0; i < customers.Length; i++)
            {
                for (int j = 0; j < customers[i].Length; j++)
                {

                    textBox1.Text += customers[i][j];
                }

                textBox1.Text += Environment.NewLine;
            }

        }
    }
}
