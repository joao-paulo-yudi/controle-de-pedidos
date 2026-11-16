
namespace Controle_de_Estoque.Forms
{
    partial class frmUsuário
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditName = new System.Windows.Forms.Button();
            this.btnEditEmail = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnGerenciar = new Controle_de_Estoque.Controls.Button1();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTecnoWare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nível:";
            // 
            // btnEditName
            // 
            this.btnEditName.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditName.FlatAppearance.BorderSize = 0;
            this.btnEditName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditName.ForeColor = System.Drawing.Color.White;
            this.btnEditName.Location = new System.Drawing.Point(691, 193);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(75, 28);
            this.btnEditName.TabIndex = 20;
            this.btnEditName.Text = "Editar";
            this.btnEditName.UseVisualStyleBackColor = false;
            // 
            // btnEditEmail
            // 
            this.btnEditEmail.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditEmail.FlatAppearance.BorderSize = 0;
            this.btnEditEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmail.ForeColor = System.Drawing.Color.White;
            this.btnEditEmail.Location = new System.Drawing.Point(691, 294);
            this.btnEditEmail.Name = "btnEditEmail";
            this.btnEditEmail.Size = new System.Drawing.Size(75, 28);
            this.btnEditEmail.TabIndex = 21;
            this.btnEditEmail.Text = "Editar";
            this.btnEditEmail.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblNome.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNome.Location = new System.Drawing.Point(140, 193);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(530, 30);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "(Nome)";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmail.Location = new System.Drawing.Point(140, 294);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(540, 30);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "(Email)";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblNivel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNivel.Location = new System.Drawing.Point(140, 398);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(72, 30);
            this.lblNivel.TabIndex = 24;
            this.lblNivel.Text = "(Nivel)";
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGerenciar.BorderRadius = 77;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Location = new System.Drawing.Point(348, 542);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(278, 77);
            this.btnGerenciar.TabIndex = 25;
            this.btnGerenciar.Text = "Gerenciar Usuários";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.button11_Click);
            this.btnGerenciar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGerenciar_MouseDown);
            this.btnGerenciar.MouseEnter += new System.EventHandler(this.btnGerenciar_MouseEnter);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox8.Location = new System.Drawing.Point(70, 141);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(820, 3);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Estoque.Properties.Resources.Sem_Título_1;
            this.pictureBox1.Location = new System.Drawing.Point(905, 611);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblTecnoWare
            // 
            this.lblTecnoWare.AutoSize = true;
            this.lblTecnoWare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnoWare.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTecnoWare.Location = new System.Drawing.Point(5, 656);
            this.lblTecnoWare.Name = "lblTecnoWare";
            this.lblTecnoWare.Size = new System.Drawing.Size(169, 15);
            this.lblTecnoWare.TabIndex = 26;
            this.lblTecnoWare.Text = "Desenvolvido por TecnoWare™";
            // 
            // frmUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(975, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTecnoWare);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnEditEmail);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuário";
            this.Text = "frmUsuário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Button btnEditEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNivel;
        private Controls.Button1 btnGerenciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTecnoWare;
    }
}