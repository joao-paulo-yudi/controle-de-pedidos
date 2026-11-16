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
using Controle_de_Estoque.Dados;
using Controle_de_Estoque.Dados.DataSet_Banco1TableAdapters;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Focus();
            pictureBox1.Select();
        }

        int ImgVar = 1;
        private bool CaixasOK()
        {
            if (UserTxt.Texts == "Usuário ou e-mail")
            {
                SystemSounds.Exclamation.Play(); 
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso1 Mensagem = new Controles.mbAviso1();
                Resultado = Mensagem.ShowDialog();
                return false;
            }
            else
            {
                if (SenhaTxt.Texts == "Senha")
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbAviso Mensagem = new Controles.mbAviso();
                    Resultado = Mensagem.ShowDialog();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {

        }
        private void UserTxt_Load(object sender, EventArgs e)
        {

        }

        private void UserTxt_Enter_1(object sender, EventArgs e)
        {
            UserTxt.ForeColor = Color.Black;
            if (UserTxt.Texts == "Usuário ou e-mail")
            {
                UserTxt.Texts = "";
            }
        }

        private void UserTxt_Leave_1(object sender, EventArgs e)
        {
            if (UserTxt.Texts == "")
            {
                UserTxt.ForeColor = Color.DimGray;
                UserTxt.Texts = "Usuário ou e-mail";
            }
        }

        private void SenhaTxt_Enter(object sender, EventArgs e)
        {
            SenhaTxt.ForeColor = Color.Black;
            if (SenhaTxt.Texts == "Senha")
            {
                SenhaTxt.Texts = "";
                SenhaTxt.PassWordChar = true;
            }
        }

        private void SenhaTxt_Leave(object sender, EventArgs e)
        {
            if (SenhaTxt.Texts == "")
            {
                            SenhaTxt.ForeColor = Color.DimGray;
                SenhaTxt.Texts = "Senha";
                SenhaTxt.PassWordChar = false;
                verImg.Image = Properties.Resources.não_ver;
                ImgVar = 1;
            }
        }

        private void verImg_Click(object sender, EventArgs e)
        {
            if (SenhaTxt.Texts == "Senha")
            {

            }
            else
            {
                if (ImgVar == 1)
                {
                    verImg.Image = Properties.Resources.ver;
                    SenhaTxt.PassWordChar = false;
                    ImgVar = 2;
                }
                else
                {
                    verImg.Image = Properties.Resources.não_ver;
                    SenhaTxt.PassWordChar = true;
                    ImgVar = 1;
                }
            }
        }

        private void verImg_MouseEnter(object sender, EventArgs e)
        {
            verImg.Cursor = Cursors.Hand;
            verImg.Size = new Size(29, 29);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrar.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                DataSet_Banco1.UsuariosDataTable dtUsuarios;
                UsuariosTableAdapter taUsuarios = new UsuariosTableAdapter();
                dtUsuarios = taUsuarios.VerificaNivelDoUsuario(UserTxt.Texts, SenhaTxt.Texts, UserTxt.Texts);
                if (dtUsuarios.Rows.Count == 0)
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbAviso3 Mensagem = new Controles.mbAviso3();
                    Resultado = Mensagem.ShowDialog();
                }
                else
                {
                    Properties.Settings.Default.NomeUsuarioLogado = taUsuarios.NomeUser(UserTxt.Texts, SenhaTxt.Texts, UserTxt.Texts);
                    Properties.Settings.Default.EmailUsuarioLogado = taUsuarios.EmailUser(UserTxt.Texts, SenhaTxt.Texts, UserTxt.Texts);
                    Properties.Settings.Default.NivelUsuarioLogado = Convert.ToInt32(dtUsuarios.Rows[0]["Nivel"]);
                    Forms.frmHome frmHome = new Forms.frmHome();
                    this.Hide();
                    frmHome.Show();
                }
            }
        }

        private void lblCadastrar_Enter(object sender, EventArgs e)
        {

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.frmCadastro frmCadastro = new Forms.frmCadastro();
            frmCadastro.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SenhaTxt_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
        }

        private void verImg_MouseLeave(object sender, EventArgs e)
        {
            verImg.Size = new Size(27, 27);
        }
    }
}
