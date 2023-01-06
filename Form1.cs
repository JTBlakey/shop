namespace shop
{
	public partial class Form1 : Form
	{
        int totalcost = 0;

        public Dictionary<string, int> sockArrayStock;
		public Form1()
		{
			InitializeComponent();

			sockArrayStock = LoadStock();
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

		private void button1_Click_1(object sender, EventArgs e) //stock prices
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

		public Dictionary<string, int> LoadStock()
		{
			StreamReader reader = new StreamReader("./Assets/stock.txt", System.Text.Encoding.UTF8);// open the file
			string[] stock = reader.ReadToEnd().Split("\r\n");//creates the array named stock 

			Dictionary<string, int> stockLevels = new Dictionary<string, int>();//creates a dictionary called stock levels containing item and stock of item

			for (int i = 0; i < stock.Length; i++)
			{
				string[] item = stock[i].Split(',');

				stockLevels.Add(item[0], Convert.ToInt32(item[1]));
			}

			reader.Close();

			return stockLevels;
		}

		public void EditStock(string item)//to change the stock
		{
            sockArrayStock[item] = sockArrayStock[item] - 1;//takes one away from the stock for that item
        }

  //      public void EditStock(string fileName, string word, string replacement, string saveFileName)
		//{
		//	StreamReader reader = new StreamReader("./Assets/" + fileName);
		//	string input = reader.ReadToEnd();
		//	reader.Close();

		//	using (StreamWriter writer = new StreamWriter("./Assets/" + fileName, true))
		//	{
		//		{
		//			TextWriter tw = new StreamWriter("TextFile.txt", false);
		//			tw.Write(string.Empty);
		//			string output = input.Replace(word, replacement);
		//			File.Delete("stock.txt");
		//			writer.Write(output);
		//		}
		//		writer.Close();
		//	}
		//}
		private void button12_Click(object sender, EventArgs e)
		{
            Button button = (Button)sender;//i dont really know what this does but i think it is needed
            groupBox1.Text = groupBox1.Text + "PENCIL CASE £0.60";// adds this text to the text in the box
			string item = ("pencilcase");
            EditStock(item);
            totalcost += 60;
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
            string item = ("pen Black");
			EditStock(item);
            totalcost += 10;
        }

		private void button8_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = groupBox1.Text + "PEN £0.10";
            string item = ("pen Blue");
            EditStock(item);
            totalcost += 10;
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
            string item = ("ruler 6in");
            EditStock(item);
            totalcost += 35;
        }

		private void button9_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = groupBox1.Text + "Ruler £0.40";
            string item = ("ruler 12in");
            EditStock(item);
            totalcost += 40;
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
            string item = ("highlighter Y");
            EditStock(item);
            totalcost += 45;
        }

		private void button10_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = groupBox1.Text + "HIGHLIGHTER G £0.45";
            string item = ("highlighter G");
            EditStock(item);
            totalcost += 45;
        }

		private void button11_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = groupBox1.Text + "HIGHLIGHTER R £0.45";
            string item = ("highlighter R");
            EditStock(item);
            totalcost += 45;
        }



		private void button13_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text += "PENCIL £0.05";
            string item = ("pencil");
            EditStock(item);
			totalcost += 5;
        }
		
		private void button16_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = groupBox1.Text + "PENCIL SHARPENER £0.15";
            string item = ("pencil sharpener");
            EditStock(item);
            totalcost += 15;
        }

		private void button17_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = groupBox1.Text + "RUBBER £0.10";
            string item = ("rubber");
            EditStock(item);
            totalcost += 10;
        }

		private void button15_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			groupBox1.Text = "What you have selected:";
		}

		private void button20_Click(object sender, EventArgs e) //current stock
		{
            groupBox1.Text = "";//clears box
            string allStock = "";//creates string for current stock
            foreach (KeyValuePair<string, int> itemAndStock in sockArrayStock)
                allStock += itemAndStock.Key + " - " + itemAndStock.Value.ToString() + "\r\n";//adds the stock array to the string that was set up
            groupBox1.Text = groupBox1.Text + allStock;//prints the current stock
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button19_Click(object sender, EventArgs e)//subtotal
		{
            groupBox1.Text = ((decimal)totalcost / 100).ToString("C2");
		}
	}
}