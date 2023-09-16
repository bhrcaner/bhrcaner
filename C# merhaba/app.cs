namespace winform1
{
    public partial class Form1 : Form
    {
        private const string V = "Hello c#";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello c#";
        }
    }
}