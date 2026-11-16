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
    public partial class frmAddCliente : Form
    {
        public frmAddCliente()
        {
            InitializeComponent();
        }

        private void frmAddCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddPedido_Click(object sender, EventArgs e)
        {
            clientesTableAdapter1.InsertCliente(txtNome.Texts, txtTelefone.Text);
            DialogResult Resultado = new DialogResult();
            Controles.mbAviso18 Mensagem = new Controles.mbAviso18();
            Resultado = Mensagem.ShowDialog();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private void ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_PedidosDataSet);

        }

        private void ClientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_PedidosDataSet);

        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ID_ClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
