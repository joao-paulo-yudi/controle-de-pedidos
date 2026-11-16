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
    public partial class frmAltQuantItem : Form
    {
        public frmAltQuantItem()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.VariáveisGlobais.QuantItem = Convert.ToInt32(txtQuant.Texts);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                SystemSounds.Exclamation.Play();
                DialogResult Resultado = new DialogResult();
                Controles.mbAviso13 Mensagem = new Controles.mbAviso13();
                Resultado = Mensagem.ShowDialog();
            }
        }

        private void txtQuant_Load(object sender, EventArgs e)
        {

        }
    }
}
