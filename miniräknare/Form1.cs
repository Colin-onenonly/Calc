namespace miniräknare
{
    public partial class Form1 : Form
    {
        //variabler
        double tal1 = 0;
        string rakna = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //plus
            tal1 = Convert.ToDouble(textBox1.Text);
            rakna = "+";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //minus
            tal1 = Convert.ToDouble(textBox1.Text);
            rakna = "-";
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //gånger
            tal1 = Convert.ToDouble(textBox1.Text);
            rakna = "*";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //delat
            tal1 = Convert.ToDouble(textBox1.Text);
            rakna = "/";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //lika me
            if (rakna == "+")
                textBox1.Text = (tal1 + Convert.ToDouble(textBox1.Text)).ToString();

            if (rakna == "-")
            {
                textBox1.Text = (tal1 - Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (rakna == "*")
            {
                textBox1.Text = (tal1 * Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (rakna == "/")
            {
                textBox1.Text = (tal1 / Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (rakna == "%")
            {
                textBox1.Text = ((tal1 / 100) * Convert.ToDouble(textBox1.Text)).ToString();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //clear
            tal1 = 0;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //komma
            textBox1.Text = textBox1.Text + ",";
        }
        double minne = 0;
        private void button18_Click(object sender, EventArgs e)
        {
            //ms
            minne = Convert.ToDouble(textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //mr
            if (minne != 0)
            { textBox1.Text = minne.ToString(); }
            else
            { textBox1.Text = ""; }
        }



        private void button20_Click(object sender, EventArgs e)
        {
            //mc
            minne = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Pi
            textBox1.Text = "3,1415926535897932384626433832795";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // gånger sig själv
            tal1 = Convert.ToDouble(textBox1.Text);
            tal1 = tal1 * tal1;
            textBox1.Text = tal1.ToString();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Rooten
            tal1 = Convert.ToDouble(textBox1.Text);
            tal1 = Math.Sqrt(tal1);
            textBox1.Text = tal1.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
//binär
            int bin = Convert.ToInt32(textBox1.Text);
            string binar = Convert.ToString(bin, 2);
            textBox1.Text = binar;


        }

        private void button26_Click(object sender, EventArgs e)
        {
            //decimalt
            textBox1.Text = (Convert.ToInt32(textBox1.Text, 2)).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox
            textBox1.ReadOnly = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //procent
            double summa = tal1 / 100 * Convert.ToDouble(textBox1.Text);
            if (rakna == "+")
            {
                textBox1.Text = (tal1 + summa).ToString();
            }
            if (rakna == "-")
            {
                textBox1.Text = (tal1 - summa).ToString();
            }

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            //sin
            tal1 = Convert.ToDouble(textBox1.Text);
            tal1 = Math.Sin(tal1);
            tal1 = tal1 * (180 / Math.PI);
            textBox1.Text = tal1.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //cos
            tal1 = Convert.ToDouble(textBox1.Text);
            tal1 = Math.Cos(tal1);
            textBox1.Text = tal1.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //tan
            tal1 = Convert.ToDouble(textBox1.Text);
            tal1 = Math.Tan(tal1);
            textBox1.Text = tal1.ToString();
        }
    }
}
