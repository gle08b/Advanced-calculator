using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private bool isNumber = false;
        private double numFirst, numSecond, numRes;
        int currentTextBox = 0;
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
            || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
            || e.KeyCode == Keys.Back;
        }

        private void btnNum1_Click(object sender, EventArgs e)//кнопка 7
        {
                if(currentTextBox == 1)
                {
                    txtCalc.Text += "7";
                }
                else if (currentTextBox == 2)
                {
                    txtCalc2.Text += "7";
                }
                else
                {
                return;
                }
        }

        private void btmNum2_Click(object sender, EventArgs e)//кнопка 8
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "8";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "8";
            }
            else
            {
                return;
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)//кнопка 9
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "9";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "9";
            }
            else
            {
                return;
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)//кнопка 4
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "4";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "4";
            }
            else
            {
                return;
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)//кнопка 5
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "5";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "5";
            }
            else
            {
                return;
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)//кнопка 6
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "6";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "6";
            }
            else
            {
                return;
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)//кнопка 1
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "1";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "1";
            }
            else
            {
                return;
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)//кнопка 2
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "2";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "2";
            }
            else
            {
                return;
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)//кнопка 3
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "3";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "3";
            }
            else
            {
                return;
            }
        }

        private void btnNum10_Click(object sender, EventArgs e)//кнопка 0
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += "0";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += "0";
            }
            else
            {
                return;
            }
        }

        private void btn_Click(object sender, EventArgs e)//кнопка равно
        {
            lblResult.Text = Convert.ToString(numRes);
        }

        private void txtCalc_Click(object sender, EventArgs e)
        {
            currentTextBox = 1;
        }

        private void txtCalc2_Click(object sender, EventArgs e)
        {
            currentTextBox = 2;
        }

        private void btnHard4_Click(object sender, EventArgs e)//косинус
        {
            string strNumber = string.Copy(txtCalc.Text);
            double radian = Convert.ToDouble(strNumber);
            radian *= Math.PI / 180;
            lblResult.Text = Convert.ToString(Math.Cos(radian));
        }

        private void btnHard3_Click(object sender, EventArgs e)
        {
            string strNumber = string.Copy(txtCalc.Text);
            double radian = Convert.ToDouble(strNumber);
            radian *= Math.PI / 180;
            lblResult.Text = Convert.ToString(Math.Sin(radian));
        }

        private void btnHard5_Click(object sender, EventArgs e)
        {
            string strNumber = string.Copy(txtCalc.Text);
            double radian = Convert.ToDouble(strNumber);
            radian *= Math.PI / 180;
            lblResult.Text = Convert.ToString(Math.Tan(radian));
        }

        private void btnHard6_Click(object sender, EventArgs e)
        {
            string strNumber = string.Copy(txtCalc.Text);
            double res = Convert.ToDouble(strNumber) / 100;
            lblResult.Text = Convert.ToString(res);
        }
        private void btnHard14_Click(object sender, EventArgs e)
        {
            if (currentTextBox == 1)
            {
                txtCalc.Text += ",";
            }
            else if (currentTextBox == 2)
            {
                txtCalc2.Text += ",";
            }
            else
            {
                return;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "";
            txtCalc2.Text = "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "";
            txtCalc2.Text = "";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "";
            txtCalc2.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtCalc.Text);
            string strSecond = string.Copy(txtCalc2.Text);
            if (txtCalc.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);
            }
            else
            {
                numFirst = 0;
            }

            if (txtCalc2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }

            numRes = numFirst + numSecond;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtCalc.Text);
            string strSecond = string.Copy(txtCalc2.Text);
            if (txtCalc.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);
            }
            else
            {
                numFirst = 0;
            }

            if (txtCalc2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }

            numRes = numFirst - numSecond;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtCalc.Text);
            string strSecond = string.Copy(txtCalc2.Text);
            if (txtCalc.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);
            }
            else
            {
                numFirst = 0;
            }

            if (txtCalc2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }

            numRes = numFirst * numSecond;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtCalc.Text);
            string strSecond = string.Copy(txtCalc2.Text);
            if (txtCalc.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);
            }
            else
            {
                numFirst = 0;
            }

            if (txtCalc2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }
            bool divideFlag = false;
            if (Math.Abs(numSecond) < 1.0E-30)
            {
                MessageBox.Show("Делить на ноль нельзя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                numRes = numFirst / numSecond;
                lblResult.Text = numRes.ToString();
            }
        }

       

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                    {
                        isNumber = true;
                    }
                    break;
                case '.':
                case ',':
                    if (box.Text.Length == 0)
                    {
                        isNumber = false;
                        break;

                    }
                    if ((box.Text[0] != '-' && box.Text.Length == 1 && !(box.Text.Contains(',') || box.Text.Contains('.'))) || (box.Text.Length == 2 && !(box.Text.Contains(',') || box.Text.Contains('.'))))
                    {
                        isNumber = true;
                        break;
                    }
                    break;
                case '@':
                case '!':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '"':
                case '№':
                case ';':
                case ':':
                case '?':
                    isNumber = false;
                    break;
            }

            if (!isNumber)
            {
                e.Handled = true;
            }

        }


        private void btn_Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
