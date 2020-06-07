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
        string GetText2;
        public static string keyPan;
        public static string plainPan;

        public Form3()
        {

        }

        public Form3(string ParentsText, string ParentsText2)
        {
            InitializeComponent();
            this.GetText = ParentsText; //GetText _ key값
            this.GetText2 = ParentsText2; //GetText _ plain값

            //key판 만들기
                char[] arr = GetText.ToCharArray(0, GetText.Length);
                string alp = "abcdefghijklmnopqrstuvwxy";
                char[] alpha = alp.ToCharArray();
                int i = 0, j=0;
                
                List<char> list = new List<char>();
                TextBox[] textBox = new TextBox[25] {textBox1,textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10,
                                                    textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20,
                                                    textBox21,textBox22,textBox23,textBox24,textBox25 };
                for (i = 0; i < GetText.Length; i++)
                {
                    textBox[i].Text = arr[i].ToString();  list.Add(arr[i]);
                }

                for (i = GetText.Length; i <= 24+j; i++)
                {
          
                    if (list.Contains(alpha[i - GetText.Length]))
                    {
                        j++;
                    }
                    else
                    {   
                        textBox[i-j].Text = alpha[i - GetText.Length].ToString();
                        list.Add(alpha[i - GetText.Length]);

                    }
                }
                keyPan = String.Concat(list);

         

        }
   

        private void Form3_Load(object sender, EventArgs e)
        {

        }        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    //form 전환
            Form4 setform4 = new Form4(keyPan);
            setform4.Owner = this;
            setform4.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
