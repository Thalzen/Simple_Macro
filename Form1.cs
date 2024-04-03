using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Macro
{
    public partial class Form1 : Form
    {
        InputSimulator _InputSimulator = new InputSimulator() { };

        bool _macrobool = false;
        int _IntervalA1 = 1000, _IntervalA2 = 1000, _IntervalB1 = 1000, _IntervalB2 = 1000, _IntervalC1 = 1000, _IntervalC2 = 1000, _IntervalD1 = 1000, _IntervalD2 = 1000, _value1 = 1000, _value2 = 1000;
        string CurrentChar;
        VirtualKeyCode CurrentVK1;
        VirtualKeyCode CurrentVK2;
        VirtualKeyCode CurrentVK3;
        VirtualKeyCode CurrentVK4;
        List<object> Checkboxlist = new List<object>();
        List<VirtualKeyCode> VKlist = new List<VirtualKeyCode>();

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox2.Size = new Size(262, 10);
            pictureBox2.Location = new Point(27, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartSpam();

        }

        private void StartSpam()
        {
            if (checkedListBox1 == null)
                checkedListBox1.Items.Cast<object>().ToList();

            if (_macrobool == false)
            {
                _macrobool = true;
                label5.Text = "ON";
                label5.ForeColor = Color.Green;
            }

            else
            {
                _macrobool = false;
                label5.Text = "OFF";
                label5.ForeColor = Color.Red;
            }


           

            if(textBox1.Text != string.Empty)
                CurrentVK1 = ConvertCharToVk(textBox1.Text);
                VKlist.Add(CurrentVK1);
            if (textBox2.Text != string.Empty)
                CurrentVK2 = ConvertCharToVk(textBox2.Text);
                VKlist.Add(CurrentVK2);
            if (textBox3.Text != string.Empty)
                CurrentVK3 = ConvertCharToVk(textBox3.Text);
                VKlist.Add(CurrentVK3);
            if (textBox4.Text != string.Empty)
                CurrentVK4 = ConvertCharToVk(textBox4.Text);
                VKlist.Add(CurrentVK4);


            //Spam macro
            SpamMacro(CurrentVK1,_IntervalA1,_IntervalA2);
            SpamMacro(CurrentVK2,_IntervalB1,_IntervalB2);
            SpamMacro(CurrentVK3,_IntervalC1,_IntervalC2);
            SpamMacro(CurrentVK4,_IntervalD1,_IntervalD2);


        }

        private VirtualKeyCode ConvertCharToVk(string key)
        {

            switch (key)
            {

                case "A":
                    return VirtualKeyCode.VK_A;
                case "B":
                    return VirtualKeyCode.VK_B;
                case "C":
                    return VirtualKeyCode.VK_C;
                case "D":
                    return VirtualKeyCode.VK_D;
                case "E":
                    return VirtualKeyCode.VK_E;
                case "F":
                    return VirtualKeyCode.VK_F;
                case "G":
                    return VirtualKeyCode.VK_G;
                case "H":
                    return VirtualKeyCode.VK_H;
                case "I":
                    return VirtualKeyCode.VK_I;
                case "J":
                    return VirtualKeyCode.VK_J;
                case "K":
                    return VirtualKeyCode.VK_K;
                case "L":
                    return VirtualKeyCode.VK_L;
                case "M":
                    return VirtualKeyCode.VK_M;
                case "N":
                    return VirtualKeyCode.VK_N;
                case "O":
                    return VirtualKeyCode.VK_O;
                case "P":
                    return VirtualKeyCode.VK_P;
                case "Q":
                    return VirtualKeyCode.VK_Q;
                case "R":
                    return VirtualKeyCode.VK_R;
                case "S":
                    return VirtualKeyCode.VK_S;
                case "T":
                    return VirtualKeyCode.VK_T;
                case "U":
                    return VirtualKeyCode.VK_U;
                case "V":
                    return VirtualKeyCode.VK_V;
                case "W":
                    return VirtualKeyCode.VK_W;
                case "X":
                    return VirtualKeyCode.VK_X;
                case "Y":
                    return VirtualKeyCode.VK_Y;
                case "Z":
                    return VirtualKeyCode.VK_Z;

                default: return VirtualKeyCode.VK_A;    
                
            }
        }

        #region MouseClickOnBox
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
            pictureBox1.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox2.Size = new Size(262, 10);
            pictureBox2.Location = new Point(27,101);
            numericUpDown1.Value = _IntervalA1;
            numericUpDown2.Value = _IntervalA2;
        }
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox1.Visible = false;
            pictureBox5.Visible = true;
            pictureBox2.Size = new Size(220, 10);
            pictureBox2.Location = new Point(69, 101);
            numericUpDown1.Value = _IntervalB1;
            numericUpDown2.Value = _IntervalB2;
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
        }
        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox2.Size = new Size(180, 10);
            pictureBox2.Location = new Point(109, 101);
            numericUpDown1.Value = _IntervalC1;
            numericUpDown2.Value = _IntervalC2;
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = null;
        }
        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox2.Size = new Size(138, 10);
            pictureBox2.Location = new Point(151, 101);
            numericUpDown1.Value = _IntervalD1;
            numericUpDown2.Value = _IntervalD2;
        }

        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = null;
        }
        #endregion
        #region TextChanged
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
                //this.ActiveControl = null;
                label1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 0)
                //this.ActiveControl = null;
                label1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0)
                //this.ActiveControl = null;
                label1.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength != 0)
                //this.ActiveControl = null;
                label1.Focus();
        }
        #endregion
        #region DelayBoxValue
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _value1 = (int)numericUpDown1.Value;
            CurrentBox1();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _value2 = (int)numericUpDown2.Value;
            CurrentBox2();
        }
        #endregion
        #region DelayBoxAttribution
        private void CurrentBox1()
        {
            if (pictureBox1.Visible)
                _IntervalA1 = _value1;
            else if (pictureBox5.Visible)
                _IntervalB1 = _value1;
            else if (pictureBox6.Visible)
                _IntervalC1 = _value1;
            else if (pictureBox7.Visible)
                _IntervalD1 = _value1;
        }
        private void CurrentBox2()
        {
            if (pictureBox1.Visible)
                _IntervalA2 = _value2;
            else if (pictureBox5.Visible)
                _IntervalB2 = _value2;
            else if (pictureBox6.Visible)
                _IntervalC2 = _value2;
            else if (pictureBox7.Visible)
                _IntervalD2 = _value2;
        }
        #endregion

        private async void SpamMacro(VirtualKeyCode keycode, int value1, int value2)
        {
            while (_macrobool == true)
            {
                _InputSimulator.Keyboard.KeyPress(keycode);
                await Task.Delay(new Random().Next(value1, value2 + 1));

            }



        }
    }

}
