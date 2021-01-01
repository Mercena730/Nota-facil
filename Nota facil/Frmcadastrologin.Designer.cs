
namespace Nota_facil
{
    partial class Frmcadastrologin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcadastrologin));
            this.lbllogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.btncad = new System.Windows.Forms.Button();
            this.chteste = new System.Windows.Forms.CheckBox();
            this.btnpagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(45, 66);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(101, 46);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(647, 53);
            this.textBox1.TabIndex = 1;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(43, 243);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = 'º';
            this.txtsenha.Size = new System.Drawing.Size(647, 53);
            this.txtsenha.TabIndex = 2;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(35, 181);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(111, 46);
            this.lblsenha.TabIndex = 4;
            this.lblsenha.Text = "senha";
            // 
            // btncad
            // 
            this.btncad.Image = ((System.Drawing.Image)(resources.GetObject("btncad.Image")));
            this.btncad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncad.Location = new System.Drawing.Point(511, 452);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(220, 61);
            this.btncad.TabIndex = 5;
            this.btncad.Text = "Cadastra";
            this.btncad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // chteste
            // 
            this.chteste.AutoSize = true;
            this.chteste.Location = new System.Drawing.Point(12, 544);
            this.chteste.Name = "chteste";
            this.chteste.Size = new System.Drawing.Size(286, 50);
            this.chteste.TabIndex = 6;
            this.chteste.Text = "Testa programa";
            this.chteste.UseVisualStyleBackColor = true;
            // 
            // btnpagar
            // 
            this.btnpagar.Image = ((System.Drawing.Image)(resources.GetObject("btnpagar.Image")));
            this.btnpagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagar.Location = new System.Drawing.Point(546, 519);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(185, 61);
            this.btnpagar.TabIndex = 7;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpagar.UseVisualStyleBackColor = true;
            // 
            // Frmcadastrologin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 606);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.chteste);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbllogin);
            this.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Frmcadastrologin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "cadastro de login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.CheckBox chteste;
        private System.Windows.Forms.Button btnpagar;
    }
}