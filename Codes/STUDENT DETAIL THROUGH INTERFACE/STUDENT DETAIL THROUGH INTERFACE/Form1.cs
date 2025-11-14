namespace STUDENT_DETAIL_THROUGH_INTERFACE
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
            STUDENTADMINDETAILS sTUDENTADMINDETAILS = new STUDENTADMINDETAILS();
            textBox1.Text = sTUDENTADMINDETAILS.ADMIN();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENTHRDETAILS sTUDENTHRDETAILS = new STUDENTHRDETAILS();
            textBox2.Text = sTUDENTHRDETAILS.HRDEPARTMENT();
        }
    }
}
