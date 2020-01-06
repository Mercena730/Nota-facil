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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.textpesquisa = new System.Windows.Forms.TextBox();
            this.listclient = new System.Windows.Forms.ListBox();
            this.Btnconsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(512, 658);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 51);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisa.Image")));
            this.btnpesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpesquisa.Location = new System.Drawing.Point(701, 8);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(56, 50);
            this.btnpesquisa.TabIndex = 1;
            this.btnpesquisa.UseVisualStyleBackColor = true;
            // 
            // textpesquisa
            // 
            this.textpesquisa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textpesquisa.Location = new System.Drawing.Point(327, 20);
            this.textpesquisa.Name = "textpesquisa";
            this.textpesquisa.Size = new System.Drawing.Size(368, 22);
            this.textpesquisa.TabIndex = 2;
            // 
            // listclient
            // 
            this.listclient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listclient.FormattingEnabled = true;
            this.listclient.ItemHeight = 16;
            this.listclient.Location = new System.Drawing.Point(12, 50);
            this.listclient.Name = "listclient";
            this.listclient.Size = new System.Drawing.Size(383, 660);
            this.listclient.TabIndex = 3;
            // 
            // Btnconsultar
            // 
            this.Btnconsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnconsultar.Image = ((System.Drawing.Image)(resources.GetObject("Btnconsultar.Image")));
            this.Btnconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnconsultar.Location = new System.Drawing.Point(599, 658);
            this.Btnconsultar.Name = "Btnconsultar";
            this.Btnconsultar.Size = new System.Drawing.Size(142, 51);
            this.Btnconsultar.TabIndex = 4;
            this.Btnconsultar.Text = "Consultar cliente";
            this.Btnconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnconsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textpesquisa);
            this.panel1.Controls.Add(this.btnpesquisa);
            this.panel1.Location = new System.Drawing.Point(-16, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 111);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Location = new System.Drawing.Point(-16, 617);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 111);
            this.panel3.TabIndex = 8;
            // 
            // Frmcliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(753, 721);
            this.Controls.Add(this.Btnconsultar);
            this.Controls.Add(this.listclient);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Frmcliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox textpesquisa;
        private System.Windows.Forms.ListBox listclient;
        private System.Windows.Forms.Button Btnconsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}