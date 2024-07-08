using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        //Opens form 3, the WSOTM
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        //Opens form 4, the ESOTM
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        //Opens form 5, the SSOTM
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        //Message box to let the user know where they currently are
        private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("You are currently here on the North Side of the Moon. Relax, make yourself at home.", "North", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }