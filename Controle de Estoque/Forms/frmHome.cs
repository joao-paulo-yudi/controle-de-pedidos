using System;
using System.Media;
using System.Runtime.InteropServices;
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
    public partial class frmHome : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmHome()
        {
            InitializeComponent();
        }

        public void ResetButtons()
        {
            picUser.Image = Properties.Resources.user;
            picHome.Image = Properties.Resources.home;
            picProd.Image = Properties.Resources.produtos__1_;
            picPed.Image = Properties.Resources.pedidos;
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ResetButtons();
            panel3.Controls.Clear();
            picPed.Image = Properties.Resources.pedidos__1_;
            frmPedidos objPedidos = new frmPedidos();
            objPedidos.TopLevel = false;
            panel3.Controls.Add(objPedidos);
            objPedidos.Show();
            panel3.BringToFront();
            Classes.VariáveisGlobais.Tela = 2;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = new DialogResult();
            Controles.mbSair Mensagem = new Controles.mbSair();
            Resultado = Mensagem.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                Form1 frmLogin = new Form1();
                this.Hide();
                frmLogin.Show();
            }
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Cursor = Cursors.Hand;
            picExit.Size = new Size(65, 65);
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Size = new Size(60, 60);
        }

        private void picUser_MouseEnter(object sender, EventArgs e)
        {
            picUser.Cursor = Cursors.Hand;
            picUser.Size = new Size(75, 75);
        }

        private void picUser_MouseLeave(object sender, EventArgs e)
        {
            picUser.Size = new Size(70, 70);
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            picHome.Cursor = Cursors.Hand;
            picHome.Size = new Size(75, 75);
        }

        private void picHome_MouseLeave(object sender, EventArgs e)
        {
            picHome.Size = new Size(70, 70);
        }

        private void picProd_MouseEnter(object sender, EventArgs e)
        {
            picProd.Cursor = Cursors.Hand;
            picProd.Size = new Size(75, 75);
        }

        private void picProd_MouseLeave(object sender, EventArgs e)
        {
            picProd.Size = new Size(70, 70);
        }

        private void picPed_MouseEnter(object sender, EventArgs e)
        {
            picPed.Cursor = Cursors.Hand;
            picPed.Size = new Size(75, 75);
        }

        private void picPed_MouseLeave(object sender, EventArgs e)
        {
            picPed.Size = new Size(70, 70);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            ResetButtons();
            picHome.Image = Properties.Resources.home__1_;
            panel3.SendToBack();
            panel3.Controls.Clear();
            Classes.VariáveisGlobais.Tela = 0;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void picProd_Click(object sender, EventArgs e)
        {
            ResetButtons();
            panel3.Controls.Clear();
            picProd.Image = Properties.Resources.produtos;
            frmProdutos objProdutos = new frmProdutos();
            objProdutos.TopLevel = false;
            panel3.Controls.Add(objProdutos);
            objProdutos.Show();
            panel3.BringToFront();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            ResetButtons();
            panel3.Controls.Clear();
            picUser.Image = Properties.Resources.user__1_;
            frmUsuário objUser = new frmUsuário();
            objUser.TopLevel = false;
            panel3.Controls.Add(objUser);
            objUser.Show();
            panel3.BringToFront();
            Classes.VariáveisGlobais.Tela = 1;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (Classes.VariáveisGlobais.Tela == 0)
            {
                Controles.ManualUsuárioHome objMUHome = new Controles.ManualUsuárioHome();
                objMUHome.Show();
            }
            if (Classes.VariáveisGlobais.Tela == 1)
            {
                Controles.ManualUsuárioUser objMUUser = new Controles.ManualUsuárioUser();
                objMUUser.Show();
            }
            if (Classes.VariáveisGlobais.Tela == 2)
            {
                Controles.ManualUsuárioPedido objMUPed = new Controles.ManualUsuárioPedido();
                objMUPed.Show();
            }
            if (Classes.VariáveisGlobais.Tela == 3)
            {
                Controles.ManualUsuárioPesquisaPedido objMUPPed = new Controles.ManualUsuárioPesquisaPedido();
                objMUPPed.Show();
            }
            if (Classes.VariáveisGlobais.Tela == 4)
            {
                Controles.ManualUsuárioAddPedidos objMUAddPed = new Controles.ManualUsuárioAddPedidos();
                objMUAddPed.Show();
            }    
            if (Classes.VariáveisGlobais.Tela == 5)
            {
                Controles.ManualUsuárioAltPedidos objMUAltPed = new Controles.ManualUsuárioAltPedidos();
                objMUAltPed.Show();
            }
            if (Classes.VariáveisGlobais.Tela == 6)
            {
                Controles.ManualUsuárioAddCliente objMUAddCli = new Controles.ManualUsuárioAddCliente();
                objMUAddCli.Show();
            }
        }
    }
}