using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsowsApp
{
    public partial class FormReceptek : Form
    {
        public FormReceptek()
        {
            InitializeComponent();
        }


        private void buttonReceptModositas_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl uCReceptModositas = new UCReceptModositas();
            panel1.Controls.Add(uCReceptModositas);
            uCReceptModositas.Dock = DockStyle.Fill;
        }

        private void buttonUjFogasFelvetele_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl uCUjFogas = new UCUjFogas();
            panel1.Controls.Add(uCUjFogas);
            uCUjFogas.Dock = DockStyle.Fill;
        }
    }
}
