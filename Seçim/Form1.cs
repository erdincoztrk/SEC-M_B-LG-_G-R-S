using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seçim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboIlce.Text != "")
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
            else
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
        }

        private void comboIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboIl.Text == "Yalova")
            {
                comboIlce.Text = "";
                comboIlce.Items.Clear();
                comboIlce.Items.Add("Termal");
                comboIlce.Items.Add("MERKEZ");
                comboIlce.Items.Add("ÇİFTLİKKÖY");
                comboIlce.Enabled = true;
                
            }

            else if (comboIl.Text == "İzmir")
            {
                comboIlce.Text = "";
                comboIlce.Items.Clear();
                comboIlce.Items.Add("TİRE");
                comboIlce.Items.Add("BUCA");
                comboIlce.Items.Add("ÖDEMİŞ");
                comboIlce.Enabled = true;
                
            }
            else if(comboIl.Text == "")
            {
                comboIlce.Items.Clear();
                comboIlce.Text = "";
            }
        }

     

       
        double s1, s2, s3, s4, s1ort, s2ort, s3ort, s4ort;

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            button3.Visible = true;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
        
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    listBox1.Items.Clear();
        //    listBox1.Visible = false;

        //    progressBar1.Value = 0;
        //    progressBar2.Value = 0;
        //    progressBar3.Value = 0;
        //    progressBar4.Value = 0;
        //    progressBar1.Visible = false;
        //    progressBar2.Visible = false;
        //    progressBar3.Visible = false;
        //    progressBar4.Visible = false;

        //    textBox1.Text = "";
        //    textBox2.Text = "";
        //    textBox3.Text = "";
        //    textBox4.Text = "";
        //    textBox1.Visible = false;
        //    textBox2.Visible = false;
        //    textBox3.Visible = false;
        //    textBox4.Visible = false;

        //    lbl1.Text = "----";
        //    lbl2.Text = "----";
        //    lbl3.Text = "----";
        //    lbl4.Text = "----";
        //    lbl1.Visible = false;
        //    lbl2.Visible = false;
        //    lbl3.Visible = false;
        //    lbl4.Visible = false;

        //    label1.Visible = false;
        //    label2.Visible = false;
        //    label3.Visible = false;
        //    label4.Visible = false;
        //    label5.Visible = false;
        //    label6.Visible = false;
        //    label7.Visible = false;

        //    button2.Visible = false;
        //    button1.Visible = false;

        //    s1 = 0;
        //    s2 = 0;
        //    s3 = 0;
        //    s4 = 0;
        //    s1ort = 0;
        //    s2ort = 0;
        //    s3ort = 0;
        //    s4ort = 0;


        //    comboBox1.Visible = false;
        //    comboBox2.Visible = false;
        //    comboBox3.Visible = false;
        //    comboBox4.Visible = false;

        //    comboIl.Enabled = true;
        //    comboIlce.Enabled = false;
        //    comboBox1.Enabled = true;
        //    comboBox2.Enabled = true;
        //    comboBox3.Enabled = true;
        //    comboBox4.Enabled = true;

        //    radioButton1.Checked = false;
        //    radioButton2.Checked = false;
        //    radioButton3.Checked = false;
        //    radioButton4.Checked = false;




        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            
            
            if (radioButton1.Checked == true && comboBox1.Text != "")
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;

                textBox1.Enabled = true;

                lbl1.Visible = true;

                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                button2.Visible = true;

                progressBar1.Visible = true;

                lbl1.Text = comboBox1.Text;

                kilit();


            }
            else if (radioButton1.Checked == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("EKSİK PARTİ SEÇİMİ YAPTINIZ!");
                }
            }


            if (radioButton2.Checked == true && comboBox1.Text != comboBox2.Text)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;

                progressBar1.Visible = true;
                progressBar2.Visible = true;
                progressBar3.Visible = false;
                progressBar4.Visible = false;

                button2.Visible = true;

                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                lbl4.Visible = false;

                lbl1.Text = comboBox1.Text;
                lbl2.Text = comboBox2.Text;

                kilit();

                lbl1.Text = comboBox1.Text;
                lbl2.Text = comboBox2.Text;
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("EKSİK PARTİ SEÇİMİ YAPTINIZ!");
                }
            }
            else if(radioButton2.Checked == true && comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("AYNI PARTİ BİRDEN FAZLA SEÇİLEMEZ!");
            }


            if (radioButton3.Checked == true && comboBox1.Text != comboBox2.Text && comboBox1.Text != comboBox3.Text && comboBox2.Text != comboBox3.Text)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                progressBar1.Visible = true;
                progressBar2.Visible = true;
                progressBar3.Visible = true;
                progressBar4.Visible = false;

                button2.Visible = true;

                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = false;

                lbl1.Text = comboBox1.Text;
                lbl2.Text = comboBox2.Text;
                lbl3.Text = comboBox3.Text;

                kilit();

            }
            else if (radioButton3.Checked == true)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                {
                    MessageBox.Show("EKSİK PARTİ SEÇİMİ YAPTINIZ!");
                }
                if(comboBox1.Text == comboBox3.Text || comboBox2.Text == comboBox3.Text || comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("AYNI PARTİ BİRDEN FAZLA SEÇİLEMEZ");
                }
            }



            if (radioButton4.Checked == true && comboBox1.Text != comboBox2.Text && comboBox1.Text != comboBox3.Text && comboBox1.Text != comboBox4.Text && comboBox2.Text != comboBox3.Text && comboBox2.Text != comboBox4.Text && comboBox3.Text != comboBox4.Text)
            {

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                progressBar1.Visible = true;
                progressBar2.Visible = true;
                progressBar3.Visible = true;
                progressBar4.Visible = true;

                button2.Visible = true;
                button3.Visible = true;

                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;

                lbl1.Text = comboBox1.Text;
                lbl2.Text = comboBox2.Text;
                lbl3.Text = comboBox3.Text;
                lbl4.Text = comboBox4.Text;

                kilit();
            }

            else if (radioButton4.Checked == true)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
                {
                    MessageBox.Show("EKSİK PARTİ SEÇİMİ YAPTINIZ!");
                }

                if(comboBox1.Text == comboBox2.Text || comboBox1.Text == comboBox3.Text || comboBox1.Text == comboBox4.Text || comboBox2.Text == comboBox3.Text || comboBox2.Text == comboBox4.Text || comboBox3.Text == comboBox4.Text ||comboBox4.Text == comboBox1.Text)
                {
                    MessageBox.Show("AYNI PARTİYİ BİRDEN FAZLA SEÇEMEZSİNİZ!");
                }
                
            }
            
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = false;
            button3.Visible = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            button3.Visible = true;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            button3.Visible = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && textBox1.Text != "")
            {
                s1 = Convert.ToInt32(textBox1.Text);
                s1ort = s1 * 100 / s1;
                progressBar1.Value = Convert.ToInt32(s1ort);
                label1.Text = s1ort.ToString("0.00") + "%";

                listBox1.Items.Clear();
                listBox1.Items.Add("KULLANILAN OY SAYISI: " + s1);
                listBox1.Items.Add(lbl1.Text + " / OY SAYISI: " + textBox1.Text + " / OY YÜZDESİ: " + label1.Text);
            }
            else if(radioButton1.Checked == true && textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN OY SAYISI GİRİNİZ!");
            }

            if (radioButton2.Checked == true)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    s1 = Convert.ToInt32(textBox1.Text);
                    s2 = Convert.ToInt32(textBox2.Text);

                    s1ort = s1 * 100 / (s1 + s2);
                    s2ort = s2 * 100 / (s1 + s2);

                    progressBar1.Value = Convert.ToInt32(s1ort);
                    progressBar2.Value = Convert.ToInt32(s2ort);


                    label1.Text = s1ort.ToString("0.00") + "%";
                    label2.Text = s2ort.ToString("0.00") + "%";

                    listBox1.Items.Clear();
                    listBox1.Items.Add("KULLANILAN AY SAYISI: " + (s1 + s2));
                    listBox1.Items.Add(lbl1.Text + " / OY SAYISI: " + textBox1.Text + " / OY YÜZDESİ: " + label1.Text);
                    listBox1.Items.Add(lbl2.Text + " / OY SAYISI: " + textBox2.Text + " / OY YÜZDESİ: " + label2.Text);
                }
                else if(textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("LÜTFEN OY DEĞERİ GİRİNİZ!");
                }
            }

            if (radioButton3.Checked == true)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    s1 = Convert.ToInt32(textBox1.Text);
                    s2 = Convert.ToInt32(textBox2.Text);
                    s3 = Convert.ToInt32(textBox3.Text);

                    s1ort = s1 * 100 / (s1 + s2 + s3);
                    s2ort = s2 * 100 / (s1 + s2 + s3);
                    s3ort = s3 * 100 / (s1 + s2 + s3);



                    progressBar1.Value = Convert.ToInt32(s1ort);
                    progressBar2.Value = Convert.ToInt32(s2ort);
                    progressBar3.Value = Convert.ToInt32(s3ort);



                    label1.Text = s1ort.ToString("0.00") + "%";
                    label2.Text = s2ort.ToString("0.00") + "%";
                    label3.Text = s3ort.ToString("0.00") + "%";

                    listBox1.Items.Clear();
                    listBox1.Items.Add("KULLANILAN OY SAYISI: " + (s1 + s2 + s3));
                    listBox1.Items.Add(lbl1.Text + " / OY SAYISI: " + textBox1.Text + " / OY YÜZDESİ: " + label1.Text);
                    listBox1.Items.Add(lbl2.Text + " / OY SAYISI: " + textBox2.Text + " / OY YÜZDESİ: " + label2.Text);
                    listBox1.Items.Add(lbl3.Text + " / OY SAYISI: " + textBox3.Text + " / OY YÜZDESİ: " + label3.Text);
                }

                else if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("LÜTFEN OY SAYISI GİRİNİZ");
                }
            }

            if (radioButton4.Checked == true)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    s1 = Convert.ToInt32(textBox1.Text);
                    s2 = Convert.ToInt32(textBox2.Text);
                    s3 = Convert.ToInt32(textBox3.Text);
                    s4 = Convert.ToInt32(textBox4.Text);

                    s1ort = s1 * 100 / (s1 + s2 + s3 + s4);
                    s2ort = s2 * 100 / (s1 + s2 + s3 + s4);
                    s3ort = s3 * 100 / (s1 + s2 + s3 + s4);
                    s4ort = s4 * 100 / (s1 + s2 + s3 + s4);

                    progressBar1.Value = Convert.ToInt32(s1ort);
                    progressBar2.Value = Convert.ToInt32(s2ort);
                    progressBar3.Value = Convert.ToInt32(s3ort);
                    progressBar4.Value = Convert.ToInt32(s4ort);

                    double s1db = Convert.ToDouble(s1ort);
                    double s2db = Convert.ToDouble(s2ort);
                    double s3db = Convert.ToDouble(s3ort);
                    double s4db = Convert.ToDouble(s4ort);

                    label1.Text = s1db.ToString("0.00") + "%";
                    label2.Text = s2db.ToString("0.00") + "%";
                    label3.Text = s3db.ToString("0.00") + "%";
                    label4.Text = s4db.ToString("0.00") + "%";

                    listBox1.Items.Clear();
                    listBox1.Items.Add("KULLANILAN OY SAYISI: " + (s1 + s2 + s3 + s4));
                    listBox1.Items.Add(lbl1.Text + " / OY SAYISI: " + textBox1.Text + " / OY YÜZDESİ: " + label1.Text);
                    listBox1.Items.Add(lbl2.Text + " / OY SAYISI: " + textBox2.Text + " / OY YÜZDESİ: " + label2.Text);
                    listBox1.Items.Add(lbl3.Text + " / OY SAYISI: " + textBox3.Text + " / OY YÜZDESİ: " + label3.Text);
                    listBox1.Items.Add(lbl4.Text + " / OY SAYISI: " + textBox4.Text + " / OY YÜZDESİ: " + label4.Text);
                }

                else if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("OY SAYISINI GİRİNİZ!");
                }
            }
            

            }

        public void kilit()
        {
            comboIl.Enabled = false;
            comboIlce.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            button3.Enabled = false;
            listBox1.Visible = true;

        }
    }
}
