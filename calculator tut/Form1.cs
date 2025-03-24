using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace calculator_tut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;

        }
        List<int> list = new List<int>();
        string awl = "", tany = "";
        string tdiv1 = "", tdiv2 = "";
        string tmul1 = "", tmul2 = "";
        string tmin1 = "", tmin2 = "";
        string tpul1 = "", tpul2 = "";

        float answer;
        float answer2;

        int posi;
        int posl;
        float n1;
        float n2;

        string rdiv = "", rmul = "", rmin = "", rpul = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }








        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
            list.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
            list.Add(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
            list.Add(3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
            list.Add(4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
            list.Add(5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
            list.Add(6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
            list.Add(7);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
            list.Add(8);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
            list.Add(9);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
            list.Add(0);

        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            list.Add('-');
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            list.Add('+');
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            list.Add('/');
        }
        private void button14_Click(object sender, EventArgs e)
        {



            textBox1.Text += "*";
            list.Add('*');
        }





        private void button15_Click(object sender, EventArgs e)
        {
            string eq = textBox1.Text;
            int fdiv = 0;
            int fmul = 0;
            int fmin = 0;
            int fpul = 0;
            int posdiv = 0, posmul = 0, posmin = 0, pospul = 0;
            int ctdiv = 0, ctmul = 0, ctmin = 0, ctpul = 0;

            string cpul = "";
            string cpul2 = "";
            string cpul3 = "";
            float calcpul2 = 0;
            float calcpul3 = 0;
            float anspul = 0;


            string cmin = "";
            string cmin2 = "";
            string cmin3 = "";
            float calcmin2 = 0;
            float calcmin3 = 0;
            float ansmin = 0;


            string cmul = "";
            string cmul2 = "";
            string cmul3 = "";
            float calcmul2 = 0;
            float calcmul3 = 0;
            float ansmul = 0;

            float tmul3 = 0;


            string calc = "";
            string calc2 = "";
            string calc3 = "";
            float calcdiv2 = 0;
            float calcdiv3 = 0;
            float ansdiv = 0;

            float ansDM = 0;
            float ansDMP = 0;
            float ansDMPM = 0;

            int divizor = 0;
            if (textBox1.Text[0] == '/' || textBox1.Text[0] == '+' || textBox1.Text[0] == '-' || textBox1.Text[0] == '*')
            {

                MessageBox.Show("error in text recheck");
                return;

            }
            if (textBox1.Text.Length > 0)
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];

                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    MessageBox.Show("Error:check the text");
                    //return;
                }
                //return;
            }
            for (int c = 0; c < textBox1.Text.Length; c++)
            {
                if (textBox1.Text[c] == '/' || textBox1.Text[c] == '+' || textBox1.Text[c] == '-' || textBox1.Text[c] == '*')
                {
                    if (textBox1.Text[c + 1] == '/' || textBox1.Text[c + 1] == '+' || textBox1.Text[c + 1] == '-' || textBox1.Text[c + 1] == '*')

                        MessageBox.Show("error in text recheck");
                       // return;

                }
                //return;
            }

           




            //for (int m = 0; m < textBox1.Text.Length; m++)
            //{
            //    ///division
            //    if (textBox1.Text[m] == '/')
            //    {
            //        fdiv = 1;
            //        posdiv = m;
            //        }
            //    if (textBox1.Text[m] == '*')
            //    {
            //        fmul = 1;
            //        posmul = m;
            //    }
            //    if (textBox1.Text[m] == '-')
            //    {
            //        fmin = 1;
            //        posmin = m;
            //    }
            //    if (textBox1.Text[m] == '+')
            //    {
            //        fpul = 1;
            //        pospul = m;
            //    }

            //}


            ////////////////////////DIIIIIVIIIIIIDE///////////////////////////
            /////
            //if (fdiv == 1)
            //{
                
            //    for (int i = posdiv-1; i >= 0; i--)
            //    {
            //        if (eq[i] == '+' || eq[i] == '-' || eq[i] == '/' || eq[i] == '*' )
            //        {
            //            break;
            //        }
            //        calc += eq[i];
            //    }
                    
            //    for (int i = calc.Length - 1; i >= 0; i--)
            //    {
            //        calc2 += calc[i];
            //    }
            //    for (int i = posdiv + 1; i < eq.Length; i++)
            //    {

                   
            //        if (eq[i] == '+' || eq[i] == '-' || eq[i] == '/' || eq[i] == '*')
            //        {
            //            break;
            //        }
            //        calc3 += eq[i];
            //    }
                
                
            //     calcdiv2  = float.Parse(calc2);
            //    calcdiv3 = float.Parse(calc3);
            //    ansdiv = calcdiv2 / calcdiv3;
                
            //}

            //if (fmul == 1)
            //{
               

            //    for (int y = posmul-1; y >= 0; y--)
            //    {
            //        if (eq[y] == '+' || eq[y] == '-' || eq[y] == '/' || eq[y] == '*')
            //        {
            //            break;
            //        }
            //        cmul += eq[y];
            //    }   
            //    for (int y = cmul.Length - 1; y >= 0;y--)
            //    {
            //        cmul2 += cmul[y];
            //    }
            //    for (int y = posmul+1; y < eq.Length; y++)
            //    {
            //        if (eq[y] == '+' || eq[y] == '-' || eq[y] == '/' || eq[y] == '*')
            //        {
            //            break;
            //        }
            //        cmul3 += eq[y];
            //    }
            //    calcmul2 = float.Parse(cmul2);
            //    calcmul3 = float.Parse(cmul3);
            //    ansmul = calcmul2 * calcmul3;
                
            //}
            //if (fmin == 1)
            //{
                

            //    for (int t = posmin-1; t >= 0; t--)
            //    {
            //        if (eq[t] == '+' || eq[t] == '-' || eq[t] == '/' || eq[t] == '*')
            //        {
            //            break;
            //        }
            //        cmin += eq[t];
            //    }
            //    for (int t = cmin.Length - 1; t >= 0; t--)
            //    {
            //        cmin2 += cmin[t];
            //    }
            //    for (int t = posmin+1; t < eq.Length; t++)
            //    {
            //        if (eq[t] == '+' || eq[t] == '-' || eq[t] == '/' || eq[t] == '*')
            //        {
            //            break;
            //        }
            //        cmin3 += eq[t];
            //    }
            //    calcmin2 = float.Parse(cmin2);
            //    calcmin3 = float.Parse(cmin3);
            //    ansmin = calcmin3 - calcmin2;

            //}
            //if (fpul == 1)
            //{
               

            //    for (int t = pospul-1; t >= 0; t--)
            //    {
            //        if (eq[t] == '+' || eq[t] == '-' || eq[t] == '/' || eq[t] == '*')
            //        {
            //            break;
            //        }
            //        cpul += eq[t];
            //    }
            //    for (int t = cpul.Length - 1; t >= 0; t--)
            //    {
            //        cpul2 += cpul[t];
            //    }
            //    for (int t = pospul + 1 ; t < eq.Length; t++)
            //    {
            //        if (eq[t] == '+' || eq[t] == '-' || eq[t] == '/' || eq[t] == '*')
            //        {
            //            break;
            //        }
            //        cpul3 += eq[t];
            //    }
            //    calcpul2 = float.Parse(cpul2);
            //    calcpul3 = float.Parse(cpul3);
            //    anspul = calcpul2 + calcpul3;
                
            //}

            string eq2 = textBox1.Text;
            char[] operators = { '/', '*', '+', '-' };

            while (true)
            {
                int pos = -1;
                char op = '\0';

                for (int j = 0; j < eq2.Length; j++)
                {
                    if (eq2[j] == '/' || eq2[j] == '*')
                    {
                        pos = j;
                        op = eq2[j];
                        break;
                    }
                    else if ((eq2[j] == '+' || eq2[j] == '-') && pos == -1)
                    {
                        pos = j;
                        op = eq2[j];
                    }
                }

                
                string left = "";
                int leftIndex = pos - 1;
                while (leftIndex >= 0)
                {
                    bool opr = false;
                    for (int k = 0; k < operators.Length; k++)
                    {
                        if (eq2[leftIndex] == operators[k])
                        {
                            opr = true;
                            break;
                        }
                    }
                    if (opr) break;
                    left = eq2[leftIndex] + left;
                    leftIndex--;
                }

                string right = "";
                int rightIndex = pos + 1;
                while (rightIndex < eq2.Length)
                {
                    bool opr = false;
                    for (int k = 0; k < operators.Length; k++)
                    {
                        if (eq2[rightIndex] == operators[k])
                        {
                            opr = true;
                            break;
                        }
                    }
                    if (opr) break;
                    right += eq2[rightIndex];
                    rightIndex++;
                }

                if (left == "" || right == "")
                {
                    break;
                }
                float leftNum = float.Parse(left);
                float rightNum = float.Parse(right);
                float result = 0;

                if (op == '/')
                {
                    result = leftNum / rightNum;
                    if(rightNum==0)
                    {
                        divizor = 1;
                        MessageBox.Show("can't divisible by zer0");
                        break; 
                    }
                }
                if (op == '*')
                {
                    result = leftNum * rightNum;
                }
                if (op == '+')
                {
                    result = leftNum + rightNum;
                }

                if (op == '-')
                {
                    result = leftNum - rightNum;
                }

                string newEq = "";
                for (int j = 0; j < eq2.Length; j++)
                {
                    if (j == leftIndex + 1)
                    {
                        newEq += result.ToString();
                        j = rightIndex - 1;
                    }
                    else
                    {
                        newEq += eq2[j];
                    }
                }

                eq2 = newEq;
            }

            //string item2 = listBox1.SelectedItem.ToString();
            //string item3 = listBox1.Text;
            if (divizor==1)
            {
                listBox1.Items.Remove(eq);

            }
            else
            {
                textBox1.Text = eq2;
                listBox1.Items.Add(eq);
            }


            //tmul3 = float.Parse(cmul3);

            //ansDM=ansdiv * float.Parse(cmul3);
            //ansDMP = ansDM + float.Parse(cpul2);
            //ansDMPM = ansDMP - float.Parse(cmin3);
            //textBox1.Text = ansDMPM.ToString();
            //listBox1.Items.Add(ansDMPM);

        }



        //    for (int b = posl + 1; b <= textBox1.Text.Length - 1; b++)
        //    {
        //        if (textBox1.Text[b] == '/' || textBox1.Text[b] == '*' || textBox1.Text[b] == '-' || textBox1.Text[b] == '+')
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            tany += text[b];
        //        }
        //    }
        //        for (int s = 0; s <= textBox1.Text.Length - 1; s++)
        //        {
        //        if (textBox1.Text[s] == '-')
        //        {

        //            if (ctmin == 0)
        //            {
        //                // posi = m;   

        //                if (textBox1.Text[s] == '/' || textBox1.Text[s] == '+' || textBox1.Text[s] == '*')
        //                {
        //                    ctmin = 1;
        //                    break;

        //                }
        //                else
        //                {
        //                    tmin2 += text[s+1];
        //                }

        //            }
        //            if (ctmin == 1)
        //            {
        //                break;
        //            }

        //        }
        //        if (textBox1.Text[s] == '/')
        //        {

        //            if (ctdiv == 0)
        //            {
        //                // posi = m;   

        //                if (textBox1.Text[s] == '-' || textBox1.Text[s] == '+' || textBox1.Text[s] == '*')
        //                {
        //                    ctdiv = 1;
        //                    break;

        //                }
        //                else
        //                {
        //                    tdiv2 += text[s];
        //                }

        //            }
        //            if (ctdiv == 1)
        //            {
        //                break;
        //            }

        //        }
        //    }
        //}
                   
            //        if (textBox1.Text[s] == '-' )
            //        {
            //            //ctdiv = 1;
            //            break;
            //        }
            //        else
            //        {  // posdiv = l;
            //            tdiv2 += text[s];
            //        }
                
                
            //        if ( textBox1.Text[s] == '+' )
            //        {
            //            break;
            //        }
            //        else
            //        {  // posdiv = l;
            //            tmul2 += text[s];
            //        }
                
                
            //        if (textBox1.Text[s] == '*' )
            //        {
            //            break;
            //        }
            //        else
            //        {  // posdiv = l;
            //            tmin2 += text[s];
            //        }
               
            //        if (textBox1.Text[s] == '/')
            //        {
            //            break;
            //        }
            //        else
            //        {  // posdiv = l;
            //            tpul2 += text[s];
            //        }
                

            //}
        //    for (int a = 0; a < posl; a++)
        //    {
        //        if (textBox1.Text[a] == '/')
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            awl += text[a];
        //        }
        //    }

        //    for (int b = posl + 1; b <= textBox1.Text.Length - 1; b++)
        //    {
        //        if (textBox1.Text[b] == '/' || textBox1.Text[b] == '*' || textBox1.Text[b] == '-' || textBox1.Text[b] == '+')
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            tany += text[b];
        //        }
        //    }
          //  float n1 = float.Parse(awl);
          //  float n2 = float.Parse(tany);
          //  float answer = n1 / n2;
          //  answer2 = answer;
          //  // listBox1.Items.Add(textBox1.Text);


          //awl = "";
          //  tany = "";

         
            






        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            list.Add('.');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string tdel = "";
            for (int r = 0; r < textBox1.Text.Length; r++)
            {
                if (r == textBox1.Text.Length - 1)
                {


                }
                else
                {
                    tdel += textBox1.Text[r];
                }
            }
            textBox1.Text = tdel.ToString();

        }
    }
}