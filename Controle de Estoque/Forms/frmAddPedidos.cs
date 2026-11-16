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
    public partial class frmAddPedidos : Form
    {
        public int Quantidade;
        public int ID_Prod;
        int ID_Item = 0;

        public frmAddPedidos()
        {
            InitializeComponent();
        }

        private void frmAddPedidos_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.controle_PedidosDataSet1.Produtos);
            int NovoID = Convert.ToInt32(pedidosTableAdapter1.UltID()) + 1;

            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Itens_Temp'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_TempTableAdapter.Fill(this.controle_PedidosDataSet.Itens_Temp);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.controle_PedidosDataSet.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Itens_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_PedidoTableAdapter.SelectItemID1(this.controle_PedidosDataSet.Itens_Pedido, NovoID);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.controle_PedidosDataSet.Clientes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void selectItemIDToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
            Classes.VariáveisGlobais.Tela = 2;
            pedidosTableAdapter1.RemoverPedido(Convert.ToInt32(pedidosTableAdapter1.UltID()));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = new DialogResult();
            Controles.mbConcluirPed Mensagem = new Controles.mbConcluirPed();
            Resultado = Mensagem.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                try
                {
                    object UltID = pedidosTableAdapter1.UltID();
                    object Soma = itens_TempTableAdapter.SomaItensTemp();
                    object ID_Cliente = clientesTableAdapter.SelectClienteNome(comboBox1.Text);
                    pedidosTableAdapter1.UpdatePedido(Convert.ToInt32(ID_Cliente), Convert.ToDecimal(Soma), comboBox1.Text, Convert.ToInt32(UltID));
                    pedidosTableAdapter1.UpdateDataPed(dateTimePicker1.Text, Convert.ToInt32(UltID));
                    itens_PedidoTableAdapter.InsertItens();
                    DialogResult Resultado1 = new DialogResult();
                    Controles.mbAviso16 Mensagem1 = new Controles.mbAviso16();
                    Resultado1 = Mensagem1.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    DialogResult Resultado2 = new DialogResult();
                    Controles.mbAviso20 Mensagem2 = new Controles.mbAviso20();
                    Resultado2 = Mensagem2.ShowDialog();
                }
            }
        }

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Cursor = Cursors.Hand;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Cursor = Cursors.Hand;
        }

        private void btnRemover_MouseEnter(object sender, EventArgs e)
        {
            btnRemover.Cursor = Cursors.Hand;
        }

        private void btnAddPedido_MouseEnter(object sender, EventArgs e)
        {
            btnAddPedido.Cursor = Cursors.Hand;
        }

        private void txtPesquisar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_MouseLeave(object sender, EventArgs e)
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

        private void selectItemID1ToolStripButton_Click_1(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool Continuar;
            /* if (txtPesquisar1.Text == "Digitar ID do produto...")
             {
                 SystemSounds.Exclamation.Play();
                 DialogResult Resultado = new DialogResult();
                 Controles.mbAviso15 Mensagem = new Controles.mbAviso15();
                 Resultado = Mensagem.ShowDialog();
             }
             else
            */
            if (comboBox3.Text == "")
            {
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso19 Mensagem = new Controles.mbAviso19();
                Resultado = Mensagem.ShowDialog();
            }
            else
            {
                if (lblTipo.Text == "")
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbAviso15 Mensagem = new Controles.mbAviso15();
                    Resultado = Mensagem.ShowDialog();
                }
                else
                {
                    try
                    {
                        ID_Prod = Convert.ToInt32(produtosTableAdapter.SelectIdByNome(comboBox2.Text));
                        Continuar = true;
                    }
                    catch (Exception)
                    {
                        SystemSounds.Exclamation.Play();
                        DialogResult Resultado = new DialogResult();
                        Controles.mbAviso11 Mensagem = new Controles.mbAviso11();
                        Resultado = Mensagem.ShowDialog();
                        Continuar = false;
                    }

                    if (Continuar == true)
                    {
                        try
                        {
                            Quantidade = Convert.ToInt32(txtQuantidade.Texts);
                            Continuar = true;
                        }
                        catch (Exception)
                        {
                            SystemSounds.Exclamation.Play();
                            DialogResult Resultado = new DialogResult();
                            Controles.mbAviso13 Mensagem = new Controles.mbAviso13();
                            Resultado = Mensagem.ShowDialog();
                            Continuar = false;
                        }
                    }
                    if (Continuar == true)
                    {
                        try
                        {
                            object ID_Ped1 = pedidosTableAdapter1.UltID();
                            itens_TempTableAdapter.InsertItensTemp(Convert.ToInt32(ID_Ped1), ID_Prod, Quantidade, Quantidade * Convert.ToDecimal(lblPreço.Text), lblTipo.Text, lblMarca.Text, comboBox3.Text, Convert.ToDecimal(lblPreço.Text));
                            this.itens_TempTableAdapter.Fill(this.controle_PedidosDataSet.Itens_Temp);
                        }
                        catch (Exception)
                        {
                            SystemSounds.Exclamation.Play();
                            DialogResult Resultado = new DialogResult();
                            Controles.mbAviso12 Mensagem = new Controles.mbAviso12();
                            Resultado = Mensagem.ShowDialog();
                        }
                        lblTipo.Text = "";
                        lblMarca.Text = "";
                        lblPreço.Text = "";
                        txtQuantidade.Texts = "";
                    }
                }
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtQuantidade.Texts = "";
            /* if (txtPesquisar1.Text == "Digitar ID do produto...")
            {
                lblTipo.Text = "";
                lblMarca.Text = "";
                lblTamanho.Text = "";
                lblPreço.Text = "";
            }*/
           // else
            
                try
                {
                    Controle_PedidosDataSet.ProdutosDataTable dtProdutos;
                    dtProdutos = produtosTableAdapter.SelectNomeByNome(comboBox2.Text);
                    if (dtProdutos.Rows.Count == 0)
                    {
                        SystemSounds.Exclamation.Play();
                        DialogResult Resultado = new DialogResult();
                        Controles.mbAviso11 Mensagem = new Controles.mbAviso11();
                        Resultado = Mensagem.ShowDialog();
                    }
                    else
                    {                   
                        lblTipo.Text = Convert.ToString(produtosTableAdapter.SelectTipoByNome1(comboBox2.Text));
                        lblMarca.Text = Convert.ToString(produtosTableAdapter.SelectMarcaByNome(comboBox2.Text));
                        lblPreço.Text = Convert.ToString(produtosTableAdapter.SelectPreçoByNome(comboBox2.Text)); 
                    }
                }
                catch (Exception)
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbAviso11 Mensagem = new Controles.mbAviso11();
                    Resultado = Mensagem.ShowDialog();
                }
            
        }

        private void frmAddPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            itens_TempTableAdapter.DeleteItens();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (ID_Item == 0)
            {

            }
            else
            {
                itens_TempTableAdapter.DeleteItenID(ID_Item);
                this.itens_TempTableAdapter.Fill(this.controle_PedidosDataSet.Itens_Temp);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow Row1 = dataGridView1.Rows[e.RowIndex];
                ID_Item = Convert.ToInt32(Row1.Cells[0].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

        private void txtPesquisar1_TextChanged(object sender, EventArgs e)
        {
            lblTipo.Text = "";
            lblMarca.Text = "";
            lblPreço.Text = "";
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtosTableAdapter.Fill(this.controle_PedidosDataSet.Produtos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
