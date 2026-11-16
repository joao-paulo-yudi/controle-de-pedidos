using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.Forms
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            frmPesquisarPedidos objPPed = new frmPesquisarPedidos();
            objPPed.TopLevel = false;
            panel1.Controls.Add(objPPed);
            objPPed.Show();
            objPPed.BringToFront();
            Classes.VariáveisGlobais.Tela = 3;
        }

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Cursor = Cursors.Hand;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Cursor = Cursors.Hand;
        }

        private void btnAlt_MouseEnter(object sender, EventArgs e)
        {
            btnAlt.Cursor = Cursors.Hand;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPedidos objAddPed = new frmAddPedidos();
            objAddPed.TopLevel = false;
            panel1.Controls.Add(objAddPed);
            objAddPed.Show();
            objAddPed.BringToFront();
            Classes.VariáveisGlobais.Tela = 4;
            pedidosTableAdapter1.InsertNovoPed();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            frmAltPedidos objAltPed = new frmAltPedidos();
            objAltPed.TopLevel = false;
            panel1.Controls.Add(objAltPed);
            objAltPed.Show();
            objAltPed.BringToFront();
            Classes.VariáveisGlobais.Tela = 5;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmAddCliente objCliente = new frmAddCliente();
            objCliente.TopLevel = false;
            panel1.Controls.Add(objCliente);
            objCliente.Show();
            objCliente. BringToFront();
            Classes.VariáveisGlobais.Tela = 6;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
