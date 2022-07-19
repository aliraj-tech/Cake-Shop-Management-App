using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace CakeBaseManagementApp
{
    public partial class Form2 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VRAL6uFeWOlYnRygp0HcQPfiNf3FYj4pTrj1WIPk",
            BasePath = "https://projexx-e2a3f-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                this.label4.Text = "Connected";
            }

            combo.Items.Add("Chocolate Cake");
            combo.Items.Add("Vanilla Cake");
            combo.Items.Add("PineApple Cake");
            combo.Items.Add("Candels");
            combo.Items.Add("Decorations");
            

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
         //   dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);




            var datalayer = new Data
            {

                Id = textBox1.Text,
                Name = textBox3.Text,
                txtAge = textBox2.Text,
              //  items = textBox4.Text,
                total = textBox5.Text

            };

            SetResponse resp = await client.SetTaskAsync("Information /" + textBox1.Text, datalayer);
            Data result = resp.ResultAs<Data>();

            MessageBox.Show("Data of Customer ID " + result.Id+ " is inserted");
            //    MessageBox.Show("Data" + result.Id + " is inserted");



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo.SelectedItem.ToString() == "Chocolate Cake")
            {
                textBox7.Text = "400";
            }
            if (combo.SelectedItem.ToString() == "Vanilla Cake")
            {
                textBox7.Text = "300";
            }
            if (combo.SelectedItem.ToString() == "PineApple Cake")
            {
                textBox7.Text = "200";
            }
            if (combo.SelectedItem.ToString() == "Decorations")
            {
                textBox7.Text = "100";
            }
            if (combo.SelectedItem.ToString() == "Candels")
            {
                textBox7.Text = "50";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if(textBox4.Text.Length > 0)
            {
                textBox6.Text = (Convert.ToInt16(textBox7.Text) * Convert.ToInt16(textBox4.Text)).ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)


        {
            textBox5.Text = (Convert.ToInt16(textBox5.Text) + Convert.ToInt16(textBox6.Text)).ToString();
           
            dataGridView2.Rows.Add(combo.SelectedItem, textBox7.Text, textBox6.Text, textBox4.Text);

        
        }
    }
    
}
