using System;
using System.Windows.Forms;

namespace ChopperChopper.Forms
{
    public partial class Form_Help : Form
    {
        public Form_Help()
        {
            InitializeComponent();
        }

        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
