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
    public partial class uiExibicaoRelatorio : Form
    {
        public uiExibicaoRelatorio()
        {
            InitializeComponent();
        }

        public uiExibicaoRelatorio(String relatorio)
        {
            InitializeComponent();
            this.txtRelatorio.Text = relatorio;
        }
    }
}
