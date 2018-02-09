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
            this.txticpp = new System.Windows.Forms.TextBox();
            this.txtikcv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIHIT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIMA = new System.Windows.Forms.TextBox();
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
            // txticpp
            // 
            this.txticpp.Location = new System.Drawing.Point(30, 183);
            this.txticpp.Name = "txticpp";
            this.txticpp.Size = new System.Drawing.Size(57, 20);
            this.txticpp.TabIndex = 9;
            // 
            // txtikcv
            // 
            this.txtikcv.Location = new System.Drawing.Point(115, 183);
            this.txtikcv.Name = "txtikcv";
            this.txtikcv.Size = new System.Drawing.Size(57, 20);
            this.txtikcv.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ICPP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IKCV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "IHIT";
            // 
            // txtIHIT
            // 
            this.txtIHIT.Location = new System.Drawing.Point(200, 183);
            this.txtIHIT.Name = "txtIHIT";
            this.txtIHIT.Size = new System.Drawing.Size(57, 20);
            this.txtIHIT.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "IMA";
            // 
            // txtIMA
            // 
            this.txtIMA.Location = new System.Drawing.Point(29, 222);
            this.txtIMA.Name = "txtIMA";
            this.txtIMA.Size = new System.Drawing.Size(55, 20);
            this.txtIMA.TabIndex = 15;
            // 
            // uiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIMA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIHIT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtikcv);
            this.Controls.Add(this.txticpp);
            this.Controls.Add(this.txtValorICCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorISS);
            this.Controls.Add(this.txtValorICMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtValorOrcamento);
            this.MaximizeBox = false;
            this.Name = "uiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox txticpp;
        private System.Windows.Forms.TextBox txtikcv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIHIT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIMA;
    }
}

