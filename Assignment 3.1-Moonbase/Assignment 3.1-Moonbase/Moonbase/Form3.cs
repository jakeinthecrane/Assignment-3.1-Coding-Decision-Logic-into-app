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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Message box to let the user know where they currently are
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are currently here on the West Side of the Moon. Begin your dexotification session and relax.", "West", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
