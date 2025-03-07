using System.Globalization;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string opcja;
        double wynik;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            opcja = "+";
            num1 = double.Parse(textBox.Text);

            textBox.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            opcja = "-";
            num1 = double.Parse(textBox.Text);

            textBox.Clear();
        }

        private void btnUkosnik_Click(object sender, EventArgs e)
        {
            opcja = "/";
            num1 = double.Parse(textBox.Text);

            textBox.Clear();
        }

        private void btnGwiazka_Click(object sender, EventArgs e)
        {
            opcja = "*";
            num1 = double.Parse(textBox.Text);

            textBox.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox.Clear();

            wynik = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnRownaSie_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox.Text);

            if (opcja.Equals("+"))
                wynik = num1 + num2;

            if (opcja.Equals("-"))
                wynik = num1 - num2;

            if (opcja.Equals("*"))
                wynik = num1 * num2;

            if (opcja.Equals("/"))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("b³¹d");
                    return;
                }
                wynik = num1 / num2;
            }

            textBox.Text = wynik.ToString(CultureInfo.CurrentCulture);

        }

        private void btnPrzecinek_Click(object sender, EventArgs e)
        {
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!textBox.Text.Contains(separator))
            {
                textBox.Text += separator;
            }
        }
    }
}
