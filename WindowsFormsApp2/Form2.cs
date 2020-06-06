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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //자동생성 이벤트 - 삭제 시 오류
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //자동생성 이벤트 - 삭제 시 오류
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //자동생성 이벤트 - 삭제 시 오류
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key_box.Text != "" && plain_box.Text != "")
            {
                    string keyis = string.Empty;
                    string plainis = string.Empty;

                    keyis = key_box.Text;
                    plainis = plain_box.Text;

                    keyis = keyis.ToLower();
                    plainis = plainis.ToLower();

                    Control c = new Control();
                    string key=c.keyControl(keyis);
                    
                    this.Hide();    //form 전환
                    Form3 setform3 = new Form3(key,plainis);  
                    setform3.Owner = this;
                    setform3.ShowDialog();
                    this.Close();

            }
            else{
                    MessageBox.Show("암호키와 평문을 모두 입력해주세요.", "오류",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

      
    }
    class Control
    {
        public string keyControl(string a)
        {
            string[] s = new string[] { " " };
            string[] keyResult = a.Split(s, StringSplitOptions.RemoveEmptyEntries); //key문 소문자화, 중복제거 및 띄어쓰기 없애는 메소드로 이동
            string keysResult = String.Concat(keyResult);

            char[] arr = keysResult.ToCharArray(0, keysResult.Length);

            List<char> list = new List<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Contains(arr[i]))
                {
                    continue;
                }
                else
                {
                    list.Add(arr[i]);
                }
            }
            string key = string.Concat(list.ToArray());

            return key;

        }

    }
}
