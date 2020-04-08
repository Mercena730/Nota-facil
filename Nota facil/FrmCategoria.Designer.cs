namespace Nota_facil
{
    partial class FrmCategoria
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.btncanc = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.Lblcategoria = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btnvolatr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncanc
            // 
            this.btncanc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncanc.Location = new System.Drawing.Point(328, 229);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(80, 33);
            this.btncanc.TabIndex = 23;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeletar.Location = new System.Drawing.Point(328, 279);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 33);
            this.BtnDeletar.TabIndex = 22;
            this.BtnDeletar.Text = "Excluir";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // Btncadastra
            // 
            this.Btncadastra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncadastra.Location = new System.Drawing.Point(328, 379);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(80, 33);
            this.Btncadastra.TabIndex = 21;
            this.Btncadastra.Text = "Cadastrar";
            this.Btncadastra.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Location = new System.Drawing.Point(328, 180);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(80, 33);
            this.BtnNovo.TabIndex = 20;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // Lblcategoria
            // 
            this.Lblcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblcategoria.AutoSize = true;
            this.Lblcategoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcategoria.Location = new System.Drawing.Point(323, 36);
            this.Lblcategoria.Name = "Lblcategoria";
            this.Lblcategoria.Size = new System.Drawing.Size(105, 27);
            this.Lblcategoria.TabIndex = 15;
            this.Lblcategoria.Text = "Categoria";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcategoria.Location = new System.Drawing.Point(434, 40);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(225, 22);
            this.txtcategoria.TabIndex = 14;
            // 
            // btnvolatr
            // 
            this.btnvolatr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvolatr.Location = new System.Drawing.Point(328, 330);
            this.btnvolatr.Name = "btnvolatr";
            this.btnvolatr.Size = new System.Drawing.Size(80, 33);
            this.btnvolatr.TabIndex = 13;
            this.btnvolatr.Text = "Voltar";
            this.btnvolatr.UseVisualStyleBackColor = true;
            this.btnvolatr.Click += new System.EventHandler(this.btnvolatr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 562);
            this.dataGridView1.TabIndex = 24;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Nota_facil.Categoria);
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
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.Btncadastra);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.Lblcategoria);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.btnvolatr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label Lblcategoria;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnvolatr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desccategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}