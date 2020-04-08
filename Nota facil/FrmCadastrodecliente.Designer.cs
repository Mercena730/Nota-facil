namespace Nota_facil
{
    partial class FrmCadastrodecliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrodecliente));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbar = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.blrua = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblNUmero = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.ofdl = new System.Windows.Forms.OpenFileDialog();
            this.btnesqimg = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.pccliente = new System.Windows.Forms.PictureBox();
            this.Btncadastro = new System.Windows.Forms.Button();
            this.txtcaminho = new System.Windows.Forms.TextBox();
            this.lblcaminho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pccliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(825, 629);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(84, 44);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcpf.BackColor = System.Drawing.Color.White;
            this.txtcpf.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(156, 144);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(378, 39);
            this.txtcpf.TabIndex = 3;
            this.txtcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcpf
            // 
            this.lblcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(87, 144);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(50, 33);
            this.lblcpf.TabIndex = 3;
            this.lblcpf.Text = "cpf";
            this.lblcpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 203);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(141, 33);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "indeficador";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(156, 201);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(378, 39);
            this.txtid.TabIndex = 4;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcep
            // 
            this.txtcep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcep.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(156, 42);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(378, 39);
            this.txtcep.TabIndex = 1;
            this.txtcep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcep_KeyPress);
            // 
            // lblcep
            // 
            this.lblcep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(75, 39);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(53, 33);
            this.lblcep.TabIndex = 7;
            this.lblcep.Text = "cep";
            this.lblcep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcidade
            // 
            this.txtcidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcidade.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(156, 313);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(378, 39);
            this.txtcidade.TabIndex = 6;
            this.txtcidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcidade
            // 
            this.lblcidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(59, 313);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(87, 33);
            this.lblcidade.TabIndex = 9;
            this.lblcidade.Text = "cidade";
            this.lblcidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbairro
            // 
            this.txtbairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbairro.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(156, 368);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(378, 39);
            this.txtbairro.TabIndex = 7;
            this.txtbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblbar
            // 
            this.lblbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblbar.AutoSize = true;
            this.lblbar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbar.Location = new System.Drawing.Point(51, 368);
            this.lblbar.Name = "lblbar";
            this.lblbar.Size = new System.Drawing.Size(86, 33);
            this.lblbar.TabIndex = 11;
            this.lblbar.Text = "Bairro";
            this.lblbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(156, 422);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(378, 39);
            this.txtRua.TabIndex = 8;
            this.txtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blrua
            // 
            this.blrua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blrua.AutoSize = true;
            this.blrua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blrua.Location = new System.Drawing.Point(68, 428);
            this.blrua.Name = "blrua";
            this.blrua.Size = new System.Drawing.Size(60, 33);
            this.blrua.TabIndex = 13;
            this.blrua.Text = "Rua";
            this.blrua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnumero
            // 
            this.txtnumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnumero.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(156, 476);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(378, 39);
            this.txtnumero.TabIndex = 9;
            this.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNUmero
            // 
            this.lblNUmero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNUmero.AutoSize = true;
            this.lblNUmero.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUmero.Location = new System.Drawing.Point(42, 478);
            this.lblNUmero.Name = "lblNUmero";
            this.lblNUmero.Size = new System.Drawing.Size(104, 33);
            this.lblNUmero.TabIndex = 15;
            this.lblNUmero.Text = "Numero";
            this.lblNUmero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(59, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 33);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtnome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(156, 89);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(378, 39);
            this.txtnome.TabIndex = 2;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ofdl
            // 
            this.ofdl.Multiselect = true;
            // 
            // btnesqimg
            // 
            this.btnesqimg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnesqimg.Image = ((System.Drawing.Image)(resources.GetObject("btnesqimg.Image")));
            this.btnesqimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnesqimg.Location = new System.Drawing.Point(717, 478);
            this.btnesqimg.Name = "btnesqimg";
            this.btnesqimg.Size = new System.Drawing.Size(217, 55);
            this.btnesqimg.TabIndex = 21;
            this.btnesqimg.Text = "Escolhar a imagem";
            this.btnesqimg.UseVisualStyleBackColor = true;
            this.btnesqimg.Click += new System.EventHandler(this.btnesqimg_Click);
            // 
            // lblestado
            // 
            this.lblestado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(59, 255);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(91, 33);
            this.lblestado.TabIndex = 23;
            this.lblestado.Text = "Estado";
            this.lblestado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtestado
            // 
            this.txtestado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtestado.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(156, 255);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(378, 39);
            this.txtestado.TabIndex = 5;
            this.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsair
            // 
            this.btnsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsair.Image = global::Nota_facil.Properties.Resources.sair;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(744, 629);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 44);
            this.btnsair.TabIndex = 25;
            this.btnsair.Text = "sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlimpar.Image = global::Nota_facil.Properties.Resources.limpar;
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpar.Location = new System.Drawing.Point(266, 521);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(154, 57);
            this.btnlimpar.TabIndex = 24;
            this.btnlimpar.Text = "Limpar campos";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // pccliente
            // 
            this.pccliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pccliente.Location = new System.Drawing.Point(692, 42);
            this.pccliente.Name = "pccliente";
            this.pccliente.Size = new System.Drawing.Size(325, 365);
            this.pccliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pccliente.TabIndex = 17;
            this.pccliente.TabStop = false;
            // 
            // Btncadastro
            // 
            this.Btncadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btncadastro.Image")));
            this.Btncadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncadastro.Location = new System.Drawing.Point(926, 629);
            this.Btncadastro.Name = "Btncadastro";
            this.Btncadastro.Size = new System.Drawing.Size(126, 44);
            this.Btncadastro.TabIndex = 10;
            this.Btncadastro.Text = "Cadastrar";
            this.Btncadastro.UseVisualStyleBackColor = true;
            this.Btncadastro.Click += new System.EventHandler(this.Btncadastro_Click);
            // 
            // txtcaminho
            // 
            this.txtcaminho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcaminho.Enabled = false;
            this.txtcaminho.Location = new System.Drawing.Point(661, 439);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(391, 22);
            this.txtcaminho.TabIndex = 26;
            // 
            // lblcaminho
            // 
            this.lblcaminho.AutoSize = true;
            this.lblcaminho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaminho.Location = new System.Drawing.Point(575, 438);
            this.lblcaminho.Name = "lblcaminho";
            this.lblcaminho.Size = new System.Drawing.Size(80, 22);
            this.lblcaminho.TabIndex = 27;
            this.lblcaminho.Text = "Caminho";
            // 
            // FrmCadastrodecliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1064, 685);
            this.Controls.Add(this.lblcaminho);
            this.Controls.Add(this.txtcaminho);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.btnesqimg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.pccliente);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblNUmero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.blrua);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbar);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.Btncadastro);
            this.Controls.Add(this.btnvoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrodecliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.FrmCadastrodecliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pccliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button Btncadastro;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbar;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label blrua;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblNUmero;
        private System.Windows.Forms.PictureBox pccliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.OpenFileDialog ofdl;
        private System.Windows.Forms.Button btnesqimg;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtcaminho;
        private System.Windows.Forms.Label lblcaminho;
    }
}