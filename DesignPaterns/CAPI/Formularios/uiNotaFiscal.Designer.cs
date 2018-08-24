namespace DesignPaterns.Formularios
{
    partial class uiNotaFiscal
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
            this.btnCarregarNF = new System.Windows.Forms.Button();
            this.txtVisualzacaoNF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarregarNF
            // 
            this.btnCarregarNF.Location = new System.Drawing.Point(158, 24);
            this.btnCarregarNF.Name = "btnCarregarNF";
            this.btnCarregarNF.Size = new System.Drawing.Size(128, 23);
            this.btnCarregarNF.TabIndex = 0;
            this.btnCarregarNF.Text = "Carregar NF";
            this.btnCarregarNF.UseVisualStyleBackColor = true;
            this.btnCarregarNF.Click += new System.EventHandler(this.btnCarregarNF_Click);
            // 
            // txtVisualzacaoNF
            // 
            this.txtVisualzacaoNF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtVisualzacaoNF.Location = new System.Drawing.Point(0, 53);
            this.txtVisualzacaoNF.Multiline = true;
            this.txtVisualzacaoNF.Name = "txtVisualzacaoNF";
            this.txtVisualzacaoNF.ReadOnly = true;
            this.txtVisualzacaoNF.Size = new System.Drawing.Size(448, 369);
            this.txtVisualzacaoNF.TabIndex = 1;
            // 
            // uiNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 422);
            this.Controls.Add(this.txtVisualzacaoNF);
            this.Controls.Add(this.btnCarregarNF);
            this.Name = "uiNotaFiscal";
            this.Text = "Nota Fiscal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarNF;
        private System.Windows.Forms.TextBox txtVisualzacaoNF;
    }
}