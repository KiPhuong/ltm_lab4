namespace ltm_lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //bai 2
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //bai 4
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //bai 5
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }
    }
}