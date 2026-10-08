using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_label_Click(object sender, EventArgs e)
        {    //set the label
            label_display.Text = "Aisha Ali Kasim";

        }

        private void clearlabel_Click(object sender, EventArgs e)
        {
            //clear label
            label_display.Text = String.Empty;
            
        }

        private void closeform_Click(object sender, EventArgs e)
        {
            //Closing
            this.Close();
        }

        private void label_display_Click(object sender, EventArgs e)
        {

        }
    }
}
