﻿using System;
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
    public partial class Form3 : Form
    {
        public string name, surname, gender;
        Form4 frm4;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            frm4 = new Form4();
            if (radioButton1.Checked)
                frm4.likes = "BMW";
            if (radioButton2.Checked)
                frm4.likes = "Audi";
            if (radioButton3.Checked)
                frm4.likes = "Mercedes";
            frm4.name = name;
            frm4.surname = surname;
            frm4.gender = gender;

            frm4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text += name;
        }   
    }
}
