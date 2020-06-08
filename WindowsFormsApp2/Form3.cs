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
        string encryptionWord;
        public Form3()
        {

        }

        public Form3(string key, string plain, string keypan)
        {

            InitializeComponent();
            TextBox[] textbox = new TextBox[25] { textBox1,textBox2,textBox3,textBox4, textBox5, textBox6,textBox7,textBox8,textBox9,textBox10,
            textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20,
            textBox21,textBox22,textBox23,textBox24,textBox25 };
            char[] plainis= keypan.ToCharArray(0, keypan.Length);
            for(int i=0; i<plainis.Length; i++)
            {

                textbox[i].Text = plainis[i].ToString();
            }
            Made m = new Made();
            encryptionWord = m.encryption(keypan,plain);

        }
   

        private void Form3_Load(object sender, EventArgs e)
        {

        }        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("암호키는 " + encryptionWord +" 입니다.", "변환완료",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            this.Hide();    //form 전환
            Form4 setform4 = new Form4(encryptionWord);
            setform4.Owner = this;
            setform4.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        class Made
        {
           
            public string encryption(string keypan,string plain)
            {
                char[,] keytable5x5 = new char[5, 5];
                char[] arr; int k = 0; string result;
                arr = keypan.ToCharArray(0,keypan.Length);
                int a1 = 0, a2 = 0, b1 = 0, b2 = 0;
                //암호판 만들기
                for (int i=0; i<5; i++)
                {
                   for(int j=0; j<5; j++)
                    {
                        keytable5x5[i, j] = arr[k];
                        k++;
                    }
                }

                //두글자씩 잘라서 위치 파악하기
                List<char> cryptogram = new List<char>(); //
                
                char[] ResultPlain = new char[plain.Length];
                string plaintext  = plain;
                char [] arr2 = plaintext.ToCharArray(0, plaintext.Length);
                char[] tmpArr = new char[2];
                char[] temp = new char[2];

                for (int i = 0; i < plaintext.Length; i += 2)
                {

                    temp[0] = arr2[i];
                    temp[1] = arr2[i + 1];
                    cryptogram.Add(temp[0]);
                    cryptogram.Add(temp[1]);

                    for (int x = 0; x < 5; x++)
                    {
                        for (int y = 0; y < 5; y++)
                        {
                            if (keytable5x5[x, y] == temp[0])
                            {
                                a1 = x;
                                b1 = y;
                            }
                            if (keytable5x5[x, y] == temp[1])
                            {
                                a2 = x;
                                b2 = y;
                            }
                        }
                    }

                    //위치따라 암호문 만들기+암호문 return
                    if (a1 == a2) // 같은 행
                    {
                        tmpArr[0] = keytable5x5[a1, (b1 + 1) % 5];
                        tmpArr[1] = keytable5x5[a2, (b2 + 1) % 5];
                    }
                    else if (b1 == b2) // 같은 열
                    {
                        tmpArr[0] = keytable5x5[(a1 + 1) % 5, b1];
                        tmpArr[1] = keytable5x5[(a2 + 1) % 5, b2];
                    }
                    else // 행, 열 모두 다른경우
                    {
                        tmpArr[0] = keytable5x5[a2, b1];
                        tmpArr[1] = keytable5x5[a1, b2];
                    }
                    ResultPlain[i]=tmpArr[0];
                    ResultPlain[i+1]=tmpArr[1];
                }
                string str = string.Concat(ResultPlain);
                return str;
               
                
            }
        }
    }
}
