using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa5
{
    public partial class frmCWID : Form
    {
        public frmCWID()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentalform myForm = new rentalform(txtCWID.Text);
            if(myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
        }
    }
}
