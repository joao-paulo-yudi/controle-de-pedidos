
namespace Controle_de_Estoque.Forms
{
    partial class frmAddPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnMin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_PedidosDataSet = new Controle_de_Estoque.Controle_PedidosDataSet();
            this.clientesTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.ClientesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.itensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itens_PedidoTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.ProdutosTableAdapter();
            this.btnAdd = new Controle_de_Estoque.Controls.Button1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.selectItemIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.iD_PedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iD_PedToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.selectItemIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTecnoWare = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new Controle_de_Estoque.Controls.Button1();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblPreço = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.txtQuantidade = new Controle_de_Estoque.Controls.TextBox1();
            this.btnRemover = new Controle_de_Estoque.Controls.Button1();
            this.btnAddPedido = new Controle_de_Estoque.Controls.Button1();
            this.selectItemID1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.iD_PedToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.iD_PedToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.selectItemID1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pedidosTableAdapter1 = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.PedidosTableAdapter();
            this.itens_TempTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.Itens_TempTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controle_PedidosDataSet1 = new Controle_de_Estoque.Controle_PedidosDataSet();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.selectItemIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.selectItemID1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adicionar Pedidos";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "seta-direita.png");
            this.imageList1.Images.SetKeyName(1, "lupa.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente:";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "seta-direita.png");
            this.imageList2.Images.SetKeyName(1, "lupa.png");
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
            this.btnMin.TabIndex = 22;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DataSource = this.clientesBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 29);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "Nome";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // controle_PedidosDataSet
            // 
            this.controle_PedidosDataSet.DataSetName = "Controle_PedidosDataSet";
            this.controle_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(621, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Produtos:";
            // 
            // itensPedidoBindingSource
            // 
            this.itensPedidoBindingSource.DataMember = "Itens_Pedido";
            this.itensPedidoBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // itens_PedidoTableAdapter
            // 
            this.itens_PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.iDProdDataGridViewTextBoxColumn,
            this.tipoProdDataGridViewTextBoxColumn,
            this.marcaProdDataGridViewTextBoxColumn,
            this.tamanhoProdDataGridViewTextBoxColumn,
            this.preçoProdDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itensTempBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(44, 268);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 283);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDProdDataGridViewTextBoxColumn
            // 
            this.iDProdDataGridViewTextBoxColumn.DataPropertyName = "ID_Prod";
            this.iDProdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProdDataGridViewTextBoxColumn.Name = "iDProdDataGridViewTextBoxColumn";
            this.iDProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProdDataGridViewTextBoxColumn
            // 
            this.tipoProdDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Prod";
            this.tipoProdDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoProdDataGridViewTextBoxColumn.Name = "tipoProdDataGridViewTextBoxColumn";
            this.tipoProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProdDataGridViewTextBoxColumn.Width = 140;
            // 
            // marcaProdDataGridViewTextBoxColumn
            // 
            this.marcaProdDataGridViewTextBoxColumn.DataPropertyName = "Marca_Prod";
            this.marcaProdDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaProdDataGridViewTextBoxColumn.Name = "marcaProdDataGridViewTextBoxColumn";
            this.marcaProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaProdDataGridViewTextBoxColumn.Width = 148;
            // 
            // tamanhoProdDataGridViewTextBoxColumn
            // 
            this.tamanhoProdDataGridViewTextBoxColumn.DataPropertyName = "Tamanho_Prod";
            this.tamanhoProdDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoProdDataGridViewTextBoxColumn.Name = "tamanhoProdDataGridViewTextBoxColumn";
            this.tamanhoProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoProdDataGridViewTextBoxColumn.Width = 80;
            // 
            // preçoProdDataGridViewTextBoxColumn
            // 
            this.preçoProdDataGridViewTextBoxColumn.DataPropertyName = "Preço_Prod";
            this.preçoProdDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoProdDataGridViewTextBoxColumn.Name = "preçoProdDataGridViewTextBoxColumn";
            this.preçoProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.preçoProdDataGridViewTextBoxColumn.Width = 145;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "Valor_Total";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 145;
            // 
            // itensTempBindingSource
            // 
            this.itensTempBindingSource.DataMember = "Itens_Temp";
            this.itensTempBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(815, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 30);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Adicionar Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(416, 134);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 9, 22, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 29);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(410, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Data:";
            // 
            // selectItemIDToolStrip
            // 
            this.selectItemIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD_PedToolStripLabel,
            this.iD_PedToolStripTextBox,
            this.selectItemIDToolStripButton});
            this.selectItemIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.selectItemIDToolStrip.Name = "selectItemIDToolStrip";
            this.selectItemIDToolStrip.Size = new System.Drawing.Size(975, 25);
            this.selectItemIDToolStrip.TabIndex = 34;
            this.selectItemIDToolStrip.Text = "selectItemIDToolStrip";
            this.selectItemIDToolStrip.Visible = false;
            // 
            // iD_PedToolStripLabel
            // 
            this.iD_PedToolStripLabel.Name = "iD_PedToolStripLabel";
            this.iD_PedToolStripLabel.Size = new System.Drawing.Size(46, 22);
            this.iD_PedToolStripLabel.Text = "ID_Ped:";
            // 
            // iD_PedToolStripTextBox
            // 
            this.iD_PedToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iD_PedToolStripTextBox.Name = "iD_PedToolStripTextBox";
            this.iD_PedToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // selectItemIDToolStripButton
            // 
            this.selectItemIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectItemIDToolStripButton.Name = "selectItemIDToolStripButton";
            this.selectItemIDToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.selectItemIDToolStripButton.Text = "SelectItemID";
            this.selectItemIDToolStripButton.Click += new System.EventHandler(this.selectItemIDToolStripButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Estoque.Properties.Resources.Sem_Título_1;
            this.pictureBox1.Location = new System.Drawing.Point(905, 611);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
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
            this.lblTecnoWare.TabIndex = 35;
            this.lblTecnoWare.Text = "Desenvolvido por TecnoWare™";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox8.Location = new System.Drawing.Point(44, 81);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(901, 3);
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPesquisar.BorderRadius = 35;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Controle_de_Estoque.Properties.Resources.lupa3;
            this.btnPesquisar.Location = new System.Drawing.Point(912, 130);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(35, 35);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.btnPesquisar_MouseEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(39, 216);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 25);
            this.lblTipo.TabIndex = 41;
            this.lblTipo.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(44, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 2);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(238, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 2);
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(233, 216);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 25);
            this.lblMarca.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(233, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(566, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tamanho:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(683, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Quantidade:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(429, 243);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(125, 2);
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreço.ForeColor = System.Drawing.Color.White;
            this.lblPreço.Location = new System.Drawing.Point(424, 216);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(0, 25);
            this.lblPreço.TabIndex = 53;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.ForeColor = System.Drawing.Color.White;
            this.labelPreco.Location = new System.Drawing.Point(424, 183);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(64, 25);
            this.labelPreco.TabIndex = 52;
            this.labelPreco.Text = "Preço:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.BorderColor = System.Drawing.Color.DimGray;
            this.txtQuantidade.BorderRasdius = 15;
            this.txtQuantidade.BorderSize = 1;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(688, 209);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantidade.PassWordChar = false;
            this.txtQuantidade.Size = new System.Drawing.Size(118, 36);
            this.txtQuantidade.TabIndex = 55;
            this.txtQuantidade.Texts = "";
            this.txtQuantidade.UnderlineStyle = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemover.BorderRadius = 30;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(44, 562);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(130, 30);
            this.btnRemover.TabIndex = 56;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.MouseEnter += new System.EventHandler(this.btnRemover_MouseEnter);
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddPedido.BorderRadius = 56;
            this.btnAddPedido.FlatAppearance.BorderSize = 0;
            this.btnAddPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedido.ForeColor = System.Drawing.Color.White;
            this.btnAddPedido.Location = new System.Drawing.Point(370, 584);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(235, 56);
            this.btnAddPedido.TabIndex = 57;
            this.btnAddPedido.Text = "Adicionar Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = false;
            this.btnAddPedido.Click += new System.EventHandler(this.button11_Click);
            this.btnAddPedido.MouseEnter += new System.EventHandler(this.btnAddPedido_MouseEnter);
            // 
            // selectItemID1ToolStrip
            // 
            this.selectItemID1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD_PedToolStripLabel1,
            this.iD_PedToolStripTextBox1,
            this.selectItemID1ToolStripButton});
            this.selectItemID1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.selectItemID1ToolStrip.Name = "selectItemID1ToolStrip";
            this.selectItemID1ToolStrip.Size = new System.Drawing.Size(995, 25);
            this.selectItemID1ToolStrip.TabIndex = 59;
            this.selectItemID1ToolStrip.Text = "selectItemID1ToolStrip";
            this.selectItemID1ToolStrip.Visible = false;
            // 
            // iD_PedToolStripLabel1
            // 
            this.iD_PedToolStripLabel1.Name = "iD_PedToolStripLabel1";
            this.iD_PedToolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.iD_PedToolStripLabel1.Text = "ID_Ped:";
            // 
            // iD_PedToolStripTextBox1
            // 
            this.iD_PedToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iD_PedToolStripTextBox1.Name = "iD_PedToolStripTextBox1";
            this.iD_PedToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // selectItemID1ToolStripButton
            // 
            this.selectItemID1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectItemID1ToolStripButton.Name = "selectItemID1ToolStripButton";
            this.selectItemID1ToolStripButton.Size = new System.Drawing.Size(83, 22);
            this.selectItemID1ToolStripButton.Text = "SelectItemID1";
            this.selectItemID1ToolStripButton.Click += new System.EventHandler(this.selectItemID1ToolStripButton_Click_1);
            // 
            // pedidosTableAdapter1
            // 
            this.pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // itens_TempTableAdapter
            // 
            this.itens_TempTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.DataSource = this.produtosBindingSource1;
            this.comboBox2.DisplayMember = "Nome_Prod";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(627, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(279, 29);
            this.comboBox2.TabIndex = 61;
            this.comboBox2.ValueMember = "Nome_Prod";
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            this.produtosBindingSource1.DataSource = this.controle_PedidosDataSet1;
            // 
            // controle_PedidosDataSet1
            // 
            this.controle_PedidosDataSet1.DataSetName = "Controle_PedidosDataSet";
            this.controle_PedidosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG"});
            this.comboBox3.Location = new System.Drawing.Point(573, 216);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(97, 29);
            this.comboBox3.TabIndex = 62;
            // 
            // frmAddPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(995, 701);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblPreço);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTecnoWare);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectItemID1ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectItemIDToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPedidos";
            this.Text = "frmAddPedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddPedidos_FormClosed);
            this.Load += new System.EventHandler(this.frmAddPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.selectItemIDToolStrip.ResumeLayout(false);
            this.selectItemIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.selectItemID1ToolStrip.ResumeLayout(false);
            this.selectItemID1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Controle_PedidosDataSet controle_PedidosDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Controle_PedidosDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource itensPedidoBindingSource;
        private Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter itens_PedidoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Controle_PedidosDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private Controls.Button1 btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip selectItemIDToolStrip;
        private System.Windows.Forms.ToolStripLabel iD_PedToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iD_PedToolStripTextBox;
        private System.Windows.Forms.ToolStripButton selectItemIDToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTecnoWare;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Controls.Button1 btnPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.Label labelPreco;
        private Controls.TextBox1 txtQuantidade;
        private Controls.Button1 btnRemover;
        private Controls.Button1 btnAddPedido;
        private System.Windows.Forms.ToolStrip selectItemID1ToolStrip;
        private System.Windows.Forms.ToolStripLabel iD_PedToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox iD_PedToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton selectItemID1ToolStripButton;
        private Controle_PedidosDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter1;
        private System.Windows.Forms.BindingSource itensTempBindingSource;
        private Controle_PedidosDataSetTableAdapters.Itens_TempTableAdapter itens_TempTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private Controle_PedidosDataSet controle_PedidosDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}