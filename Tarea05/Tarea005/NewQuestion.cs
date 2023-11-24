using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tarea005.Class;

namespace Tarea005
{
    public partial class NewQuestion : Form
    {
        private Question data;
        public NewQuestion(Question questionObj)
        {
            data = questionObj;
            InitializeComponent();

            txtHeader.Text = data.header;
            txtHeader.Tag = data.header;
            textBox2.Text = data.ans1;
            textBox3.Text = data.ans2;
            textBox4.Text = data.ans3;
            textBox5.Text = data.ans4;
        }

        private void focusLeave(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if(con.Text.Length == 0)
            {
                con.Text = (string)con.Tag;
                return;
            }
        }

        private void focus(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if(con.Text == con.Tag.ToString())
                con.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if (con.Text.Length != 0 && con.Text != con.Tag.ToString() && !con.Text.Contains(";"))
            {
                data.ans1 = con.Text;
            }
            Console.WriteLine(data.ans1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if (con.Text.Length != 0 && con.Text != con.Tag.ToString() && !con.Text.Contains(";"))
            {
                data.ans2 = con.Text;
            }
            Console.WriteLine(data.ans2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if (con.Text.Length != 0 && con.Text != con.Tag.ToString() && !con.Text.Contains(";"))
            {
                data.ans3 = con.Text;
            }
            Console.WriteLine(data.ans3);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if (con.Text.Length != 0 && con.Text != con.Tag.ToString() && !con.Text.Contains(";"))
            {
                data.ans4 = con.Text;
            }
            Console.WriteLine(data.ans4);
        }

        private void txtHeader_TextChanged(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            if (con.Text.Length != 0 && con.Text != con.Tag.ToString() && !con.Text.Contains(";"))
            {
                data.header = con.Text;
            }
            Console.WriteLine(data.header);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                data.answer = data.ans1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                data.answer = data.ans2;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                data.answer = data.ans3;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                data.answer = data.ans4;
            }
        }
    }
}
