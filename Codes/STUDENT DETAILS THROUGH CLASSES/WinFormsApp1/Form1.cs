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
            SIMPLECLASS sIMPLECLASS = new SIMPLECLASS();
            textBox1.Text = sIMPLECLASS.SIMPLECLASSDETAIL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OVERLOADINGCLASS oVERLOADINGCLASS = new OVERLOADINGCLASS();
            oVERLOADINGCLASS.ID = "101";
            oVERLOADINGCLASS.NAME = "Majid Khan";
            oVERLOADINGCLASS.EMAIL = "MajidKhan@gmail.com";
            oVERLOADINGCLASS.PHONE = "0000000000";

            string result = $"ID: {oVERLOADINGCLASS.ID}{Environment.NewLine}" +
                            $"NAME:{oVERLOADINGCLASS.NAME}{Environment.NewLine}" +
                            $"EMAIL: {oVERLOADINGCLASS.EMAIL}{Environment.NewLine}" +
                            $"Phone:{oVERLOADINGCLASS.PHONE}{Environment.NewLine}";

            textBox2.Text += result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ARRAYCLASS aRRAYCLASS = new ARRAYCLASS();
            textBox3.Text = aRRAYCLASS.Showinfo();
        }
    }
}
