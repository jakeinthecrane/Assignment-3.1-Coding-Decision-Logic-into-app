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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        
        //Message box to let the user know where they currently are
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are currently here on the East Side of the Moon. Take a few easy breaths and gently heal.", "East", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
            private void button2_Click(object sender, EventArgs e)
            {
            Form3 form3 = new Form3();
            form3.Show();
            }

            private void button4_Click(object sender, EventArgs e)
            {
             Form5 form5 = new Form5();
             form5.Show();
            }
        }
    }

