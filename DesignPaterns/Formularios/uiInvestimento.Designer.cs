namespace DesignPaterns
{
    partial class uiInvestimento
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorInvestido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConservador = new System.Windows.Forms.TextBox();
            this.txtModerado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArrojado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModerado = new System.Windows.Forms.Label();
            this.lnlArrojado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(22, 71);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(243, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorInvestido
            // 
            this.txtValorInvestido.Location = new System.Drawing.Point(22, 45);
            this.txtValorInvestido.Name = "txtValorInvestido";
            this.txtValorInvestido.Size = new System.Drawing.Size(243, 20);
            this.txtValorInvestido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conservador";
            // 
            // txtConservador
            // 
            this.txtConservador.Location = new System.Drawing.Point(25, 118);
            this.txtConservador.Name = "txtConservador";
            this.txtConservador.Size = new System.Drawing.Size(151, 20);
            this.txtConservador.TabIndex = 3;
            // 
            // txtModerado
            // 
            this.txtModerado.Location = new System.Drawing.Point(25, 157);
            this.txtModerado.Name = "txtModerado";
            this.txtModerado.Size = new System.Drawing.Size(151, 20);
            this.txtModerado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moderado";
            // 
            // txtArrojado
            // 
            this.txtArrojado.Location = new System.Drawing.Point(25, 196);
            this.txtArrojado.Name = "txtArrojado";
            this.txtArrojado.Size = new System.Drawing.Size(151, 20);
            this.txtArrojado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrojado";
            // 
            // lblModerado
            // 
            this.lblModerado.AutoSize = true;
            this.lblModerado.Location = new System.Drawing.Point(182, 160);
            this.lblModerado.Name = "lblModerado";
            this.lblModerado.Size = new System.Drawing.Size(34, 13);
            this.lblModerado.TabIndex = 8;
            this.lblModerado.Text = "Info : ";
            // 
            // lnlArrojado
            // 
            this.lnlArrojado.AutoSize = true;
            this.lnlArrojado.Location = new System.Drawing.Point(183, 199);
            this.lnlArrojado.Name = "lnlArrojado";
            this.lnlArrojado.Size = new System.Drawing.Size(31, 13);
            this.lnlArrojado.TabIndex = 9;
            this.lnlArrojado.Text = "Info :";
            // 
            // uiInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lnlArrojado);
            this.Controls.Add(this.lblModerado);
            this.Controls.Add(this.txtArrojado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModerado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConservador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorInvestido);
            this.Controls.Add(this.btnCalcular);
            this.Name = "uiInvestimento";
            this.Text = "uiInvestimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorInvestido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConservador;
        private System.Windows.Forms.TextBox txtModerado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArrojado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModerado;
        private System.Windows.Forms.Label lnlArrojado;
    }
}