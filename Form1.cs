using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula63_Exercicio2.Servicos;

namespace Aula63_Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Quer realmente sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnCarro_Click(object sender, EventArgs e)
        {
            Telas.Carros telaCarros = new Telas.Carros();
            telaCarros.MdiParent = this;
            telaCarros.Show();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
