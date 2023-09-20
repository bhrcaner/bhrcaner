namespace WinFormsTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Ders 1:GUI tasarimi";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void buttonİsimEkle_Click(object sender, EventArgs e)
        {
            comboBoxIsimler.Items.Add(textBoxMesaj.Text);
            listBoxKişiler.Items.Add(textBoxMesaj.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLabeldeğişitir_Click(object sender, EventArgs e)
        {
            labelYazılanIsim.Text = textBoxMesaj.Text;
        }

        private void buttonRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBoxMetin.Text = richTextBoxMetin.Text + "\n" + dateTimePicker1.Text;
            richTextBoxMetin.Text = richTextBoxMetin.Text + "\n" + trackBarVolume.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {

        }
    }
}