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
    public partial class Form4 : Form
    {
        string GetText;


        public Form4()
        {

        }

        public Form4(string ResultKey)
        {
            InitializeComponent();
            textBox1.Text = ResultKey;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form5 showForm5 = new Form5();
            showForm5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화면의 암호문을 옮겨주세요.\n" +
                "확인을 누르시면 일시정지가 풀립니다.", "일시정지",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }
    }
}
 
