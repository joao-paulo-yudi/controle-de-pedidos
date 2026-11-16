namespace Controle_de_Estoque.Forms
{
    partial class frmAddCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCliente));
            this.btnMin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNome = new Controle_de_Estoque.Controls.TextBox1();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCliente = new Controle_de_Estoque.Controls.Button1();
            this.clientesTableAdapter1 = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.ClientesTableAdapter();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.controle_PedidosDataSet = new Controle_de_Estoque.Controle_PedidosDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.TableAdapterManager();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBox11 = new Controle_de_Estoque.Controls.TextBox1();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTecnoWare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 27);
            this.btnMin.TabIndex = 25;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "seta-direita.png");
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderRasdius = 24;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(39, 168);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PassWordChar = false;
            this.txtNome.Size = new System.Drawing.Size(733, 60);
            this.txtNome.TabIndex = 1;
            this.txtNome.Texts = "";
            this.txtNome.UnderlineStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 45);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 45);
            this.label3.TabIndex = 59;
            this.label3.Text = "Telefone:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddCliente.BorderRadius = 61;
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.ForeColor = System.Drawing.Color.White;
            this.btnAddCliente.Location = new System.Drawing.Point(385, 537);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(206, 61);
            this.btnAddCliente.TabIndex = 3;
            this.btnAddCliente.Text = "Adicionar";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.BtnAddPedido_Click);
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "seta-direita.png");
            this.imageList2.Images.SetKeyName(1, "lupa.png");
            // 
            // controle_PedidosDataSet
            // 
            this.controle_PedidosDataSet.DataSetName = "Controle_PedidosDataSet";
            this.controle_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter1;
            this.tableAdapterManager.Itens_PedidoTableAdapter = null;
            this.tableAdapterManager.Itens_TempTableAdapter = null;
            this.tableAdapterManager.PedidosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefone", true));
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(49, 375);
            this.txtTelefone.Mask = "(99) 99999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(395, 43);
            this.txtTelefone.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Window;
            this.textBox11.BorderColor = System.Drawing.Color.DimGray;
            this.textBox11.BorderRasdius = 24;
            this.textBox11.BorderSize = 1;
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(38, 366);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Multiline = false;
            this.textBox11.Name = "textBox11";
            this.textBox11.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox11.PassWordChar = false;
            this.textBox11.Size = new System.Drawing.Size(420, 60);
            this.textBox11.TabIndex = 68;
            this.textBox11.Texts = "";
            this.textBox11.UnderlineStyle = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox8.Location = new System.Drawing.Point(44, 88);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(876, 3);
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 54);
            this.label1.TabIndex = 69;
            this.label1.Text = "Adicionar Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Estoque.Properties.Resources.Sem_Título_1;
            this.pictureBox1.Location = new System.Drawing.Point(905, 611);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
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
            this.lblTecnoWare.TabIndex = 71;
            this.lblTecnoWare.Text = "Desenvolvido por TecnoWare™";
            // 
            // frmAddCliente
            // 
            this.AcceptButton = this.btnAddCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(975, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTecnoWare);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.textBox11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            this.Load += new System.EventHandler(this.frmAddCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ImageList imageList1;
        private Controls.TextBox1 txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.Button1 btnAddCliente;
        private Controle_PedidosDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.ImageList imageList2;
        private Controle_PedidosDataSet controle_PedidosDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Controle_PedidosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private Controls.TextBox1 textBox11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTecnoWare;
    }
}