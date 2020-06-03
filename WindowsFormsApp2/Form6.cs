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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //재시작버튼 클릭시
            this.Visible = false;             // 추가

            Form1 showForm1 = new Form1();

            showForm1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //프로그램 종료버튼 클릭시
            MessageBox.Show("프로그램을 종료합니다.", "종료",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);
            this.Visible = false;             // 추가
        }
    }
}
