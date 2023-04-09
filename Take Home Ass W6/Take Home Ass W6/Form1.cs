using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_Ass_W6
{
    public partial class Form1 : Form
    {
        Form2 form2baru = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonenter_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(textBoxsize.Text) < 4 )
            {
                MessageBox.Show ("Input yang lebih besarr", "Blokk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2.size = Convert.ToInt32(textBoxsize.Text);
                form2baru.Show();
            }
        }
    }
}
