using System.Data;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Button = sender as Button;
            textBox1.Text += Button.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            var res = new DataTable();
            textBox1.Text = res.Compute(textBox1.Text, "").ToString();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}