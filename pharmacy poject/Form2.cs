using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.ConstrainedExecution;
namespace pharmacy_poject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        
        

        private void Textbox2_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus(); 
            }
        }
        FileStream myfile;
        StreamReader sr;
        StreamWriter sw;
        string filename = "C:\\pharmacy.txt";

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myfile.Seek(0, SeekOrigin.End);
            string record = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text;
            sw.WriteLine(record);
            sw.Flush();
            MessageBox.Show("the data is saved");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myfile = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
            sr = new StreamReader(myfile);
            sw = new StreamWriter(myfile);
            MessageBox.Show("File is opened");
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            

        }
    }
}
