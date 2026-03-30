using calc.Models;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calc
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Angle? Angle;
        private Stack<string> _operators = new Stack<string>();
        decimal integ;
        double a;
        int degrees, minutes, secunds;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                double.TryParse(textBox1.Text, out a);
                Angle = Angle.FromDecimal((decimal)a);
                textBox2.Text = Angle.ToString();
            }
            if (comboBox2.SelectedIndex == 0)
            {
                integ = decimal.Parse(textBox1.Text);
                textBox2.Text = " " + integ;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var operatorsRegex = new Regex("^\\+|-|\\*|\\/$");
            if (_operators.Count > 0)
            {
                var record = _operators.Pop();
                if (operatorsRegex.IsMatch(record))
                {
                    switch (record)
                    {
                        case "+":
                            Angle = Angle.FromString(_operators.Pop()) + Angle;
                            break;
                        case "-":
                            Angle = Angle.FromString(_operators.Pop()) - Angle;
                            label5.Text += "-";
                            break;
                        case "*":
                            integ = decimal.Parse(textBox1.Text);
                            Angle = Angle.FromString(_operators.Pop()) * integ;
                            label5.Text += "*";
                            break;
                        case "/":
                            integ = decimal.Parse(textBox1.Text);
                            Angle = Angle.FromString(_operators.Pop()) / integ;
                            label5.Text += "/";
                            break;
                        default:
                            break;
                    }
                    textBox3.Text = ("Результат равен: " + Angle.ToString());
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                degrees = int.Parse(textBox1.Text);
                textBox2.Text = (" " + degrees + "° ");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                minutes = int.Parse(textBox1.Text);
                if (minutes < 0 || minutes > 59)
                {
                    MessageBox.Show("Минуты должны входить в диапозон от 0 до 60", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minutes = 0;
                    textBox2.Text = (" " + degrees + "° ");
                }
                else { textBox2.Text = (" " + degrees + "° " + minutes + "' "); }
            }
            if (comboBox2.SelectedIndex == 3)
            {
                secunds = int.Parse(textBox1.Text);
                if (secunds < 0 || secunds > 59)
                {
                    MessageBox.Show("Секунды должны входить в диапозон от 0 до 60", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secunds = 0;
                    textBox2.Text = (" " + degrees + "° " + minutes + "' ");
                }
                else { textBox2.Text = (" " + degrees + "° " + minutes + "' " + secunds + "'' "); }
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                var c = Math.Cos(Angle!.Radians);
                c = Math.Round(c, 5);
                textBox3.Text = ("косинус равен: " + c);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                var c = Math.Tan(Angle!.Radians);
                c = Math.Round(c, 5);
                textBox3.Text = ("тангенс равен: " + c);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                label5.Text += Angle.ToString();
                label5.Text += "+";
                _operators.Push(Angle.ToString());
                _operators.Push("+");
                textBox1.Text = string.Empty;
            }
            else { MessageBox.Show("Вы не ввели угол!!!!!!!!!!!!!!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                var c = Math.Sin(Angle!.Radians);
                c = Math.Round(c, 5);
                textBox3.Text = ("синус равен: " + c);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Angle = Angle.FromString(textBox2.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                var c = 1 / Math.Tan(Angle!.Radians);
                c = Math.Round(c, 5);
                textBox3.Text = ("тангенс равен: " + c);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                label5.Text += Angle.ToString();
                label5.Text += "-";
                _operators.Push(Angle.ToString());
                _operators.Push("-");
                textBox1.Text = string.Empty;
            }
            else { MessageBox.Show("Вы не ввели угол!!!!!!!!!!!!!!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                label5.Text += Angle.ToString();
                label5.Text += "*";
                _operators.Push(Angle.ToString());
                _operators.Push("*");
                textBox1.Text = string.Empty;
            }
            else { MessageBox.Show("Вы не ввели угол!!!!!!!!!!!!!!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                label5.Text += Angle.ToString();
                label5.Text += "/";
                _operators.Push(Angle.ToString());
                _operators.Push("/");
                textBox1.Text = string.Empty;
            }
            else { MessageBox.Show("Вы не ввели угол!!!!!!!!!!!!!!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (integ != null)
            {
                var Cunt = Math.Acos((double)integ);
                Angle = Angle.FromRadians(Cunt);
                textBox3.Text = ("арккосинус равен: " + Angle);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (integ != null)
            {
                var Cunt = Math.Asin((double)integ);
                Angle = Angle.FromRadians(Cunt);
                textBox3.Text = ("арксинус равен: " + Angle);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (integ != null)
            {
                var Cunt = Math.Atan((double)integ);
                Angle = Angle.FromRadians(Cunt);
                textBox3.Text = ("артангенс равен: " + Angle);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (integ != null)
            {
                var Cunt = Math.Atan(1 / (double)integ);
                Angle = Angle.FromRadians(Cunt);
                textBox3.Text = ("арккотангенс равен: " + Angle);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }
    }
}
