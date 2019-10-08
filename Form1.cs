using System;
using System.Windows.Forms;
using ParkeciOtomasyonu;

namespace Parkeci_Otomasyon
{
    public partial class Form1 : Form
    {
        Otomasyon oto = new Otomasyon();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String msg = oto.girisYap(textBox1.Text, textBox2.Text);
            if ( msg == "ok" )
            {
                Form Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void Form1_Load(object sender, EventArgs e)
		{
            
		}
	}
}
