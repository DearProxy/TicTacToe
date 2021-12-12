using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public bool againstComputer;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            varning_label.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_againstComputer.Checked)
            {
                varning_label.Visible = false;
                againstComputer = true;
                Form form = new Form1(againstComputer);
                this.Hide();
                form.Show();
            }
            else if (rb_1x1.Checked)
            {
                varning_label.Visible = false;
                againstComputer = false;
                Form form = new Form1(againstComputer);
                this.Hide();
                form.Show();
            }
            else
                varning_label.Visible = true;
        }

    }
}
