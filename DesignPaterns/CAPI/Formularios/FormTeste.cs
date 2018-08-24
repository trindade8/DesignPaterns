using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPaterns.Formularios
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }



        public void ChecaGroupBox(GroupBox box)
        {
            foreach (RadioButton rb in box.Controls)
            {
                if(rb.Checked)
                    MessageBox.Show(rb.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.ChecaGroupBox(this.groupBox1);
        }
    }
}
