namespace AGE_VERIFICATION_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text);

            if ( age < 18 )
            {
                MessageBox.Show ("You Are Not Elegible");
            }
            else if (age >= 18)
            {
                MessageBox.Show("You Are Elegible");
            }

        }
    }
}
