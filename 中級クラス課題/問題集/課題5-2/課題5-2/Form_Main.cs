namespace 課題2_1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int age = 0;

            if (! int.TryParse(this.textBox.Text, out age))
            {
                MessageBox.Show("年齢を入力してください");
                this.textBox.Clear();
                return;
            }

            if (age < 16)
            {
                MessageBox.Show("原付の免許も自動車の免許も取得できません。");
            }
            else if (age <18)
            {
                MessageBox.Show("原付の免許は取得できますが、自動車の免許は取得出来ません。");
            }
            else
            {
                MessageBox.Show("原付免許も自動車の免許も取得できます。");
            }
        }
    }
}