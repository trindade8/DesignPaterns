namespace DesignPaterns.Formularios
{
    partial class uiRelatorio
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
            this.btnSimples = new System.Windows.Forms.Button();
            this.btnComplexo = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSimples
            // 
            this.btnSimples.Location = new System.Drawing.Point(23, 12);
            this.btnSimples.Name = "btnSimples";
            this.btnSimples.Size = new System.Drawing.Size(211, 23);
            this.btnSimples.TabIndex = 0;
            this.btnSimples.Text = "Relatório Simples";
            this.btnSimples.UseVisualStyleBackColor = true;
            this.btnSimples.Click += new System.EventHandler(this.btnSimples_Click);
            // 
            // btnComplexo
            // 
            this.btnComplexo.Location = new System.Drawing.Point(23, 42);
            this.btnComplexo.Name = "btnComplexo";
            this.btnComplexo.Size = new System.Drawing.Size(211, 23);
            this.btnComplexo.TabIndex = 1;
            this.btnComplexo.Text = "Relatório Complexo";
            this.btnComplexo.UseVisualStyleBackColor = true;
            this.btnComplexo.Click += new System.EventHandler(this.btnComplexo_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(27, 88);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(207, 21);
            this.cmbFiltro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro";
            // 
            // uiRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnComplexo);
            this.Controls.Add(this.btnSimples);
            this.Name = "uiRelatorio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimples;
        private System.Windows.Forms.Button btnComplexo;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
    }
}