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
    public partial class Form1 : Form
    {
        const string _password = "360459";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        enterPassword:
            string password = Form2.Show("Пароль", "Введите пароль!");
            if (password == "")
            {
                this.Close();
            }
            if (password != _password && password != "")
            {
                MessageBox.Show("Неверный пароль.\nПопробуйте ещё раз!", "Пароль неверный", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto enterPassword;
            }
        }
    }
}
