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
            this.BtnNovo = new System.Windows.Forms.Button();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.Label();
            this.cmbcatecoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnvolatr
            // 
            this.btnvolatr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnvolatr.Location = new System.Drawing.Point(204, 445);
            this.btnvolatr.Name = "btnvolatr";
            this.btnvolatr.Size = new System.Drawing.Size(80, 33);
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
            this.txtdescricao.Location = new System.Drawing.Point(137, 186);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(392, 39);
            this.txtdescricao.TabIndex = 1;
            // 
            // Lbldescao
            // 
            this.Lbldescao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbldescao.AutoSize = true;
            this.Lbldescao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldescao.Location = new System.Drawing.Point(11, 186);
            this.Lbldescao.Name = "Lbldescao";
            this.Lbldescao.Size = new System.Drawing.Size(108, 27);
            this.Lbldescao.TabIndex = 2;
            this.Lbldescao.Text = "Descrição";
            // 
            // Lblvalor
            // 
            this.Lblvalor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblvalor.AutoSize = true;
            this.Lblvalor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblvalor.Location = new System.Drawing.Point(57, 84);
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
            this.txtvalor.Location = new System.Drawing.Point(137, 84);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(392, 39);
            this.txtvalor.TabIndex = 3;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNovo.Location = new System.Drawing.Point(13, 445);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(80, 33);
            this.BtnNovo.TabIndex = 8;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // Btncadastra
            // 
            this.Btncadastra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btncadastra.Location = new System.Drawing.Point(108, 445);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(80, 33);
            this.Btncadastra.TabIndex = 9;
            this.Btncadastra.Text = "Cadastra";
            this.Btncadastra.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDeletar.Location = new System.Drawing.Point(303, 445);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 33);
            this.BtnDeletar.TabIndex = 10;
            this.BtnDeletar.Text = "Excluir";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // btncanc
            // 
            this.btncanc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncanc.Location = new System.Drawing.Point(401, 445);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(80, 33);
            this.btncanc.TabIndex = 11;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(82, 31);
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
            this.txtid.Location = new System.Drawing.Point(137, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(392, 39);
            this.txtid.TabIndex = 13;
            // 
            // categoria
            // 
            this.categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(14, 137);
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
            this.cmbcatecoria.Location = new System.Drawing.Point(137, 137);
            this.cmbcatecoria.Name = "cmbcatecoria";
            this.cmbcatecoria.Size = new System.Drawing.Size(392, 39);
            this.cmbcatecoria.TabIndex = 19;
            this.cmbcatecoria.Text = "...";
            // 
            // Frmcadastrodeestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 490);
            this.Controls.Add(this.cmbcatecoria);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.Btncadastra);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.Lblvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.Lbldescao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.btnvolatr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcadastrodeestoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro de estoque";
            this.Load += new System.EventHandler(this.Frmcadastrodeestoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolatr;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label Lbldescao;
        private System.Windows.Forms.Label Lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.ComboBox cmbcatecoria;
    }
}