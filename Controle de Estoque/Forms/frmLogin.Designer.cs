
namespace Controle_de_Estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLogin = new Controle_de_Estoque.Controls.Button1();
            this.SenhaTxt = new Controle_de_Estoque.Controls.TextBox1();
            this.UserTxt = new Controle_de_Estoque.Controls.TextBox1();
            this.verImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ver.png");
            this.imageList1.Images.SetKeyName(1, "não_ver.png");
            // 
            // lblCadastrar
            // 
            resources.ApplyResources(this.lblCadastrar, "lblCadastrar");
            this.lblCadastrar.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Click += new System.EventHandler(this.lblCadastrar_Click);
            this.lblCadastrar.Enter += new System.EventHandler(this.lblCadastrar_Enter);
            this.lblCadastrar.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            // 
            // SenhaTxt
            // 
            this.SenhaTxt.BackColor = System.Drawing.SystemColors.Window;
            this.SenhaTxt.BorderColor = System.Drawing.Color.DimGray;
            this.SenhaTxt.BorderRasdius = 15;
            this.SenhaTxt.BorderSize = 1;
            resources.ApplyResources(this.SenhaTxt, "SenhaTxt");
            this.SenhaTxt.ForeColor = System.Drawing.Color.DimGray;
            this.SenhaTxt.Multiline = false;
            this.SenhaTxt.Name = "SenhaTxt";
            this.SenhaTxt.PassWordChar = false;
            this.SenhaTxt.Texts = "Senha";
            this.SenhaTxt.UnderlineStyle = false;
            this.SenhaTxt.Load += new System.EventHandler(this.SenhaTxt_Load);
            this.SenhaTxt.Enter += new System.EventHandler(this.SenhaTxt_Enter);
            this.SenhaTxt.Leave += new System.EventHandler(this.SenhaTxt_Leave);
            // 
            // UserTxt
            // 
            this.UserTxt.BackColor = System.Drawing.SystemColors.Window;
            this.UserTxt.BorderColor = System.Drawing.Color.DimGray;
            this.UserTxt.BorderRasdius = 15;
            this.UserTxt.BorderSize = 1;
            resources.ApplyResources(this.UserTxt, "UserTxt");
            this.UserTxt.ForeColor = System.Drawing.Color.DimGray;
            this.UserTxt.Multiline = false;
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.PassWordChar = false;
            this.UserTxt.Texts = "Usuário ou e-mail";
            this.UserTxt.UnderlineStyle = false;
            this.UserTxt.Load += new System.EventHandler(this.UserTxt_Load);
            this.UserTxt.Enter += new System.EventHandler(this.UserTxt_Enter_1);
            this.UserTxt.Leave += new System.EventHandler(this.UserTxt_Leave_1);
            // 
            // verImg
            // 
            this.verImg.BackColor = System.Drawing.SystemColors.Window;
            this.verImg.Image = global::Controle_de_Estoque.Properties.Resources.não_ver;
            resources.ApplyResources(this.verImg, "verImg");
            this.verImg.Name = "verImg";
            this.verImg.TabStop = false;
            this.verImg.Click += new System.EventHandler(this.verImg_Click);
            this.verImg.MouseEnter += new System.EventHandler(this.verImg_MouseEnter);
            this.verImg.MouseLeave += new System.EventHandler(this.verImg_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Estoque.Properties.Resources.DEvelopers;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnFechar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMin
            // 
            resources.ApplyResources(this.btnMin, "btnMin");
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMin.ImageList = this.imageList2;
            this.btnMin.Name = "btnMin";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "-.png");
            this.imageList2.Images.SetKeyName(1, "x.png");
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.ImageList = this.imageList2;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.verImg);
            this.Controls.Add(this.SenhaTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.TextBox1 UserTxt;
        private Controls.TextBox1 SenhaTxt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox verImg;
        private Controls.Button1 btnLogin;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ImageList imageList2;
    }
}

