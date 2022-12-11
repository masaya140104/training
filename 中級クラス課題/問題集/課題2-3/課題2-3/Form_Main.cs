namespace 課題2_3
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private string[] who = { "鼠", "牛", "虎", "兎", "竜", "蛇", "馬", "羊", "猿", "鳥" };
        private string[] what = { "マイコン", "パソコン", "電子回路", "本", "机", "椅子", "洗濯機", "電子レンジ", "自転車", "車" };
        private string[] how = { "組み立てた", "設計した", "壊した", "書いた", "利用した", "変えた", "買った", "売った", "運転した", "調べた" };

        private void button_Click(object sender, EventArgs e)
        {  
            string whoWord = RandomWord(who);
            string whatWord = RandomWord(what);
            string howWord = RandomWord(how);
            MessageBox.Show(whoWord + "が" + whatWord + "を" + howWord);
        }

        private string RandomWord(string[] words)
        {
            Random r = new Random();
            string word  = words[r.Next(0,words.Length)];
            return word;
        }


    }
}