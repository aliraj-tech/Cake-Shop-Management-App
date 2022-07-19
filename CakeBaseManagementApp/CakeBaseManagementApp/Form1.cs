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


namespace Firebase
{
    public partial class Form1 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VRAL6uFeWOlYnRygp0HcQPfiNf3FYj4pTrj1WIPk",
            BasePath = "https://projexx-e2a3f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                this.label4.Text = "Connected";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            var datalayer = new Data
            {

                Id = textBox1.Text,
                Name = textBox2.Text,
                txtAge = textBox3.Text
            };

            SetResponse resp = await client.SetTaskAsync("Information /" + textBox1.Text, datalayer);
            Data result = resp.ResultAs<Data>();
            MessageBox.Show("Data" + result.Id + " is inserted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
