namespace 課題2_2a
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sacredLot = {  "大吉：今日は最高の一日。",
                                    "吉：色々いいことがあるかも。",
                                    "中吉：ほしいものが手に入るかも。",
                                    "小吉：まわりの願いがかなうかも。",
                                    "半吉：果報は寝て待て。",
                                    "末吉：普通な一日。欲張らない方がいいかも。",
                                    "末小吉：ちょっとだけいいことがあるかも。",
                                    "凶：ちょっと今日はついてないかも。",
                                    "半凶：いいことが起きそうにない一日。",
                                    "末凶：ついてない一日。あまり無駄遣いしない方がいいかも。",
                                    "大凶：最悪の一日。おとなしくしておいたほうがいいかも。"};

            Random rand = new Random();

            int x = rand.Next(0, 11);

            MessageBox.Show(textBox_Name.Text + "さん" + "本日の運勢は..."  + "\n" + sacredLot[x]);
        }
    }
}