using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        Form3 frm3;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                frm2 = new Form2();
                frm2.name = textBox1.Text;
                frm2.surname = textBox2.Text;
                frm2.gender = comboBox1.Text;
                frm2.Show();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                frm3 = new Form3();
                frm3.name = textBox1.Text;
                frm3.surname = textBox2.Text;
                frm3.gender = comboBox1.Text;
                frm3.Show();
            }

            else
                MessageBox.Show("Select a gender!");
        }


            
    }
}
