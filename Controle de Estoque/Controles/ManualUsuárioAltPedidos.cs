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
    public partial class ManualUsuárioAltPedidos : Form
    {
        public ManualUsuárioAltPedidos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRet_Click(object sender, EventArgs e)
        {
            lblRet.Visible = false;
            BackgroundImage = Properties.Resources.Manual_de_Usuário___Alterar_Pedidos_1;
            lblAv.Visible = true;
        }

        private void lblAv_Click(object sender, EventArgs e)
        {
            lblRet.Visible = true;
            BackgroundImage = Properties.Resources.Manual_de_Usuário___Alterar_Pedidos_3;
            lblAv.Visible = false;
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
