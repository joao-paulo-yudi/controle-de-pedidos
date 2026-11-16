
namespace Controle_de_Estoque.Controles
{
    partial class ManualUsuárioPesquisaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualUsuárioPesquisaPedido));
            this.btnFechar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblRet = new System.Windows.Forms.Label();
            this.lblAv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImageIndex = 1;
            this.btnFechar.ImageList = this.imageList1;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(0, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 39);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "-.png");
            this.imageList1.Images.SetKeyName(1, "x.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "x.png");
            this.imageList2.Images.SetKeyName(1, "seta-esquerda.png");
            this.imageList2.Images.SetKeyName(2, "seta-direita.png");
            // 
            // lblRet
            // 
            this.lblRet.BackColor = System.Drawing.Color.Transparent;
            this.lblRet.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRet.ForeColor = System.Drawing.Color.White;
            this.lblRet.Location = new System.Drawing.Point(776, 598);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(51, 63);
            this.lblRet.TabIndex = 27;
            this.lblRet.Text = "<";
            this.lblRet.Visible = false;
            this.lblRet.Click += new System.EventHandler(this.lblRet_Click);
            this.lblRet.MouseEnter += new System.EventHandler(this.lblRet_MouseEnter);
            this.lblRet.MouseLeave += new System.EventHandler(this.lblRet_MouseLeave);
            // 
            // lblAv
            // 
            this.lblAv.BackColor = System.Drawing.Color.Transparent;
            this.lblAv.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAv.ForeColor = System.Drawing.Color.White;
            this.lblAv.Location = new System.Drawing.Point(832, 598);
            this.lblAv.Name = "lblAv";
            this.lblAv.Size = new System.Drawing.Size(51, 63);
            this.lblAv.TabIndex = 26;
            this.lblAv.Text = ">";
            this.lblAv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAv.Click += new System.EventHandler(this.lblAv_Click);
            this.lblAv.Leave += new System.EventHandler(this.lblAv_Leave);
            this.lblAv.MouseEnter += new System.EventHandler(this.lblAv_MouseEnter);
            this.lblAv.MouseLeave += new System.EventHandler(this.lblAv_MouseLeave);
            // 
            // ManualUsuárioPesquisaPedido
            // 
            this.AcceptButton = this.btnFechar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.Manual_de_Usuário___Pesquisa_Pedidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(880, 654);
            this.Controls.Add(this.lblRet);
            this.Controls.Add(this.lblAv);
            this.Controls.Add(this.btnFechar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManualUsuárioPesquisaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de Usuário - Pesquisar Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lblRet;
        private System.Windows.Forms.Label lblAv;
    }
}