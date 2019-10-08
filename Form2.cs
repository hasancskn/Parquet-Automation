using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParkeciOtomasyonu;

namespace Parkeci_Otomasyon
{

    public partial class Form2 : Form
    {
        private Otomasyon oto = new Otomasyon();
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listele()
        {
            dataGridView1.DataSource = oto.listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean ok = oto.SiparisEkle(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            if (ok)
            {
                MessageBox.Show("Sipariş Alındı...", "Sipariş İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView4.DataSource = oto.listele();
            }else
                MessageBox.Show("Kayıt Alanları Boş Geçilemez!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
			Console.WriteLine(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			if ( oto.SiparisSil(dataGridView1.CurrentRow.Cells[0].Value.ToString()) )
                listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string ParkeID = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            string ParkeNo = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            string ParkeTürü = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            string ParkeMarkası = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            string Parkem2 = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            string Ücret = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            string Adı = dataGridView1.Rows[secili].Cells[6].Value.ToString();
            string Soyadı = dataGridView1.Rows[secili].Cells[7].Value.ToString();
            string Tel = dataGridView1.Rows[secili].Cells[8].Value.ToString();
            string Adres = dataGridView1.Rows[secili].Cells[9].Value.ToString();
            textBox15.Text = ParkeID;
            textBox14.Text = ParkeNo;
            comboBox3.Text = ParkeTürü;
            comboBox4.Text = ParkeMarkası;
            textBox13.Text = Parkem2;
            textBox12.Text = Ücret;
            textBox9.Text = Adı;
            textBox10.Text = Soyadı;
            textBox11.Text = Tel;
            textBox8.Text = Adres;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (oto.SiparisGuncelle(textBox15.Text, textBox14.Text, comboBox4.Text, comboBox3.Text, textBox13.Text, textBox12.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox8.Text))
            {
                MessageBox.Show("Güncellemeİşlemi Başarılı", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = oto.listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataSet ds = oto.parkeAra(textBox16.Text);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = oto.listele();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

		private void textBox15_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
