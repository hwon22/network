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
                    string plain = c.plainControl(plainis);

                    MessageBox.Show("변환된 암호문은 "+key+"\r\n변환된 평문은 "+plain+" 입니다.", "변환완료",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    this.Hide();    //form 전환
                    Form3 setform3 = new Form3(key,plain);  
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
            string[] keyResult = a.Split(s, StringSplitOptions.RemoveEmptyEntries);
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
        public string plainControl(string b)
        {
            string[] s = new string[] { " " };
            string[] plainResult = b.Split(s, StringSplitOptions.RemoveEmptyEntries);
            string plainsResult = String.Concat(plainResult);

            char[] plaining = plainsResult.ToCharArray(0, plainsResult.Length);
            List<char> list2 = new List<char>();
            for (int k = 0; k < plaining.Length; k += 2)
            {
                list2.Add(plaining[k]);
                if (k + 1 < plaining.Length)
                {
                    if (plaining[k] == plaining[k + 1])
                    {
                        list2.Add('x');
                    }
                    list2.Add(plaining[k + 1]);
                }
            } 
            if(list2.Count%2!=0)
                  { list2.Add('x'); }

            string plainPan = String.Concat(list2);

            return plainPan;
        }

    }
}
