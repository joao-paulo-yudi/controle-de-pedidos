using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_Estoque.Controle_PedidosDataSetTableAdapters;

namespace Controle_de_Estoque.Forms
{
    public partial class frmPesquisarPedidos : Form
    {
        /*
        SqlConnection con = new SqlConnection("Data Source =jpID_SQLLogin_1;Initial Catalog=ControleDePedidos;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        */
        public frmPesquisarPedidos()
        {
            InitializeComponent();
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

        private void frmPesquisarPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.controle_PedidosDataSet.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter.Fill(this.controle_PedidosDataSet.Pedidos);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet1.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            //     this.pedidosTableAdapter.Fill(this.controle_PedidosDataSet1.Pedidos);
            // TODO: esta linha de código carrega dados na tabela 'controle_PedidosDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            //   this.usuariosTableAdapter.Fill(this.controle_PedidosDataSet.Usuarios);

        }

        private void UserTxt_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
            Classes.VariáveisGlobais.Tela = 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Classes.VariáveisGlobais.ID_Ped != 0)
            {
                DialogResult Resultado = new DialogResult();
                frmItensPedido objItensPed = new frmItensPedido();
                Resultado = objItensPed.ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso8 objAviso = new Controles.mbAviso8();
                Resultado = objAviso.ShowDialog();
            }
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int Filtro;
            bool ConvertePar1 = Int32.TryParse(txtPesquisar.Texts, out Filtro);

            if (txtPesquisar.Texts == "Pesquisar...")
            {
                pedidosBindingSource1.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: 1, 2, 3,...")
            {
                pedidosBindingSource1.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: 01/01/2022")
            {
                pedidosBindingSource1.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: 10,99")
            {
                pedidosBindingSource1.RemoveFilter();
            }
            else if (txtPesquisar.Texts == "Ex.: Pendente / Concluído")
            {
                pedidosBindingSource1.RemoveFilter();
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    pedidosBindingSource1.Filter = "ID_Ped = " + Filtro;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    pedidosBindingSource1.Filter = "ID_Cliente = " + Filtro;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    try
                    {
                        pedidosBindingSource1.Filter = "Data = '" + txtPesquisar.Texts + "'";
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
                        pedidosBindingSource1.Filter = "Preço = '" + txtPesquisar.Texts + "'";
                    }
                    catch(Exception)
                    {
                        SystemSounds.Exclamation.Play();
                        DialogResult Resultado = new DialogResult();
                        Controles.mbAviso10 Mensagem = new Controles.mbAviso10();
                        Resultado = Mensagem.ShowDialog();
                    }
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    pedidosBindingSource1.Filter = "Situação = '" + txtPesquisar.Texts + "'";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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

        private void pedidosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Cursor = Cursors.Hand;
        }

        private void btnItensPedido_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Cursor = Cursors.Hand;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = new DialogResult();
            Controles.mbRelatorio Mensagem = new Controles.mbRelatorio();
            Resultado = Mensagem.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                // Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Title = "Relatório";
                saveFileDialog1.Filter = "Text File | .txt";
                saveFileDialog1.FilterIndex = 0;
                saveFileDialog1.FileName = "Relatório_" + DateTime.Now.ToString("dd-MM-yyyy");
                saveFileDialog1.DefaultExt = ".pdf";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.Write("ID            NOME                DATA                      PREÇO              SITUAÇÃO\r\n");
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            writer.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView1.Columns.Count - 1)
                            {
                                writer.Write("          ");
                            }
                        }
                        writer.WriteLine();
                    }
                    writer.Close();
                }
            }
        }
    }
}
