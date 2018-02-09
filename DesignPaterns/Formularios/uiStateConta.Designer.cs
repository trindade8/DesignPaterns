namespace DesignPaterns.Formularios
{
    partial class uiStateConta
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
            this.txtValorOperacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.btnSaca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSaldoConta = new System.Windows.Forms.Label();
            this.lblNomeTitularConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorOperacao
            // 
            this.txtValorOperacao.Location = new System.Drawing.Point(52, 122);
            this.txtValorOperacao.Name = "txtValorOperacao";
            this.txtValorOperacao.Size = new System.Drawing.Size(156, 20);
            this.txtValorOperacao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Operação";
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(133, 148);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(75, 23);
            this.btnDeposita.TabIndex = 2;
            this.btnDeposita.Text = "Deposita";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // btnSaca
            // 
            this.btnSaca.Location = new System.Drawing.Point(52, 148);
            this.btnSaca.Name = "btnSaca";
            this.btnSaca.Size = new System.Drawing.Size(75, 23);
            this.btnSaca.TabIndex = 3;
            this.btnSaca.Text = "Saca";
            this.btnSaca.UseVisualStyleBackColor = true;
            this.btnSaca.Click += new System.EventHandler(this.btnSaca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo Conta :";
            // 
            // labelSaldoConta
            // 
            this.labelSaldoConta.AutoSize = true;
            this.labelSaldoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoConta.Location = new System.Drawing.Point(133, 60);
            this.labelSaldoConta.Name = "labelSaldoConta";
            this.labelSaldoConta.Size = new System.Drawing.Size(44, 20);
            this.labelSaldoConta.TabIndex = 5;
            this.labelSaldoConta.Text = "0,00";
            // 
            // lblNomeTitularConta
            // 
            this.lblNomeTitularConta.AutoSize = true;
            this.lblNomeTitularConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTitularConta.Location = new System.Drawing.Point(55, 22);
            this.lblNomeTitularConta.Name = "lblNomeTitularConta";
            this.lblNomeTitularConta.Size = new System.Drawing.Size(153, 20);
            this.lblNomeTitularConta.TabIndex = 6;
            this.lblNomeTitularConta.Text = "NomeTitularConta";
            // 
            // uiStateConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 191);
            this.Controls.Add(this.lblNomeTitularConta);
            this.Controls.Add(this.labelSaldoConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaca);
            this.Controls.Add(this.btnDeposita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorOperacao);
            this.Name = "uiStateConta";
            this.Text = "State Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorOperacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.Button btnSaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSaldoConta;
        private System.Windows.Forms.Label lblNomeTitularConta;
    }
}