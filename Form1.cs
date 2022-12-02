namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadStock();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click2(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Text = "";
            string text = "";//to clear the box

            // open the text file using a stream reader.
            using (var sr = new StreamReader("./Assets/item prices.txt", System.Text.Encoding.UTF8))
            {
                text = sr.ReadToEnd();
            }
        // write the string to the box.
            groupBox1.Text = groupBox1.Text + text;
        }

        private void loadStock()
        {
            StreamReader reader = new StreamReader("./Assets/stock.txt", System.Text.Encoding.UTF8);
            string[] stock = reader.ReadToEnd().Split("\r\n");
            reader.Close();
        }   

/*        public void EditStock(string fileName, string word, string replacement, string saveFileName)
        {
            StreamReader reader = new StreamReader("./Assets/" + fileName);
            string input = reader.ReadToEnd();
            reader.Close();

            using (StreamWriter writer = new StreamWriter("./Assets/" + fileName, true))
            {
                {
                    TextWriter tw = new StreamWriter("TextFile.txt", false);
                    tw.Write(string.Empty);
                    string output = input.Replace(word, replacement);
                    File.Delete("stock.txt");
                    writer.Write(output);
                }
                writer.Close();
            }
        }*/
        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "PENCIL CASE £0.60";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "Please select a colour";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "PEN £0.10";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "PEN £0.10";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "Please select a length";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "Ruler £0.35";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "Ruler £0.40";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "Please select a colour";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "HIGHLIGHTER Y £0.45";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "HIGHLIGHTER G £0.45";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "HIGHLIGHTER R £0.45";
        }



        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "PENCIL £0.05";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "PENCIL SHARPENER £0.15";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "RUBBER £0.10";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = "What you have selected:";
        }
    }
}