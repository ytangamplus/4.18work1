using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._18work1
{
    public partial class Form1 : Form
    {
        PC mPC0;
        PC mPC1;
        public Form1()
        {
            InitializeComponent();
            this.mPC0 = new("ASUS ", "Black ", "WindowsOS ");
            this.mPC1 = new("Apple ", "Silver ", "MacOS ");
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (this.cmbItems.SelectedIndex == 0)
            {
                this.txtDisp.Text = this.mPC0.PowerOn();
            }
            if (this.cmbItems.SelectedIndex == 1)
            {
                this.txtDisp.Text = this.mPC1.PowerOn();
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (this.cmbItems.SelectedIndex == 0)
            {
                this.txtDisp.Text = this.mPC0.PowerOff();
            }
            if (this.cmbItems.SelectedIndex == 1)
            {
                this.txtDisp.Text = this.mPC1.PowerOff();
            }
        }
    }
}
