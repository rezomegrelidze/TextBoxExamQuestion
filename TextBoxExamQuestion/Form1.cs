using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxExamQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                if (number == 0)
                    label1.Text = "zero";
                else if (number > 0)
                    label1.Text = "positive";
                else
                    label1.Text = "negative";
            }
            else
            {
                label1.Text = "NaN";
            }
        }
    }
}
