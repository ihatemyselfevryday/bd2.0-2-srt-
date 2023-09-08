using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_type add_Form = new add_type();
            add_Form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            add_comp add_Form = new add_comp();
            add_Form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            add_comp_build add_Form = new add_comp_build();
            add_Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_manufacturer add_Form = new add_manufacturer();
            add_Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_order add_Form = new add_order();
            add_Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_customer add_Form = new add_customer();
            add_Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            add_build add_Form = new add_build();
            add_Form.Show();
        }
    }
}
