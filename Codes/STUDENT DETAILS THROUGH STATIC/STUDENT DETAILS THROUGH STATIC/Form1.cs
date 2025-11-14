namespace STUDENT_DETAILS_THROUGH_STATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            STATICCLASS sTATICCLASS = new STATICCLASS();
            sTATICCLASS.STUDENT(textBox1.Text);
            textBox2.Text += sTATICCLASS.SHOWINFO();
        }
    }
}
