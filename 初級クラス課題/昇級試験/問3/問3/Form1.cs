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
            int sum = int.Parse(this.label_sum_display.Text) + int.Parse(this.textBox.Text);

            this.label_sum_display.Text = sum.ToString();

            double tax = Math.Floor(double.Parse(this.label_sum_display.Text) * 1.08);

            this.label_tax_display.Text = tax.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label_sum_display.Text = "0";

            this.label_tax_display.Text = "0";

            this.textBox.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}