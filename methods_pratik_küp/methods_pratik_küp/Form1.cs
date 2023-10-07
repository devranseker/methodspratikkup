namespace methods_pratik_küp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kupHesapla(int number)
        {
            int sonuc = number * number * number;
            return sonuc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox1.Text);
            label1.Text = kupHesapla(n).ToString();


        }
    }
}