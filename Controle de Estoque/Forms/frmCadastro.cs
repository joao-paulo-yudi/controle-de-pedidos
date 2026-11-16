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
using Controle_de_Estoque.Dados.DataSet_Banco1TableAdapters;

namespace Controle_de_Estoque.Forms
{
    public partial class frmCadastro : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmCadastro()
        {
            InitializeComponent();
            pictureBox1.Focus();
            pictureBox1.Select();
        }

        int NivelUser = 2;
        int ImgVar = 1;
        int ImgVar2 = 1;

        private bool CaixasOK()
        {
            if (txtNome.Texts == "Nome de Usuário")
            {
                SystemSounds.Exclamation.Play();
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso4 Mensagem = new Controles.mbAviso4();
                Resultado = Mensagem.ShowDialog();
                return false;
            }
            else
            {
                if (txtEmail.Texts == "E-mail")
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbAviso5 Mensagem = new Controles.mbAviso5();
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
        }
        private void textBox11_Load(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmLogin = new Form1();
            frmLogin.Show();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.Cursor = Cursors.Hand;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                if (Senha2Txt.Texts == SenhaTxt.Texts)
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbCad Mensagem = new Controles.mbCad();
                    Resultado = Mensagem.ShowDialog();
                    if (Resultado == DialogResult.OK)
                    {
                        UsuariosTableAdapter objUsuarios = new UsuariosTableAdapter();
                        objUsuarios.Insert(txtNome.Texts, txtEmail.Texts, Senha2Txt.Texts, NivelUser);
                        string vID = objUsuarios .UltID().ToString();
                        DialogResult Resultado2 = new DialogResult();
                        Controles.mbAviso7 Mensagem2 = new Controles.mbAviso7();
                        Resultado2 = Mensagem2.ShowDialog();
                        this.Hide();
                        Form1 objLogin = new Form1();
                        objLogin.Show();
                    }
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult Resultado = new DialogResult();
                    Controles.mbAviso6 Mensagem = new Controles.mbAviso6();
                    Resultado = Mensagem.ShowDialog();
                }
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.ForeColor = Color.Black;
            if (txtNome.Texts == "Nome de Usuário")
            {
                txtNome.Texts = "";
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Texts == "")
            {
                txtNome.ForeColor = Color.DimGray;
                txtNome.Texts = "Nome de Usuário";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            if (txtEmail.Texts == "E-mail")
            {
                txtEmail.Texts = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "")
            {
                txtEmail.ForeColor = Color.DimGray;
                txtEmail.Texts = "E-mail";
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
                verImg1.Image = Properties.Resources.não_ver;
                ImgVar = 1;
            }
        }

        private void Senha2Txt_Enter(object sender, EventArgs e)
        {
            Senha2Txt.ForeColor = Color.Black;
            if (Senha2Txt.Texts == "Repetir Senha")
            {
                Senha2Txt.Texts = "";
                Senha2Txt.PassWordChar = true;
            }
        }

        private void Senha2Txt_Leave(object sender, EventArgs e)
        {
            if (Senha2Txt.Texts == "")
            {
                Senha2Txt.ForeColor = Color.DimGray;
                Senha2Txt.Texts = "Repetir Senha";
                Senha2Txt.PassWordChar = false;
                verImg2.Image = Properties.Resources.não_ver;
                ImgVar2 = 1;
            }
        }

        private void verImg1_Click(object sender, EventArgs e)
        {
            if (SenhaTxt.Texts == "Senha")
            {

            }
            else
            {
                if (ImgVar == 1)
                {
                    verImg1.Image = Properties.Resources.ver;
                    SenhaTxt.PassWordChar = false;
                    ImgVar = 2;
                }
                else
                {
                    verImg1.Image = Properties.Resources.não_ver;
                    SenhaTxt.PassWordChar = true;
                    ImgVar = 1;
                }
            }
        }

        private void verImg2_Click(object sender, EventArgs e)
        {
            if (Senha2Txt.Texts == "Repetir Senha")
            {

            }
            else
            {
                if (ImgVar2 == 1)
                {
                    verImg2.Image = Properties.Resources.ver;
                    Senha2Txt.PassWordChar = false;
                    ImgVar2 = 2;
                }
                else
                {
                    verImg2.Image = Properties.Resources.não_ver;
                    Senha2Txt.PassWordChar = true;
                    ImgVar2 = 1;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.Cursor = Cursors.Hand;
        }

        private void verImg1_MouseEnter(object sender, EventArgs e)
        {
            verImg1.Cursor = Cursors.Hand;
            verImg1.Size = new Size(29, 29);
        }

        private void verImg1_MouseLeave(object sender, EventArgs e)
        {
            verImg1.Size = new Size(27, 27);
        }

        private void verImg2_MouseEnter(object sender, EventArgs e)
        {
            verImg2.Cursor = Cursors.Hand;
            verImg2.Size = new Size(29, 29);
        }

        private void verImg2_MouseLeave(object sender, EventArgs e)
        {
            verImg2.Size = new Size(27, 27);
        }

        private void txtNome_Load(object sender, EventArgs e)
        {

        }
    }
}
