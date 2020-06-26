using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.mode = 1;
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.mode = 2;
            Form1 frm = new Form1();
            this.Close();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm;
            Form1.mode = 3;
            frm = new Form1();
            this.Close();
            frm.Show();

        }
    }
}
