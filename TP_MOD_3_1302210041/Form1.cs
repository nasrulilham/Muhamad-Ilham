using System.Reflection.Emit;

namespace TP_MOD_3_1302210041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            label1.Text = "Halo " + input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}