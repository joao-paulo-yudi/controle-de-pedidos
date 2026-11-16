
namespace Controle_de_Estoque.Forms
{
    partial class frmAltItensPed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltItensPed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_PedidosDataSet = new Controle_de_Estoque.Controle_PedidosDataSet();
            this.itens_PedidoTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter();
            this.selectItemID1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.iD_PedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iD_PedToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.selectItemID1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pedidosTableAdapter1 = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.PedidosTableAdapter();
            this.produtosTableAdapter1 = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.ProdutosTableAdapter();
            this.btnRemover = new Controle_de_Estoque.Controls.Button1();
            this.btnItensPedido = new Controle_de_Estoque.Controls.Button1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).BeginInit();
            this.selectItemID1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Selecionar item para editar";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 533);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(601, 4);
            this.panel4.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(601, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 537);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 529);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 4);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox8.Location = new System.Drawing.Point(24, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(555, 3);
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "seta-direita.png");
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
            this.btnMin.Location = new System.Drawing.Point(4, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 27);
            this.btnMin.TabIndex = 36;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            this.iDProdDataGridViewTextBoxColumn,
            this.tipoProdDataGridViewTextBoxColumn,
            this.marcaProdDataGridViewTextBoxColumn,
            this.tamanhoProdDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itensPedidoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 378);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDProdDataGridViewTextBoxColumn
            // 
            this.iDProdDataGridViewTextBoxColumn.DataPropertyName = "ID_Prod";
            this.iDProdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProdDataGridViewTextBoxColumn.Name = "iDProdDataGridViewTextBoxColumn";
            this.iDProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdDataGridViewTextBoxColumn.Width = 67;
            // 
            // tipoProdDataGridViewTextBoxColumn
            // 
            this.tipoProdDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Prod";
            this.tipoProdDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoProdDataGridViewTextBoxColumn.Name = "tipoProdDataGridViewTextBoxColumn";
            this.tipoProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProdDataGridViewTextBoxColumn.Width = 88;
            // 
            // marcaProdDataGridViewTextBoxColumn
            // 
            this.marcaProdDataGridViewTextBoxColumn.DataPropertyName = "Marca_Prod";
            this.marcaProdDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaProdDataGridViewTextBoxColumn.Name = "marcaProdDataGridViewTextBoxColumn";
            this.marcaProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaProdDataGridViewTextBoxColumn.Width = 88;
            // 
            // tamanhoProdDataGridViewTextBoxColumn
            // 
            this.tamanhoProdDataGridViewTextBoxColumn.DataPropertyName = "Tamanho_Prod";
            this.tamanhoProdDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoProdDataGridViewTextBoxColumn.Name = "tamanhoProdDataGridViewTextBoxColumn";
            this.tamanhoProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoProdDataGridViewTextBoxColumn.Width = 72;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 92;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "Valor_Total";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 105;
            // 
            // itensPedidoBindingSource
            // 
            this.itensPedidoBindingSource.DataMember = "Itens_Pedido";
            this.itensPedidoBindingSource.DataSource = this.controle_PedidosDataSet;
            // 
            // controle_PedidosDataSet
            // 
            this.controle_PedidosDataSet.DataSetName = "Controle_PedidosDataSet";
            this.controle_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itens_PedidoTableAdapter
            // 
            this.itens_PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // selectItemID1ToolStrip
            // 
            this.selectItemID1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD_PedToolStripLabel,
            this.iD_PedToolStripTextBox,
            this.selectItemID1ToolStripButton});
            this.selectItemID1ToolStrip.Location = new System.Drawing.Point(4, 4);
            this.selectItemID1ToolStrip.Name = "selectItemID1ToolStrip";
            this.selectItemID1ToolStrip.Size = new System.Drawing.Size(597, 25);
            this.selectItemID1ToolStrip.TabIndex = 38;
            this.selectItemID1ToolStrip.Text = "selectItemID1ToolStrip";
            this.selectItemID1ToolStrip.Visible = false;
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
            // selectItemID1ToolStripButton
            // 
            this.selectItemID1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectItemID1ToolStripButton.Name = "selectItemID1ToolStripButton";
            this.selectItemID1ToolStripButton.Size = new System.Drawing.Size(83, 22);
            this.selectItemID1ToolStripButton.Text = "SelectItemID1";
            this.selectItemID1ToolStripButton.Click += new System.EventHandler(this.selectItemID1ToolStripButton_Click);
            // 
            // pedidosTableAdapter1
            // 
            this.pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemover.BorderRadius = 50;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = global::Controle_de_Estoque.Properties.Resources.lata_de_lixo__1_;
            this.btnRemover.Location = new System.Drawing.Point(483, 476);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(96, 50);
            this.btnRemover.TabIndex = 40;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.MouseEnter += new System.EventHandler(this.btnRemover_MouseEnter);
            this.btnRemover.MouseLeave += new System.EventHandler(this.btnRemover_MouseLeave);
            // 
            // btnItensPedido
            // 
            this.btnItensPedido.BackColor = System.Drawing.Color.DarkOrange;
            this.btnItensPedido.BorderRadius = 30;
            this.btnItensPedido.FlatAppearance.BorderSize = 0;
            this.btnItensPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItensPedido.ForeColor = System.Drawing.Color.White;
            this.btnItensPedido.Location = new System.Drawing.Point(24, 484);
            this.btnItensPedido.Name = "btnItensPedido";
            this.btnItensPedido.Size = new System.Drawing.Size(114, 30);
            this.btnItensPedido.TabIndex = 39;
            this.btnItensPedido.Text = "Editar item";
            this.btnItensPedido.UseVisualStyleBackColor = false;
            this.btnItensPedido.Click += new System.EventHandler(this.btnItensPedido_Click);
            // 
            // frmAltItensPed
            // 
            this.AcceptButton = this.btnMin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(605, 537);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnItensPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectItemID1ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltItensPed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Itens do Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAltItensPed_FormClosed);
            this.Load += new System.EventHandler(this.frmAltItensPed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).EndInit();
            this.selectItemID1ToolStrip.ResumeLayout(false);
            this.selectItemID1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controle_PedidosDataSet controle_PedidosDataSet;
        private System.Windows.Forms.BindingSource itensPedidoBindingSource;
        private Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter itens_PedidoTableAdapter;
        private System.Windows.Forms.ToolStrip selectItemID1ToolStrip;
        private System.Windows.Forms.ToolStripLabel iD_PedToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iD_PedToolStripTextBox;
        private System.Windows.Forms.ToolStripButton selectItemID1ToolStripButton;
        private Controls.Button1 btnItensPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private Controls.Button1 btnRemover;
        private Controle_PedidosDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter1;
        private Controle_PedidosDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter1;
    }
}