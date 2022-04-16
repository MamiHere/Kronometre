namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = Convert.ToInt32(comboBox1.Text);
        }

        void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            listBox1.Items.Add(label2.Text);
        }

        int sayac,kalansure=0;
        void timer1_Tick(object sender, EventArgs e)
        {
            int sayý = Convert.ToInt32(textBox1.Text);
            kalansure = sayý - sayac;
            sayac++;
            label2.Text = kalansure.ToString();
            if (kalansure==0)
            {
                timer1.Enabled = false;
                kalansure = 0;
                sayac = 0;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("100");
            comboBox1.Items.Add("1000");
            comboBox1.Items.Add("10000");
        }
    }
}