﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //myButton.Text = "hi";
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("이곳의 문자열을 출력합니다");
            this.Visible = false;             // 추가

            Form2 showForm2 = new Form2();

            showForm2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
