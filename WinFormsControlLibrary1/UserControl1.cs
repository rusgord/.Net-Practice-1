using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibrary1
{
    [ToolboxBitmap(@"C:\Users\shkverz\source\repos\Lab1\WinFormsControlLibrary1\MyIcon.ico")]
    public partial class UserControl1 : UserControl
    {
        private string customProperty;
        public UserControl1()
        {
            InitializeComponent();
        }
        public string CustomProperty
        {
            get { return customProperty; }
            set
            {
                customProperty = value;
                textBox1.PlaceholderText = customProperty;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (!char.IsControl(e.KeyChar))
            {
                string text = textBox1.Text + e.KeyChar;
                int number;
                if (!int.TryParse(text, out number))
                {
                    e.Handled = true;
                    return;
                }
                if (number > trackBar1.Maximum)
                    e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                trackBar1.Value = int.Parse(textBox1.Text);
            else trackBar1.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }
    }
}
