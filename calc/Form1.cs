namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Angle
        {
            public int Degrees { get; private set; }
            public int Minut { get; private set; }
            public int Sec { get; private set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            double c = Math.Cos(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
