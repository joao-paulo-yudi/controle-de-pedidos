
namespace Controle_de_Estoque.Forms
{
    partial class frmItensPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItensPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.itensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensPedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controle_PedidosDataSet = new Controle_de_Estoque.Controle_PedidosDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.itens_PedidoTableAdapter = new Controle_de_Estoque.Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter();
            this.btnMin = new System.Windows.Forms.Button();
            this.selectItemIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.iD_PedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iD_PedToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.selectItemIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.selectItemID1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.iD_PedToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.iD_PedToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.selectItemID1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).BeginInit();
            this.selectItemIDToolStrip.SuspendLayout();
            this.selectItemID1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(601, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 494);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 4);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 490);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 4);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Itens do Pedido:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox8.Location = new System.Drawing.Point(24, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(555, 3);
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
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
            this.dataGridView1.DataSource = this.itensPedidoBindingSource1;
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(555, 378);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDProdDataGridViewTextBoxColumn
            // 
            this.iDProdDataGridViewTextBoxColumn.DataPropertyName = "ID_Prod";
            this.iDProdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProdDataGridViewTextBoxColumn.Name = "iDProdDataGridViewTextBoxColumn";
            this.iDProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdDataGridViewTextBoxColumn.Width = 75;
            // 
            // tipoProdDataGridViewTextBoxColumn
            // 
            this.tipoProdDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Prod";
            this.tipoProdDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoProdDataGridViewTextBoxColumn.Name = "tipoProdDataGridViewTextBoxColumn";
            this.tipoProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaProdDataGridViewTextBoxColumn
            // 
            this.marcaProdDataGridViewTextBoxColumn.DataPropertyName = "Marca_Prod";
            this.marcaProdDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaProdDataGridViewTextBoxColumn.Name = "marcaProdDataGridViewTextBoxColumn";
            this.marcaProdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "Valor_Total";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 105;
            // 
            // itensPedidoBindingSource1
            // 
            this.itensPedidoBindingSource1.DataMember = "Itens_Pedido";
            this.itensPedidoBindingSource1.DataSource = this.controle_PedidosDataSet;
            // 
            // controle_PedidosDataSet
            // 
            this.controle_PedidosDataSet.DataSetName = "Controle_PedidosDataSet";
            this.controle_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "seta-direita.png");
            // 
            // itens_PedidoTableAdapter
            // 
            this.itens_PedidoTableAdapter.ClearBeforeFill = true;
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
            this.btnMin.TabIndex = 22;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // selectItemIDToolStrip
            // 
            this.selectItemIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD_PedToolStripLabel,
            this.iD_PedToolStripTextBox,
            this.selectItemIDToolStripButton});
            this.selectItemIDToolStrip.Location = new System.Drawing.Point(4, 4);
            this.selectItemIDToolStrip.Name = "selectItemIDToolStrip";
            this.selectItemIDToolStrip.Size = new System.Drawing.Size(597, 25);
            this.selectItemIDToolStrip.TabIndex = 23;
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
            this.selectItemIDToolStripButton.Click += new System.EventHandler(this.selectItemIDToolStripButton_Click_1);
            // 
            // selectItemID1ToolStrip
            // 
            this.selectItemID1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD_PedToolStripLabel1,
            this.iD_PedToolStripTextBox1,
            this.selectItemID1ToolStripButton});
            this.selectItemID1ToolStrip.Location = new System.Drawing.Point(4, 4);
            this.selectItemID1ToolStrip.Name = "selectItemID1ToolStrip";
            this.selectItemID1ToolStrip.Size = new System.Drawing.Size(597, 25);
            this.selectItemID1ToolStrip.TabIndex = 24;
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
            this.selectItemID1ToolStripButton.Click += new System.EventHandler(this.selectItemID1ToolStripButton_Click);
            // 
            // frmItensPedido
            // 
            this.AcceptButton = this.btnMin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(605, 494);
            this.Controls.Add(this.selectItemIDToolStrip);
            this.Controls.Add(this.selectItemID1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItensPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItensPedido";
            this.Load += new System.EventHandler(this.frmItensPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_PedidosDataSet)).EndInit();
            this.selectItemIDToolStrip.ResumeLayout(false);
            this.selectItemIDToolStrip.PerformLayout();
            this.selectItemID1ToolStrip.ResumeLayout(false);
            this.selectItemID1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource itensPedidoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private Controle_PedidosDataSet controle_PedidosDataSet;
        private System.Windows.Forms.BindingSource itensPedidoBindingSource1;
        private Controle_PedidosDataSetTableAdapters.Itens_PedidoTableAdapter itens_PedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ToolStrip selectItemIDToolStrip;
        private System.Windows.Forms.ToolStripLabel iD_PedToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iD_PedToolStripTextBox;
        private System.Windows.Forms.ToolStripButton selectItemIDToolStripButton;
        private System.Windows.Forms.ToolStrip selectItemID1ToolStrip;
        private System.Windows.Forms.ToolStripLabel iD_PedToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox iD_PedToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton selectItemID1ToolStripButton;
    }
}