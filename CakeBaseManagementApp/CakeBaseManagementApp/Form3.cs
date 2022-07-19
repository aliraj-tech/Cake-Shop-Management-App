using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeBaseManagementApp
{
    public partial class Form3 : Form
    {

        Form2 f2;
        private PrintDocument printDocument1;

        public Form3(Form2 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            
            txtResult.Text += "***RECEIPT SYSTEM*** \n";
            txtResult.Text += "******************** \n \n";
            txtResult.Text += "Date" + DateTime.Now + "\n";
            txtResult.Text += "ID = " + f2.textBox1.Text+ "\n";
            txtResult.Text += "Age = " + f2.textBox2.Text+ "\n";
            txtResult.Text += "Name = " + f2.textBox3.Text+ "\n";
          //  txtResult.Text += "Items = " + f2.textBox4.Text + "\n";
            txtResult.Text += "Total = " + f2.textBox5.Text + "Rs\n";


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text,new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10,10));
        }

       

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
