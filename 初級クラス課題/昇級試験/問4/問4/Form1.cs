namespace 問4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                x = int.Parse(this.listBox1.Items[i].ToString());

                if (x >= 21)
                {
                    y += x;
                }
            }

            MessageBox.Show("合計 = " + y.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}