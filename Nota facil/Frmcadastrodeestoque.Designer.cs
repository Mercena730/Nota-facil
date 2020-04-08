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
            this.Lblcategoria = new System.Windows.Forms.Label();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.dgv_estoque = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolatr
            // 
            this.btnvolatr.Location = new System.Drawing.Point(317, 85);
            this.btnvolatr.Name = "btnvolatr";
            this.btnvolatr.Size = new System.Drawing.Size(80, 33);
            this.btnvolatr.TabIndex = 0;
            this.btnvolatr.Text = "Voltar";
            this.btnvolatr.UseVisualStyleBackColor = true;
            this.btnvolatr.Click += new System.EventHandler(this.btnvolatr_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(126, 24);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(225, 22);
            this.txtdescricao.TabIndex = 1;
            // 
            // Lbldescao
            // 
            this.Lbldescao.AutoSize = true;
            this.Lbldescao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldescao.Location = new System.Drawing.Point(12, 19);
            this.Lbldescao.Name = "Lbldescao";
            this.Lbldescao.Size = new System.Drawing.Size(108, 27);
            this.Lbldescao.TabIndex = 2;
            this.Lbldescao.Text = "Descrição";
            // 
            // Lblvalor
            // 
            this.Lblvalor.AutoSize = true;
            this.Lblvalor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblvalor.Location = new System.Drawing.Point(368, 20);
            this.Lblvalor.Name = "Lblvalor";
            this.Lblvalor.Size = new System.Drawing.Size(62, 27);
            this.Lblvalor.TabIndex = 4;
            this.Lblvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(436, 27);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(225, 22);
            this.txtvalor.TabIndex = 3;
            // 
            // Lblcategoria
            // 
            this.Lblcategoria.AutoSize = true;
            this.Lblcategoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcategoria.Location = new System.Drawing.Point(957, 26);
            this.Lblcategoria.Name = "Lblcategoria";
            this.Lblcategoria.Size = new System.Drawing.Size(105, 27);
            this.Lblcategoria.TabIndex = 6;
            this.Lblcategoria.Text = "Categoria";
            // 
            // cbocategoria
            // 
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(1071, 26);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(225, 24);
            this.cbocategoria.TabIndex = 7;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(126, 85);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(80, 33);
            this.BtnNovo.TabIndex = 8;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // Btncadastra
            // 
            this.Btncadastra.Location = new System.Drawing.Point(221, 85);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(80, 33);
            this.Btncadastra.TabIndex = 9;
            this.Btncadastra.Text = "Cadastra";
            this.Btncadastra.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(416, 85);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 33);
            this.BtnDeletar.TabIndex = 10;
            this.BtnDeletar.Text = "Excluir";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // btncanc
            // 
            this.btncanc.Location = new System.Drawing.Point(514, 85);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(80, 33);
            this.btncanc.TabIndex = 11;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = true;
            // 
            // dgv_estoque
            // 
            this.dgv_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estoque.Location = new System.Drawing.Point(43, 141);
            this.dgv_estoque.Name = "dgv_estoque";
            this.dgv_estoque.RowHeadersWidth = 51;
            this.dgv_estoque.RowTemplate.Height = 24;
            this.dgv_estoque.Size = new System.Drawing.Size(1247, 389);
            this.dgv_estoque.TabIndex = 12;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(672, 21);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(37, 27);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(715, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(225, 22);
            this.txtid.TabIndex = 13;
            // 
            // Frmcadastrodeestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 558);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgv_estoque);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.Btncadastra);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.cbocategoria);
            this.Controls.Add(this.Lblcategoria);
            this.Controls.Add(this.Lblvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.Lbldescao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.btnvolatr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcadastrodeestoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro de estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolatr;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label Lbldescao;
        private System.Windows.Forms.Label Lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label Lblcategoria;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.DataGridView dgv_estoque;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
    }
}