using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.Forms
{
    public partial class frmUsuário : Form
    {
        public frmUsuário()
        {
            InitializeComponent();
            if (Properties.Settings.Default.NivelUsuarioLogado == 1)
            {
                lblNivel.Text = "Administrador";
            }
            else
            {
                lblNivel.Text = "Usuário";
            }
            lblNome.Text = Properties.Settings.Default.NomeUsuarioLogado;
            lblEmail.Text = Properties.Settings.Default.EmailUsuarioLogado;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnGerenciar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnGerenciar_MouseEnter(object sender, EventArgs e)
        {
            btnGerenciar.Cursor = Cursors.Hand;
        }
    }
}
