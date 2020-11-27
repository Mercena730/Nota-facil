namespace Nota_facil
{
    partial class Frmcadastrodeestoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcadastrodeestoque));
            this.btnvolatr = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.Lbldescao = new System.Windows.Forms.Label();
            this.Lblvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.Label();
            this.cmbcatecoria = new System.Windows.Forms.ComboBox();
            this.pcbproduto = new System.Windows.Forms.PictureBox();
            this.Btnfoto = new System.Windows.Forms.Button();
            this.txtcaminho = new System.Windows.Forms.TextBox();
            this.lblcaminho = new System.Windows.Forms.Label();
            this.subcatgoria = new System.Windows.Forms.Label();
            this.cmbsubcategoria = new System.Windows.Forms.ComboBox();
            this.ofdl = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolatr
            // 
            this.btnvolatr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvolatr.Image = ((System.Drawing.Image)(resources.GetObject("btnvolatr.Image")));
            this.btnvolatr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolatr.Location = new System.Drawing.Point(12, 514);
            this.btnvolatr.Name = "btnvolatr";
            this.btnvolatr.Size = new System.Drawing.Size(143, 52);
            this.btnvolatr.TabIndex = 0;
            this.btnvolatr.Text = "Voltar";
            this.btnvolatr.UseVisualStyleBackColor = true;
            this.btnvolatr.Click += new System.EventHandler(this.btnvolatr_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescricao.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(19, 356);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(543, 39);
            this.txtdescricao.TabIndex = 1;
            // 
            // Lbldescao
            // 
            this.Lbldescao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbldescao.AutoSize = true;
            this.Lbldescao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldescao.Location = new System.Drawing.Point(14, 326);
            this.Lbldescao.Name = "Lbldescao";
            this.Lbldescao.Size = new System.Drawing.Size(183, 27);
            this.Lbldescao.TabIndex = 2;
            this.Lbldescao.Text = "Nome do Produto";
            // 
            // Lblvalor
            // 
            this.Lblvalor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblvalor.AutoSize = true;
            this.Lblvalor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblvalor.Location = new System.Drawing.Point(32, 95);
            this.Lblvalor.Name = "Lblvalor";
            this.Lblvalor.Size = new System.Drawing.Size(62, 27);
            this.Lblvalor.TabIndex = 4;
            this.Lblvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvalor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(19, 130);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(543, 39);
            this.txtvalor.TabIndex = 3;
            this.txtvalor.Text = "0.00";
            this.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btncadastra
            // 
            this.Btncadastra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncadastra.Image = ((System.Drawing.Image)(resources.GetObject("Btncadastra.Image")));
            this.Btncadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncadastra.Location = new System.Drawing.Point(12, 423);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(143, 49);
            this.Btncadastra.TabIndex = 9;
            this.Btncadastra.Text = "Cadastra";
            this.Btncadastra.UseVisualStyleBackColor = true;
            this.Btncadastra.Click += new System.EventHandler(this.Btncadastra_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.Image")));
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeletar.Location = new System.Drawing.Point(193, 514);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(133, 52);
            this.BtnDeletar.TabIndex = 10;
            this.BtnDeletar.Text = "Excluir";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btncanc
            // 
            this.btncanc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncanc.Image = ((System.Drawing.Image)(resources.GetObject("btncanc.Image")));
            this.btncanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncanc.Location = new System.Drawing.Point(197, 423);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(129, 49);
            this.btncanc.TabIndex = 11;
            this.btncanc.Text = "Cancelar";
            this.btncanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncanc.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(32, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(37, 27);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(19, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(543, 39);
            this.txtid.TabIndex = 13;
            // 
            // categoria
            // 
            this.categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(32, 172);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(105, 27);
            this.categoria.TabIndex = 18;
            this.categoria.Text = "Categoria";
            // 
            // cmbcatecoria
            // 
            this.cmbcatecoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbcatecoria.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcatecoria.FormattingEnabled = true;
            this.cmbcatecoria.Location = new System.Drawing.Point(19, 202);
            this.cmbcatecoria.Name = "cmbcatecoria";
            this.cmbcatecoria.Size = new System.Drawing.Size(543, 39);
            this.cmbcatecoria.TabIndex = 19;
            this.cmbcatecoria.Text = "Selecione a categoria";
            // 
            // pcbproduto
            // 
            this.pcbproduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcbproduto.Location = new System.Drawing.Point(584, 53);
            this.pcbproduto.Name = "pcbproduto";
            this.pcbproduto.Size = new System.Drawing.Size(298, 371);
            this.pcbproduto.TabIndex = 20;
            this.pcbproduto.TabStop = false;
            // 
            // Btnfoto
            // 
            this.Btnfoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnfoto.Image = ((System.Drawing.Image)(resources.GetObject("Btnfoto.Image")));
            this.Btnfoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnfoto.Location = new System.Drawing.Point(711, 500);
            this.Btnfoto.Name = "Btnfoto";
            this.Btnfoto.Size = new System.Drawing.Size(138, 66);
            this.Btnfoto.TabIndex = 21;
            this.Btnfoto.Text = "Escolher foto ";
            this.Btnfoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnfoto.UseVisualStyleBackColor = true;
            this.Btnfoto.Click += new System.EventHandler(this.Btnfoto_Click);
            // 
            // txtcaminho
            // 
            this.txtcaminho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtcaminho.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtcaminho.Enabled = false;
            this.txtcaminho.Location = new System.Drawing.Point(568, 461);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(314, 22);
            this.txtcaminho.TabIndex = 22;
            // 
            // lblcaminho
            // 
            this.lblcaminho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblcaminho.AutoSize = true;
            this.lblcaminho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaminho.Location = new System.Drawing.Point(482, 460);
            this.lblcaminho.Name = "lblcaminho";
            this.lblcaminho.Size = new System.Drawing.Size(80, 22);
            this.lblcaminho.TabIndex = 28;
            this.lblcaminho.Text = "Caminho";
            // 
            // subcatgoria
            // 
            this.subcatgoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subcatgoria.AutoSize = true;
            this.subcatgoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcatgoria.Location = new System.Drawing.Point(28, 244);
            this.subcatgoria.Name = "subcatgoria";
            this.subcatgoria.Size = new System.Drawing.Size(147, 27);
            this.subcatgoria.TabIndex = 29;
            this.subcatgoria.Text = "Sub Categoria";
            // 
            // cmbsubcategoria
            // 
            this.cmbsubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbsubcategoria.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubcategoria.FormattingEnabled = true;
            this.cmbsubcategoria.Location = new System.Drawing.Point(19, 274);
            this.cmbsubcategoria.Name = "cmbsubcategoria";
            this.cmbsubcategoria.Size = new System.Drawing.Size(543, 39);
            this.cmbsubcategoria.TabIndex = 30;
            this.cmbsubcategoria.Text = "Selecione a sub categoria";
            // 
            // ofdl
            // 
            this.ofdl.FileName = "ofdl";
            // 
            // Frmcadastrodeestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 578);
            this.Controls.Add(this.cmbsubcategoria);
            this.Controls.Add(this.subcatgoria);
            this.Controls.Add(this.lblcaminho);
            this.Controls.Add(this.txtcaminho);
            this.Controls.Add(this.Btnfoto);
            this.Controls.Add(this.pcbproduto);
            this.Controls.Add(this.cmbcatecoria);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.Btncadastra);
            this.Controls.Add(this.Lblvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.Lbldescao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.btnvolatr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcadastrodeestoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro de estoque";
            this.Load += new System.EventHandler(this.Frmcadastrodeestoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolatr;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label Lbldescao;
        private System.Windows.Forms.Label Lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.ComboBox cmbcatecoria;
        private System.Windows.Forms.PictureBox pcbproduto;
        private System.Windows.Forms.Button Btnfoto;
        private System.Windows.Forms.TextBox txtcaminho;
        private System.Windows.Forms.Label lblcaminho;
        private System.Windows.Forms.Label subcatgoria;
        private System.Windows.Forms.ComboBox cmbsubcategoria;
        private System.Windows.Forms.OpenFileDialog ofdl;
    }
}