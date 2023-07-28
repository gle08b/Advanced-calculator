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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string windowsTitle, string message)
        {
            InitializeComponent();
            this.Text = windowsTitle;
            lbl2.Text = message;
            this.ActiveControl = txtPassword;
        }
        private void btn4_Click(object sender, EventArgs e)
        {


        }
        public static string Show(string windowsTitle, string message)
        {
            using (Form2 inputDlg = new Form2(windowsTitle, message))
            {
                    inputDlg.ShowDialog();
                    return inputDlg.txtPassword.Text;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        { }
        private void Form2_Keydown(object sender, KeyEventArgs e)
        { 
        if (e.KeyCode == Keys.Enter)
        {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        }

        private void Form2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
