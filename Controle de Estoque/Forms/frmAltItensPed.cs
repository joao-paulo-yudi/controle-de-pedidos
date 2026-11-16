using System;
using System.Media;
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
    public partial class frmAltItensPed : Form
    {
        public frmAltItensPed()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void frmAltItensPed_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Itens_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, Classes.VariáveisGlobais.ID_Ped);
        }

        private void selectItemID1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, ((int)(System.Convert.ChangeType(iD_PedToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow Row1 = dataGridView1.Rows[e.RowIndex];
                Classes.VariáveisGlobais.ID_Item = Convert.ToInt32(Row1.Cells[0].Value.ToString());
            }
            catch (System.Exception)
            {

            }
        }

        private void btnRemover_MouseEnter(object sender, EventArgs e)
        {
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.Image = Properties.Resources.lata_de_lixo__2_;
        }

        private void btnRemover_MouseLeave(object sender, EventArgs e)
        {
            btnRemover.Image = Properties.Resources.lata_de_lixo__1_;
        }

        private void btnItensPedido_Click(object sender, EventArgs e)
        {
            if (Classes.VariáveisGlobais.ID_Item != 0)
            {
                DialogResult Resultado = new DialogResult();
                frmAltQuantItem objQuant = new frmAltQuantItem();
                Resultado = objQuant.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    object Preço_Item = produtosTableAdapter1.SelectPreço(Classes.VariáveisGlobais.ID_Item);
                    itens_PedidoTableAdapter.UpdatePreçoItens(Classes.VariáveisGlobais.QuantItem, Convert.ToDecimal(Preço_Item), Classes.VariáveisGlobais.ID_Ped, Classes.VariáveisGlobais.ID_Item);
                    this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, Classes.VariáveisGlobais.ID_Ped);
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso17 objAviso = new Controles.mbAviso17();
                Resultado = objAviso.ShowDialog();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = new DialogResult();
            Controles.mbExcluirItem Mensagem = new Controles.mbExcluirItem();
            Resultado = Mensagem.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                itens_PedidoTableAdapter.DeletarItem(Classes.VariáveisGlobais.ID_Ped, Classes.VariáveisGlobais.ID_Item);
                this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, Classes.VariáveisGlobais.ID_Ped);
            }
            decimal Soma = Convert.ToDecimal(itens_PedidoTableAdapter.SomaItens(Classes.VariáveisGlobais.ID_Ped));
            pedidosTableAdapter1.UpdatePreçoPed(Soma, Classes.VariáveisGlobais.ID_Ped);
        }

        private void frmAltItensPed_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
