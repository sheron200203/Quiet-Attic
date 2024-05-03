namespace QuietAttic
{
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduction form = new AddProduction();
            form.ShowDialog();
        }
    }
}
