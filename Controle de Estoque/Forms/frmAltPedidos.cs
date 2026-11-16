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
    public partial class frmAltPedidos : Form
    {
        public frmAltPedidos()
        {
            InitializeComponent();
        }

        private void frmAltPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter.Fill(this.controle_PedidosDataSet.Pedidos);

        }

        private void btnItensPedido_MouseEnter(object sender, EventArgs e)
        {
            btnItensPedido.Cursor = Cursors.Hand;
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

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Cursor = Cursors.Hand;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
            Classes.VariáveisGlobais.Tela = 2;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int Filtro;
            bool ConvertePar1 = Int32.TryParse(txtPesquisar.Texts, out Filtro);

            if (txtPesquisar.Texts == "Pesquisar...")
            {
                pedidosBindingSource.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: 1, 2, 3,...")
            {
                pedidosBindingSource.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: 01/01/2022")
            {
                pedidosBindingSource.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: 10,99")
            {
                pedidosBindingSource.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: Pendente / Concluído")
            {
                pedidosBindingSource.RemoveFilter();
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    pedidosBindingSource.Filter = "ID_Ped = " + Filtro;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    pedidosBindingSource.Filter = "ID_Cliente = " + Filtro;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    try
                    {
                        pedidosBindingSource.Filter = "Data = '" + txtPesquisar.Texts + "'";
                    }
                    catch (Exception)
                    {
                        SystemSounds.Exclamation.Play();
                        DialogResult Resultado = new DialogResult();
                        Controles.mbAviso9 Mensagem = new Controles.mbAviso9();
                        Resultado = Mensagem.ShowDialog();
                    }
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    try
                    {
                        pedidosBindingSource.Filter = "Preço = '" + txtPesquisar.Texts + "'";
                    }
                    catch (Exception)
                    {
                        SystemSounds.Exclamation.Play();
                        DialogResult Resultado = new DialogResult();
                        Controles.mbAviso10 Mensagem = new Controles.mbAviso10();
                        Resultado = Mensagem.ShowDialog();
                    }
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    pedidosBindingSource.Filter = "Situação = '" + txtPesquisar.Texts + "'";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisar.ForeColor = Color.DimGray;
            if (comboBox1.SelectedIndex == 0)
            {
                txtPesquisar.Texts = "Ex.: 1, 2, 3,...";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                txtPesquisar.Texts = "Ex.: 1, 2, 3,...";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                txtPesquisar.Texts = "Ex.: 01/01/2022";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                txtPesquisar.Texts = "Ex.: 10,99";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                txtPesquisar.Texts = "Ex.: Pendente / Concluído";
            }
        }

        private void txtPesquisar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.ForeColor = Color.Black;
            if (txtPesquisar.Texts == "Pesquisar...")
            {
                txtPesquisar.Texts = "";
            }
            if (txtPesquisar.Texts == "Ex.: 1, 2, 3,...")
            {
                txtPesquisar.Texts = "";
            }
            if (txtPesquisar.Texts == "Ex.: 01/01/2022")
            {
                txtPesquisar.Texts = "";
            }
            if (txtPesquisar.Texts == "Ex.: 10,99")
            {
                txtPesquisar.Texts = "";
            }
            if (txtPesquisar.Texts == "Ex.: Pendente / Concluído")
            {
                txtPesquisar.Texts = "";
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.Texts == "")
            {
                txtPesquisar.ForeColor = Color.DimGray;
                txtPesquisar.Texts = "Pesquisar...";
                if (comboBox1.SelectedIndex == 0)
                {
                    txtPesquisar.Texts = "Ex.: 1, 2, 3,...";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    txtPesquisar.Texts = "Ex.: 1, 2, 3,...";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    txtPesquisar.Texts = "Ex.: 01/01/2022";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    txtPesquisar.Texts = "Ex.: 10,99";
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    txtPesquisar.Texts = "Ex.: Pendente / Concluído";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = new DialogResult();
            Controles.mbConcluirPed Mensagem = new Controles.mbConcluirPed();
            Resultado = Mensagem.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                pedidosTableAdapter.ConcluirPedido(Classes.VariáveisGlobais.ID_Ped);
                this.pedidosTableAdapter.Fill(this.controle_PedidosDataSet.Pedidos);
            }
        }

        private void btnItensPedido_Click(object sender, EventArgs e)
        {
            if (Classes.VariáveisGlobais.ID_Ped != 0)
            {
                DialogResult Resultado = new DialogResult();
                frmAltItensPed objItensPed = new frmAltItensPed();
                Resultado = objItensPed.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    pedidosTableAdapter.UpdatePreçoPed(itens_PedidoTableAdapter1.SomaItens(Classes.VariáveisGlobais.ID_Ped), Classes.VariáveisGlobais.ID_Ped);
                    this.pedidosTableAdapter.Fill(this.controle_PedidosDataSet.Pedidos);
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso8 objAviso = new Controles.mbAviso8();
                Resultado = objAviso.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow Row1 = dataGridView1.Rows[e.RowIndex];
                Classes.VariáveisGlobais.ID_Ped = Convert.ToInt32(Row1.Cells[0].Value.ToString());
            }
            catch (System.Exception)
            {

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = new DialogResult();
            Controles.mbExcluirPed Mensagem = new Controles.mbExcluirPed();
            Resultado = Mensagem.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                pedidosTableAdapter.RemoverPedido(Classes.VariáveisGlobais.ID_Ped);
                this.pedidosTableAdapter.Fill(this.controle_PedidosDataSet.Pedidos);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAltPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
