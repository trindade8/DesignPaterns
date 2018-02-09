namespace DesignPaterns
{
    partial class uiForm
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
            this.txtValorOrcamento = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorICMS = new System.Windows.Forms.TextBox();
            this.txtValorISS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorICCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorOrcamento
            // 
            this.txtValorOrcamento.Location = new System.Drawing.Point(30, 45);
            this.txtValorOrcamento.Name = "txtValorOrcamento";
            this.txtValorOrcamento.Size = new System.Drawing.Size(228, 20);
            this.txtValorOrcamento.TabIndex = 0;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(30, 85);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(228, 23);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ICMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISS";
            // 
            // txtValorICMS
            // 
            this.txtValorICMS.Location = new System.Drawing.Point(30, 143);
            this.txtValorICMS.Name = "txtValorICMS";
            this.txtValorICMS.Size = new System.Drawing.Size(57, 20);
            this.txtValorICMS.TabIndex = 4;
            // 
            // txtValorISS
            // 
            this.txtValorISS.Location = new System.Drawing.Point(197, 142);
            this.txtValorISS.Name = "txtValorISS";
            this.txtValorISS.Size = new System.Drawing.Size(61, 20);
            this.txtValorISS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Orcamento";
            // 
            // txtValorICCC
            // 
            this.txtValorICCC.Location = new System.Drawing.Point(115, 143);
            this.txtValorICCC.Name = "txtValorICCC";
            this.txtValorICCC.Size = new System.Drawing.Size(57, 20);
            this.txtValorICCC.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ICCC";
            // 
            // uiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtValorICCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorISS);
            this.Controls.Add(this.txtValorICMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtValorOrcamento);
            this.Name = "uiForm";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorOrcamento;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorICMS;
        private System.Windows.Forms.TextBox txtValorISS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorICCC;
        private System.Windows.Forms.Label label4;
    }
}

