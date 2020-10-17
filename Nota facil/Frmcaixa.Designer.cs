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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcaixa));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.LbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnIMPCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.total = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnvoltar.Location = new System.Drawing.Point(490, 339);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(87, 33);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncanc
            // 
            this.btncanc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btncanc.Location = new System.Drawing.Point(490, 284);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(87, 33);
            this.btncanc.TabIndex = 31;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDeletar.Location = new System.Drawing.Point(490, 228);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(87, 33);
            this.BtnDeletar.TabIndex = 30;
            this.BtnDeletar.Text = "Excluir";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // Btncadastra
            // 
            this.Btncadastra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btncadastra.Location = new System.Drawing.Point(489, 105);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(88, 33);
            this.Btncadastra.TabIndex = 29;
            this.Btncadastra.Text = "Envia";
            this.Btncadastra.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnNovo.Location = new System.Drawing.Point(489, 45);
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
            this.LbID.Location = new System.Drawing.Point(602, 174);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(37, 27);
            this.LbID.TabIndex = 27;
            this.LbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Location = new System.Drawing.Point(645, 174);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(232, 22);
            this.txtID.TabIndex = 26;
            // 
            // btnIMPCP
            // 
            this.btnIMPCP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIMPCP.Location = new System.Drawing.Point(490, 171);
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
            this.label1.Location = new System.Drawing.Point(602, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quantidade";
            // 
            // txtquant
            // 
            this.txtquant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtquant.Location = new System.Drawing.Point(731, 212);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(174, 22);
            this.txtquant.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(51, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 628);
            this.listBox1.TabIndex = 35;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Times New Roman", 37.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(477, 601);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(265, 72);
            this.total.TabIndex = 36;
            this.total.Text = "TOTAL:";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Himalaya", 79.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.ForeColor = System.Drawing.Color.Black;
            this.subtotal.Location = new System.Drawing.Point(727, 539);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(388, 134);
            this.subtotal.TabIndex = 37;
            this.subtotal.Text = "R$ 00,00";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(724, 270);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(232, 24);
            this.cmbCliente.TabIndex = 38;
            this.cmbCliente.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cliente";
            // 
            // Frmcaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.btnvoltar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnIMPCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigodacategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
    }
}