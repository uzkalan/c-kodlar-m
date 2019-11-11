using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Adana Kebap(15TL)");
            checkedListBox1.Items.Add("Urfa Kebap(10TL)");
            checkedListBox1.Items.Add("Beyti(20TL)");
            checkedListBox1.Items.Add("Kuzu Şiş(17TL)");

            radioButton1.Text = "Kola(2TL)";
            radioButton2.Text = "Ayran(3TL)";
            radioButton3.Text = "Şalgam(2TL)";
            radioButton4.Text = "Su(1TL)";

            label3.Text = "Baharatlar";
            checkBox1.Text = "Kırmızı Biber(2TL)";
            checkBox2.Text = "Karabiber(1TL)";
            checkBox3.Text = "Yeşil Biber(2TL)";
            button1.Text = "Sipariş Ver";
            button2.Text = "Siparişi İptal Et";
            label4.Text = "Sipariş Detayı";
            label5.Text = "Toplam";
           
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addlist = "";
            addlist = addlist + (checkedListBox1.SelectedItem.ToString()) + " ";
            MessageBox.Show("Siparişiniz Alınmıştır." +
                "Afiyet Olsun.");
            int Toplam = 0;
            
          
            if (checkBox3.Checked)
            {
                addlist = addlist + checkBox3.Text + " ";
                { Toplam = Toplam + 2; }
                
               
            }
            if (checkBox1.Checked)
            {
                addlist = addlist + checkBox1.Text + " ";
                { Toplam = Toplam + 2; }
            }
            if (checkBox2.Checked)
            {

                addlist = addlist + checkBox2.Text + " ";
                { Toplam = Toplam + 1; }

            }
            if (radioButton1.Checked)
            {
                addlist = addlist + radioButton1.Text + " ";
                { Toplam = Toplam + 2; }
            }
            if (radioButton2.Checked)
            {
                addlist = addlist + radioButton2.Text + " ";
                { Toplam = Toplam +3 ; }
            }
            if (radioButton3.Checked)
            {
                addlist = addlist + radioButton3.Text + " ";
                { Toplam = Toplam + 2; }
            }
            if (radioButton4.Checked)
            {
                addlist = addlist + radioButton4.Text + " ";
                { Toplam = Toplam +1 ; }
            }
            if(checkedListBox1.SelectedItem == "Adana Kebap(15TL)") { Toplam = Toplam + 15; }
            if (checkedListBox1.SelectedItem == "Urfa Kebap(10L)") { Toplam = Toplam + 10; }
            if (checkedListBox1.SelectedItem == "Beyti(20TL)") { Toplam = Toplam + 20; }
            if (checkedListBox1.SelectedItem == "Kuzu Şiş(17TL)") { Toplam = Toplam + 17; }


            listBox1.Items.Add(addlist.ToString());
            listBox2.Items.Add(Toplam.ToString() + "TL");

        }

        private void button2_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Siparişiniz İptal Edilmiştir.");
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Items.Add("0TL");
            if (checkBox1.Checked == true) { checkBox1.Checked = false; }
            if(checkBox2.Checked == true) { checkBox2.Checked = false; }
            if(checkBox3.Checked == true) { checkBox3.Checked = false; }


            if (radioButton1.Checked == true) { radioButton1.Checked = false; }
            if(radioButton2.Checked == true) { radioButton2.Checked = false; }
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
            if (radioButton4.Checked == true) { radioButton4.Checked = false; }


            










        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       
        
            

        
    }
}
