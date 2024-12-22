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

namespace pharmacy_poject
{
    public partial class Form1 : Form
    {
        private object textBox1_Text;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("please enter username  ", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == null)
            {
                MessageBox.Show("please enter password  ", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
