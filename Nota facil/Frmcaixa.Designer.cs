namespace Nota_facil
{
    partial class Frmcaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcaixa));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.dgv_estoque = new System.Windows.Forms.DataGridView();
            this.btncanc = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.LbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnIMPCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigodacategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnvoltar.Location = new System.Drawing.Point(640, 479);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(87, 33);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // dgv_estoque
            // 
            this.dgv_estoque.AllowUserToAddRows = false;
            this.dgv_estoque.AllowUserToDeleteRows = false;
            this.dgv_estoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_estoque.AutoGenerateColumns = false;
            this.dgv_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.codigodacategoriaDataGridViewTextBoxColumn});
            this.dgv_estoque.DataSource = this.produtoBindingSource;
            this.dgv_estoque.Location = new System.Drawing.Point(22, 147);
            this.dgv_estoque.Name = "dgv_estoque";
            this.dgv_estoque.ReadOnly = true;
            this.dgv_estoque.RowHeadersWidth = 51;
            this.dgv_estoque.RowTemplate.Height = 24;
            this.dgv_estoque.Size = new System.Drawing.Size(591, 545);
            this.dgv_estoque.TabIndex = 32;
            // 
            // btncanc
            // 
            this.btncanc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btncanc.Location = new System.Drawing.Point(640, 424);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(87, 33);
            this.btncanc.TabIndex = 31;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDeletar.Location = new System.Drawing.Point(640, 368);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(87, 33);
            this.BtnDeletar.TabIndex = 30;
            this.BtnDeletar.Text = "Excluir";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // Btncadastra
            // 
            this.Btncadastra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btncadastra.Location = new System.Drawing.Point(639, 245);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(88, 33);
            this.Btncadastra.TabIndex = 29;
            this.Btncadastra.Text = "Envia";
            this.Btncadastra.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnNovo.Location = new System.Drawing.Point(639, 185);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(87, 33);
            this.BtnNovo.TabIndex = 28;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // LbID
            // 
            this.LbID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbID.AutoSize = true;
            this.LbID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbID.Location = new System.Drawing.Point(17, 65);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(37, 27);
            this.LbID.TabIndex = 27;
            this.LbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Location = new System.Drawing.Point(60, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(232, 22);
            this.txtID.TabIndex = 26;
            // 
            // btnIMPCP
            // 
            this.btnIMPCP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIMPCP.Location = new System.Drawing.Point(640, 311);
            this.btnIMPCP.Name = "btnIMPCP";
            this.btnIMPCP.Size = new System.Drawing.Size(87, 33);
            this.btnIMPCP.TabIndex = 25;
            this.btnIMPCP.Text = "Imprimir ";
            this.btnIMPCP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quantidade";
            // 
            // txtquant
            // 
            this.txtquant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtquant.Location = new System.Drawing.Point(439, 66);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(174, 22);
            this.txtquant.TabIndex = 33;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Nota_facil.Produto);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigodacategoriaDataGridViewTextBoxColumn
            // 
            this.codigodacategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigodacategoriaDataGridViewTextBoxColumn.DataPropertyName = "Codigo da categoria";
            this.codigodacategoriaDataGridViewTextBoxColumn.HeaderText = "Codigo_da_categoria";
            this.codigodacategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigodacategoriaDataGridViewTextBoxColumn.Name = "codigodacategoriaDataGridViewTextBoxColumn";
            this.codigodacategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigodacategoriaDataGridViewTextBoxColumn.Width = 172;
            // 
            // Frmcaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.dgv_estoque);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.Btncadastra);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LbID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnIMPCP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridView dgv_estoque;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnIMPCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigodacategoriaDataGridViewTextBoxColumn;
    }
}