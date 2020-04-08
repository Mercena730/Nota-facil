namespace Nota_facil
{
    partial class Frmcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcliente));
            this.listclient = new System.Windows.Forms.ListBox();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.imgcliente = new System.Windows.Forms.PictureBox();
            this.txtdadoscliente = new System.Windows.Forms.TextBox();
            this.lblpes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // listclient
            // 
            this.listclient.FormattingEnabled = true;
            this.listclient.ItemHeight = 16;
            this.listclient.Location = new System.Drawing.Point(10, 66);
            this.listclient.Name = "listclient";
            this.listclient.Size = new System.Drawing.Size(347, 564);
            this.listclient.TabIndex = 1;
            this.listclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listclient_MouseClick);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpesquisa.Location = new System.Drawing.Point(441, 34);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(335, 22);
            this.txtpesquisa.TabIndex = 2;
            this.txtpesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpesquisa_KeyUp);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisa.Image")));
            this.btnpesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpesquisa.Location = new System.Drawing.Point(782, 24);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(103, 32);
            this.btnpesquisa.TabIndex = 4;
            this.btnpesquisa.Text = "Pesquisa";
            this.btnpesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // imgcliente
            // 
            this.imgcliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgcliente.Location = new System.Drawing.Point(1055, 89);
            this.imgcliente.Name = "imgcliente";
            this.imgcliente.Size = new System.Drawing.Size(192, 246);
            this.imgcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcliente.TabIndex = 6;
            this.imgcliente.TabStop = false;
            // 
            // txtdadoscliente
            // 
            this.txtdadoscliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdadoscliente.BackColor = System.Drawing.Color.Aqua;
            this.txtdadoscliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdadoscliente.Enabled = false;
            this.txtdadoscliente.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdadoscliente.Location = new System.Drawing.Point(371, 89);
            this.txtdadoscliente.Multiline = true;
            this.txtdadoscliente.Name = "txtdadoscliente";
            this.txtdadoscliente.Size = new System.Drawing.Size(678, 486);
            this.txtdadoscliente.TabIndex = 7;
            // 
            // lblpes
            // 
            this.lblpes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpes.AutoSize = true;
            this.lblpes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpes.Location = new System.Drawing.Point(450, -1);
            this.lblpes.Name = "lblpes";
            this.lblpes.Size = new System.Drawing.Size(326, 36);
            this.lblpes.TabIndex = 8;
            this.lblpes.Text = "insira nome do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clientes";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(1004, 581);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(80, 44);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnconsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnconsultar.Image")));
            this.btnconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultar.Location = new System.Drawing.Point(1102, 581);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(145, 44);
            this.btnconsultar.TabIndex = 11;
            this.btnconsultar.Text = "Consulta cliente";
            this.btnconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // Frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1259, 637);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpes);
            this.Controls.Add(this.txtdadoscliente);
            this.Controls.Add(this.imgcliente);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.listclient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.Frmcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listclient;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.PictureBox imgcliente;
        private System.Windows.Forms.TextBox txtdadoscliente;
        private System.Windows.Forms.Label lblpes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnconsultar;
    }
}