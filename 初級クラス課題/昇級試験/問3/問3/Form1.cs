namespace 問3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(this.label2.Text) + int.Parse(this.textBox1.Text);

            this.label2.Text = sum.ToString();

            double tax = Math.Floor(double.Parse(this.label2.Text) * 1.08);

            this.label4.Text = tax.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text = "0";

            this.label4.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}