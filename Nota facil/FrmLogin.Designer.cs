namespace Nota_facil
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.Lblsenha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbltmp = new System.Windows.Forms.Label();
            this.TMtemp = new System.Windows.Forms.Timer(this.components);
            this.Btnsair = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.Btncadastra = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lblsenha
            // 
            this.Lblsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lblsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblsenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lblsenha.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsenha.ForeColor = System.Drawing.Color.White;
            this.Lblsenha.Location = new System.Drawing.Point(218, 131);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(267, 48);
            this.Lblsenha.TabIndex = 3;
            this.Lblsenha.Text = "Insira seu login";
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsenha.BackColor = System.Drawing.Color.White;
            this.txtsenha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(218, 286);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(465, 42);
            this.txtsenha.TabIndex = 5;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlogin.BackColor = System.Drawing.SystemColors.Window;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.Location = new System.Drawing.Point(705, 366);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 52);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbltmp
            // 
            this.lbltmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltmp.AutoSize = true;
            this.lbltmp.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltmp.Location = new System.Drawing.Point(761, 115);
            this.lbltmp.Name = "lbltmp";
            this.lbltmp.Size = new System.Drawing.Size(94, 37);
            this.lbltmp.TabIndex = 7;
            this.lbltmp.Text = "00:00";
            this.lbltmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltmp.Visible = false;
            // 
            // TMtemp
            // 
            this.TMtemp.Interval = 1000;
            this.TMtemp.Tick += new System.EventHandler(this.TMtemp_Tick);
            // 
            // Btnsair
            // 
            this.Btnsair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnsair.BackColor = System.Drawing.Color.White;
            this.Btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnsair.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsair.Image = ((System.Drawing.Image)(resources.GetObject("Btnsair.Image")));
            this.Btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnsair.Location = new System.Drawing.Point(597, 366);
            this.Btnsair.Name = "Btnsair";
            this.Btnsair.Size = new System.Drawing.Size(102, 52);
            this.Btnsair.TabIndex = 9;
            this.Btnsair.Text = "Sair";
            this.Btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnsair.UseVisualStyleBackColor = false;
            this.Btnsair.Click += new System.EventHandler(this.Btnsair_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlogin.BackColor = System.Drawing.Color.White;
            this.txtlogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(218, 192);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(465, 42);
            this.txtlogin.TabIndex = 10;
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btncadastra
            // 
            this.Btncadastra.BackColor = System.Drawing.SystemColors.Window;
            this.Btncadastra.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncadastra.Image = ((System.Drawing.Image)(resources.GetObject("Btncadastra.Image")));
            this.Btncadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncadastra.Location = new System.Drawing.Point(768, 535);
            this.Btncadastra.Name = "Btncadastra";
            this.Btncadastra.Size = new System.Drawing.Size(256, 88);
            this.Btncadastra.TabIndex = 11;
            this.Btncadastra.Text = "cadastra";
            this.Btncadastra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncadastra.UseVisualStyleBackColor = false;
            this.Btncadastra.Click += new System.EventHandler(this.Btncadastra_Click);
            // 
            // senha
            // 
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.senha.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.Color.White;
            this.senha.Location = new System.Drawing.Point(218, 237);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(278, 48);
            this.senha.TabIndex = 12;
            this.senha.Text = "Insira sua senha";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 649);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.Btncadastra);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.Btnsair);
            this.Controls.Add(this.lbltmp);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.Lblsenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lblsenha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbltmp;
        private System.Windows.Forms.Timer TMtemp;
        private System.Windows.Forms.Button Btnsair;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Button Btncadastra;
        private System.Windows.Forms.Label senha;
    }
}