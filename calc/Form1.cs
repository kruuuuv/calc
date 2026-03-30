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
        decimal Integ;
        double a;
        int degrees, minutes, secunds;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                a = double.Parse(textBox1.Text);
                degrees = (int)a;
                if (a % 1 != 0)
                {
                    minutes = (int)(60 * (a - degrees));
                    if ((60 * (a - degrees)) % 1 != 0)
                    {
                        secunds = (int)(60 * ((60 * (a - degrees)) % 1));
                        textBox2.Text = (" " + degrees + "° " + minutes + "' " + secunds + "''");
                    }
                    else { textBox2.Text = (" " + degrees + "° " + minutes + "' "); }
                }
                else { textBox2.Text = (" " + degrees + "° "); }
            }
            Angle = Angle.FromString(textBox2.Text);
            
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
                            Integ = decimal.Parse(textBox1.Text);
                            Angle = Angle.FromString(_operators.Pop()) * Integ;
                            label5.Text += "*";
                            break;
                        case "/":
                            Integ = decimal.Parse(textBox1.Text);
                            Angle = Angle.FromString(_operators.Pop()) / Integ;
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
            if (comboBox2.SelectedIndex == 0)
            {
                degrees = int.Parse(textBox1.Text);
                textBox2.Text = (" " + degrees + "° ");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                minutes = int.Parse(textBox1.Text);
                if (minutes < 0 || minutes > 59)
                {
                    MessageBox.Show("Минуты должны входить в диапозон от 0 до 60", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minutes = 0;
                    textBox2.Text = (" " + degrees + "° ");
                }else { textBox2.Text = (" " + degrees + "° " + minutes + "' "); }
            }
            if (comboBox2.SelectedIndex == 2)
            {
                secunds = int.Parse(textBox1.Text);
                if (secunds < 0 || secunds > 59)
                {
                    MessageBox.Show("Секунды должны входить в диапозон от 0 до 60", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secunds = 0;
                    textBox2.Text = (" " + degrees + "° " + minutes + "' ");
                }else { textBox2.Text = (" " + degrees + "° " + minutes + "' " + secunds + "'' "); }
            }
            a = degree + minut * 0.06 + sec * 0.0036;
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
    }
}
