using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macro
{
    public partial class TextBoxUc : UserControl
    {
        public TextBoxUc()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
                label1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.TextLength != 0)
                label1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0)
                label1.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength != 0)
                label1.Focus();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = null;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = null;
        }
    }
}
