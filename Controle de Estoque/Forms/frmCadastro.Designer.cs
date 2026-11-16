
namespace Controle_de_Estoque.Forms
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblLogin = new System.Windows.Forms.Label();
            this.verImg2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verImg1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new Controle_de_Estoque.Controls.TextBox1();
            this.txtEmail = new Controle_de_Estoque.Controls.TextBox1();
            this.btnCadastrar = new Controle_de_Estoque.Controls.Button1();
            this.SenhaTxt = new Controle_de_Estoque.Controls.TextBox1();
            this.Senha2Txt = new Controle_de_Estoque.Controls.TextBox1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verImg1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblLogin.Location = new System.Drawing.Point(166, 466);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 21);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "&Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            // 
            // verImg2
            // 
            this.verImg2.BackColor = System.Drawing.SystemColors.Window;
            this.verImg2.Image = global::Controle_de_Estoque.Properties.Resources.não_ver;
            this.verImg2.Location = new System.Drawing.Point(310, 356);
            this.verImg2.Name = "verImg2";
            this.verImg2.Size = new System.Drawing.Size(27, 27);
            this.verImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verImg2.TabIndex = 12;
            this.verImg2.TabStop = false;
            this.verImg2.Click += new System.EventHandler(this.verImg2_Click);
            this.verImg2.MouseEnter += new System.EventHandler(this.verImg2_MouseEnter);
            this.verImg2.MouseLeave += new System.EventHandler(this.verImg2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Estoque.Properties.Resources.DEvelopers;
            this.pictureBox1.Location = new System.Drawing.Point(55, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // verImg1
            // 
            this.verImg1.BackColor = System.Drawing.SystemColors.Window;
            this.verImg1.Image = global::Controle_de_Estoque.Properties.Resources.não_ver;
            this.verImg1.Location = new System.Drawing.Point(310, 303);
            this.verImg1.Name = "verImg1";
            this.verImg1.Size = new System.Drawing.Size(27, 27);
            this.verImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verImg1.TabIndex = 17;
            this.verImg1.TabStop = false;
            this.verImg1.Click += new System.EventHandler(this.verImg1_Click);
            this.verImg1.MouseEnter += new System.EventHandler(this.verImg1_MouseEnter);
            this.verImg1.MouseLeave += new System.EventHandler(this.verImg1_MouseLeave);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderRasdius = 15;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(35, 193);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PassWordChar = false;
            this.txtNome.Size = new System.Drawing.Size(310, 36);
            this.txtNome.TabIndex = 0;
            this.txtNome.Texts = "Nome de Usuário";
            this.txtNome.UnderlineStyle = false;
            this.txtNome.Load += new System.EventHandler(this.txtNome_Load);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.DimGray;
            this.txtEmail.BorderRasdius = 15;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(35, 246);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PassWordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(310, 36);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Texts = "E-mail";
            this.txtEmail.UnderlineStyle = false;
            this.txtEmail.Load += new System.EventHandler(this.textBox11_Load);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCadastrar.BorderRadius = 40;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(115, 414);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 45);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            // 
            // SenhaTxt
            // 
            this.SenhaTxt.BackColor = System.Drawing.SystemColors.Window;
            this.SenhaTxt.BorderColor = System.Drawing.Color.DimGray;
            this.SenhaTxt.BorderRasdius = 15;
            this.SenhaTxt.BorderSize = 1;
            this.SenhaTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SenhaTxt.ForeColor = System.Drawing.Color.DimGray;
            this.SenhaTxt.Location = new System.Drawing.Point(35, 299);
            this.SenhaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SenhaTxt.Multiline = false;
            this.SenhaTxt.Name = "SenhaTxt";
            this.SenhaTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.SenhaTxt.PassWordChar = false;
            this.SenhaTxt.Size = new System.Drawing.Size(310, 36);
            this.SenhaTxt.TabIndex = 2;
            this.SenhaTxt.Texts = "Senha";
            this.SenhaTxt.UnderlineStyle = false;
            this.SenhaTxt.Enter += new System.EventHandler(this.SenhaTxt_Enter);
            this.SenhaTxt.Leave += new System.EventHandler(this.SenhaTxt_Leave);
            // 
            // Senha2Txt
            // 
            this.Senha2Txt.BackColor = System.Drawing.SystemColors.Window;
            this.Senha2Txt.BorderColor = System.Drawing.Color.DimGray;
            this.Senha2Txt.BorderRasdius = 15;
            this.Senha2Txt.BorderSize = 1;
            this.Senha2Txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Senha2Txt.ForeColor = System.Drawing.Color.DimGray;
            this.Senha2Txt.Location = new System.Drawing.Point(35, 352);
            this.Senha2Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Senha2Txt.Multiline = false;
            this.Senha2Txt.Name = "Senha2Txt";
            this.Senha2Txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Senha2Txt.PassWordChar = false;
            this.Senha2Txt.Size = new System.Drawing.Size(310, 36);
            this.Senha2Txt.TabIndex = 3;
            this.Senha2Txt.Texts = "Repetir Senha";
            this.Senha2Txt.UnderlineStyle = false;
            this.Senha2Txt.Enter += new System.EventHandler(this.Senha2Txt_Enter);
            this.Senha2Txt.Leave += new System.EventHandler(this.Senha2Txt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 39);
            this.panel1.TabIndex = 18;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ImageIndex = 0;
            this.btnMin.ImageList = this.imageList1;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(297, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 39);
            this.btnMin.TabIndex = 6;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "-.png");
            this.imageList1.Images.SetKeyName(1, "x.png");
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImageIndex = 1;
            this.btnFechar.ImageList = this.imageList1;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(340, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 39);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadastro
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(380, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verImg1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.verImg2);
            this.Controls.Add(this.SenhaTxt);
            this.Controls.Add(this.Senha2Txt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastro_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verImg1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private Controls.Button1 btnCadastrar;
        private System.Windows.Forms.PictureBox verImg2;
        private Controls.TextBox1 SenhaTxt;
        private Controls.TextBox1 Senha2Txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.TextBox1 txtEmail;
        private Controls.TextBox1 txtNome;
        private System.Windows.Forms.PictureBox verImg1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ImageList imageList1;
    }
}