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
            this.SuspendLayout();
            // 
            // btnvolatr
            // 
            this.btnvolatr.Location = new System.Drawing.Point(670, 382);
            this.btnvolatr.Name = "btnvolatr";
            this.btnvolatr.Size = new System.Drawing.Size(116, 56);
            this.btnvolatr.TabIndex = 0;
            this.btnvolatr.Text = "Voltar";
            this.btnvolatr.UseVisualStyleBackColor = true;
            this.btnvolatr.Click += new System.EventHandler(this.btnvolatr_Click);
            // 
            // Frmcadastrodeestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolatr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcadastrodeestoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro de estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolatr;
    }
}