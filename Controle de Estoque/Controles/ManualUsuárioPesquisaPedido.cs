using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.Controles
{
    public partial class ManualUsuárioPesquisaPedido : Form
    {
        public ManualUsuárioPesquisaPedido()
        {
            InitializeComponent();
        }

        int NTela = 0;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRet_Click(object sender, EventArgs e)
        {
            if (NTela == 1)
            {
                BackgroundImage = Properties.Resources.Manual_de_Usuário___Pesquisa_Pedidos;
                NTela = 0;
                lblRet.Visible = false;
            }
            else if (NTela == 2)
            {
                lblAv.Visible = true;
                BackgroundImage = Properties.Resources.Manual_de_Usuário___Pesquisa_Pedidos_2;
                NTela = 1;
            }
        }

        private void lblAv_Click(object sender, EventArgs e)
        {
            if (NTela == 0)
            {
                lblRet.Visible = true;
                BackgroundImage = Properties.Resources.Manual_de_Usuário___Pesquisa_Pedidos_2;
                NTela = 1;
            }
            else if (NTela == 1)
            {
                lblRet.Visible = true;
                BackgroundImage = Properties.Resources.Manual_de_Usuário___TCC_1_;
                NTela = 2;
                lblAv.Visible = false;
            }
        }

        private void lblRet_MouseEnter(object sender, EventArgs e)
        {
            lblRet.Cursor = Cursors.Hand;
            lblRet.Font = new Font("Segoe Ui", 37);
        }

        private void lblRet_MouseLeave(object sender, EventArgs e)
        {
            lblRet.Font = new Font("Segoe Ui", 36);
        }

        private void lblAv_Leave(object sender, EventArgs e)
        {

        }

        private void lblAv_MouseEnter(object sender, EventArgs e)
        {
            lblAv.Cursor = Cursors.Hand;
            lblAv.Font = new Font("Segoe Ui", 37);
        }

        private void lblAv_MouseLeave(object sender, EventArgs e)
        {
            lblAv.Font = new Font("Segoe Ui", 36);
        }
    }
}
