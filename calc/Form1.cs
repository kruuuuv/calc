using calc.Models;

namespace calc
{

    public partial class Form1 : Form
    {
        private Angle? Angle;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (comboBox2.SelectedIndex == -1)
            //{
            //    a = double.Parse(textBox1.Text);
            //    degree = (int)a;
            //    if (a % 1 != 0)
            //    {
            //        minut = (int)(60 * (a - degree));
            //        if ((60 * (a - degree)) % 1 != 0)
            //        {
            //            ;
            //            sec = (int)(60 * ((60 * (a - degree)) % 1));
            //            textBox2.Text = (" " + degree + "° " + minut + "' " + sec + "'' ");
            //        }
            //        else { textBox2.Text = (" " + degree + "° " + minut + "' "); }
            //    }
            //    else { textBox2.Text = (" " + degree + "° "); }
            //}
            //ar = a * Math.PI / 180;
            Angle = Angle.FromString(textBox1.Text);
            textBox2.Text = Angle.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox cb)
            {
                switch (cb.SelectedItem.ToString())
                {
                    case "°":
                        textBox1.Text += "°";
                        break;
                    case "'":
                        textBox1.Text += "'";
                        break;
                    case "\"":
                        textBox1.Text += "\"";
                        break;
                    default:
                        break;
                }
            }

            //if (comboBox2.SelectedIndex == 0)
            //{
            //    degree = int.Parse(textBox1.Text);
            //    textBox2.Text = (" " + degree + "° ");
            //}
            //if (comboBox2.SelectedIndex == 1)
            //{
            //    minut = int.Parse(textBox1.Text);
            //    textBox2.Text = (" " + degree + "° " + minut + "' ");
            //}
            //if (comboBox2.SelectedIndex == 2)
            //{
            //    sec = int.Parse(textBox1.Text);
            //    textBox2.Text = (" " + degree + "° " + minut + "' " + sec + "'' ");
            //}
            //a = degree + minut * 0.06 + sec * 0.0036;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                var c = Math.Cos(Angle!.Radians);
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
                textBox3.Text = ("Тангенс равен: " + c);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Angle != null)
            {
                var c = Math.Sin(Angle!.Radians);
                textBox3.Text = ("Синус равен: " + c);
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
                textBox3.Text = ("Котангенс равен: " + c);
            }
            else
            {
                textBox3.Text = ("Угол не определен.");
            }
        }
    }
}
