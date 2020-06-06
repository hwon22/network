using System;
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
    public partial class Form3 : Form
    {
        string GetText;

        public Form3()
        {
           
        }

        public Form3(string ParentsText, string ParentsText2)
        {
            InitializeComponent();
            this.GetText = ParentsText; //GetText

            string[] a = GetText.Split(',');
            foreach(var b in a)
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;             // 추가

            Form4 showForm4 = new Form4();

            showForm4.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
