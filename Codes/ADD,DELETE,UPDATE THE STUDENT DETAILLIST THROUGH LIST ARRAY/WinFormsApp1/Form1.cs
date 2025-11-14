namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> STDNAMES = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            string ADD = textBox2.Text;

            if (!string.IsNullOrWhiteSpace(ADD))
            {
                STDNAMES.Add(ADD);

                textBox1.Clear();
                foreach (string name in STDNAMES)
                {
                    textBox1.Text += name + Environment.NewLine;
                }

                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Remove = textBox3.Text.Trim();

            if (STDNAMES.Contains(Remove))
            {
                STDNAMES.Remove(Remove);

                textBox1.Clear();
                foreach (string name in STDNAMES)
                {
                    textBox1.Text += name + Environment.NewLine;
                }

                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Name not found in the list!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string oldName = textBox4.Text.Trim();
            string newName = textBox5.Text.Trim();

            int index = STDNAMES.IndexOf(oldName);

            if (index != -1)
            {
                STDNAMES[index] = newName;


                textBox1.Clear();
                foreach (string name in STDNAMES)
                {
                    textBox1.Text += name + Environment.NewLine;
                }

                textBox4.Clear();
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("Old name not found in the list!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox6.Text.Trim().ToLower();

            // Clear textbox7 before showing new results
            textBox7.Clear();

            // Find all names that contain the search term (case-insensitive)
            var matchedNames = STDNAMES.Where(name => name.ToLower().Contains(searchTerm)).ToList();

            if (matchedNames.Count > 0)
            {
                foreach (string name in matchedNames)
                {
                    textBox7.Text += name + Environment.NewLine;
                }
            }
            else
            {
                textBox7.Text = "No match found.";
            }
        }
    }
}

