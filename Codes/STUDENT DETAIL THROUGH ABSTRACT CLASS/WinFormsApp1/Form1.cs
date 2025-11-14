namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENTADMINDETAILS sTUDENTADMINDETAILS = new STUDENTADMINDETAILS();
            textBox1.Text = sTUDENTADMINDETAILS.STUDENTADMIN();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENTHRDETAILS sTUDENTHRDETAILS = new STUDENTHRDETAILS();
            textBox2.Text = sTUDENTHRDETAILS.STUDENTHR();
        }
    }
}
