namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            groupBox1.Text = groupBox1.Text + "PENCIL CASE £0.60";
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