namespace Lab2_dasha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox1.Text);
            double z = Convert.ToDouble(textBox3.Text);
            textBox4.Text = "Результати роботи програми" + " Дмитренка І.І." + Environment.NewLine;
            textBox4.Text += "При X = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
            double u;
            if(radioButton1.Checked)
u = y * Math.Sin(x) * Math.Sin(x) + z;
else if (radioButton2.Checked)
   u = y * Math.Exp(Math.Sin(x)) ‐ z;
else
                u = y * Math.Sin(Math.Sin(x)) + z;
            textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
        }

    }
}
}