
namespace Controle_de_Estoque.Forms
{
    partial class frmAltPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltPedidos));
            this.btnItensPedido = new Controle_de_Estoque.Controls.Button1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new Controle_de_Estoque.Controls.TextBox1();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controle_PedidosDataSet = new Controle_de_Estoque.Controle_PedidosDataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTecnoWare = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pedidosTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.PedidosTableAdapter();
            this.btnRemover = new Controle_de_Estoque.Controls.Button1();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPesquisar = new Controle_de_Estoque.Controls.Button1();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConcluirPed = new Controle_de_Estoque.Controls.Button1();
            this.itens_PedidoTableAdapter1 = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItensPedido
            // 
            this.btnItensPedido.BackColor = System.Drawing.Color.DarkOrange;
            this.btnItensPedido.BorderRadius = 30;
            this.btnItensPedido.FlatAppearance.BorderSize = 0;
            this.btnItensPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItensPedido.ForeColor = System.Drawing.Color.White;
            this.btnItensPedido.Location = new System.Drawing.Point(37, 565);
            this.btnItensPedido.Name = "btnItensPedido";
            this.btnItensPedido.Size = new System.Drawing.Size(185, 30);
            this.btnItensPedido.TabIndex = 29;
            this.btnItensPedido.Text = "Alterar itens do pedido";
            this.btnItensPedido.UseVisualStyleBackColor = false;
            this.btnItensPedido.Click += new System.EventHandler(this.btnItensPedido_Click);
            this.btnItensPedido.MouseEnter += new System.EventHandler(this.btnItensPedido_MouseEnter);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID Pedido",
            "ID Cliente",
            "Data",
            "Preço",
            "Situação"});
            this.comboBox1.Location = new System.Drawing.Point(679, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 29);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisar.BorderColor = System.Drawing.Color.DimGray;
            this.txtPesquisar.BorderRasdius = 15;
            this.txtPesquisar.BorderSize = 1;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisar.Location = new System.Drawing.Point(37, 106);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPesquisar.PassWordChar = false;
            this.txtPesquisar.Size = new System.Drawing.Size(619, 36);
            this.txtPesquisar.TabIndex = 26;
            this.txtPesquisar.Texts = "Pesquisar...";
            this.txtPesquisar.UnderlineStyle = false;
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            this.txtPesquisar.MouseEnter += new System.EventHandler(this.txtPesquisar_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Alterar Pedidos";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPedDataGridViewTextBoxColumn,
            this.Nome_Cliente,
            this.dataDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidosBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 166);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 382);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDPedDataGridViewTextBoxColumn
            // 
            this.iDPedDataGridViewTextBoxColumn.DataPropertyName = "ID_Ped";
            this.iDPedDataGridViewTextBoxColumn.HeaderText = "ID Pedido";
            this.iDPedDataGridViewTextBoxColumn.Name = "iDPedDataGridViewTextBoxColumn";
            this.iDPedDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPedDataGridViewTextBoxColumn.Width = 150;
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.DataPropertyName = "Nome_Cliente";
            this.Nome_Cliente.HeaderText = "Cliente";
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.ReadOnly = true;
            this.Nome_Cliente.Width = 180;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 155;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.ReadOnly = true;
            this.preçoDataGridViewTextBoxColumn.Width = 188;
            // 
            // situaçãoDataGridViewTextBoxColumn
            // 
            this.situaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.Name = "situaçãoDataGridViewTextBoxColumn";
            this.situaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situaçãoDataGridViewTextBoxColumn.Width = 185;
            // 
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "Pedidos";
            this.pedidosBindingSource1.DataSource = this.controle_PedidosDataSet;
            // 
            // controle_PedidosDataSet
            // 
            this.controle_PedidosDataSet.DataSetName = "Controle_PedidosDataSet";
            this.controle_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // lblTecnoWare
            // 
            this.lblTecnoWare.AutoSize = true;
            this.lblTecnoWare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnoWare.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTecnoWare.Location = new System.Drawing.Point(5, 656);
            this.lblTecnoWare.Name = "lblTecnoWare";
            this.lblTecnoWare.Size = new System.Drawing.Size(169, 15);
            this.lblTecnoWare.TabIndex = 21;
            this.lblTecnoWare.Text = "Desenvolvido por TecnoWare™";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "seta-direita.png");
            this.imageList2.Images.SetKeyName(1, "x.png");
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemover.BorderRadius = 50;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = global::Controle_de_Estoque.Properties.Resources.lata_de_lixo__1_;
            this.btnRemover.Location = new System.Drawing.Point(842, 554);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(96, 50);
            this.btnRemover.TabIndex = 31;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.MouseEnter += new System.EventHandler(this.btnRemover_MouseEnter);
            this.btnRemover.MouseLeave += new System.EventHandler(this.btnRemover_MouseLeave);
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
            this.btnMin.ImageList = this.imageList2;
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 27);
            this.btnMin.TabIndex = 30;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPesquisar.BorderRadius = 35;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Controle_de_Estoque.Properties.Resources.lupa3;
            this.btnPesquisar.Location = new System.Drawing.Point(842, 106);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 35);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.btnPesquisar_MouseEnter);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox8.Location = new System.Drawing.Point(37, 81);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(901, 3);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Estoque.Properties.Resources.Sem_Título_1;
            this.pictureBox1.Location = new System.Drawing.Point(905, 611);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnConcluirPed
            // 
            this.btnConcluirPed.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConcluirPed.BorderRadius = 30;
            this.btnConcluirPed.FlatAppearance.BorderSize = 0;
            this.btnConcluirPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirPed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirPed.ForeColor = System.Drawing.Color.White;
            this.btnConcluirPed.Location = new System.Drawing.Point(686, 565);
            this.btnConcluirPed.Name = "btnConcluirPed";
            this.btnConcluirPed.Size = new System.Drawing.Size(141, 30);
            this.btnConcluirPed.TabIndex = 32;
            this.btnConcluirPed.Text = "Concluir pedido";
            this.btnConcluirPed.UseVisualStyleBackColor = false;
            this.btnConcluirPed.Click += new System.EventHandler(this.button11_Click);
            // 
            // itens_PedidoTableAdapter1
            // 
            this.itens_PedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAltPedidos
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(975, 681);
            this.Controls.Add(this.btnConcluirPed);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnItensPedido);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTecnoWare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltPedidos";
            this.Text = "frmAltPedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAltPedidos_FormClosed);
            this.Load += new System.EventHandler(this.frmAltPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Button1 btnItensPedido;
        private Controls.Button1 btnPesquisar;
        private System.Windows.Forms.ComboBox comboBox1;
        private Controls.TextBox1 txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTecnoWare;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ImageList imageList2;
        private Controle_PedidosDataSet controle_PedidosDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private Controle_PedidosDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private Controls.Button1 btnRemover;
        private Controls.Button1 btnConcluirPed;
        private Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter itens_PedidoTableAdapter1;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoDataGridViewTextBoxColumn;
    }
}