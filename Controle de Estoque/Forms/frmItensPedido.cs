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
    public partial class frmItensPedido : Form
    {
        public frmItensPedido()
        {
            InitializeComponent();

            frmPesquisarPedidos objPPedidos = new frmPesquisarPedidos();
        }

        private void frmItensPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Itens_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, Classes.VariáveisGlobais.ID_Ped);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Itens_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            //      this.itens_PedidoTableAdapter.Fill(this.controle_PedidosDataSet.Itens_Pedido);

        }

        private void selectItensPedidoIDToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void selectItensPedidoIDToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iD_PedToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void selectItemIDToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void selectItemID1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, ((int)(System.Convert.ChangeType(iD_PedToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
