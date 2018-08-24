namespace DesignPaterns.ChainOfResponsability.Conta
{
    partial class uiFormataConta
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultadoProcessamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFormato = new System.Windows.Forms.ComboBox();
            this.btnCriaxml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(40, 54);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(198, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(40, 89);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(75, 20);
            this.txtValor.TabIndex = 1;
            // 
            // txtResultadoProcessamento
            // 
            this.txtResultadoProcessamento.Location = new System.Drawing.Point(40, 152);
            this.txtResultadoProcessamento.Multiline = true;
            this.txtResultadoProcessamento.Name = "txtResultadoProcessamento";
            this.txtResultadoProcessamento.Size = new System.Drawing.Size(198, 97);
            this.txtResultadoProcessamento.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Formatar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome: ";
            // 
            // comboFormato
            // 
            this.comboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormato.FormattingEnabled = true;
            this.comboFormato.Location = new System.Drawing.Point(42, 125);
            this.comboFormato.Name = "comboFormato";
            this.comboFormato.Size = new System.Drawing.Size(195, 21);
            this.comboFormato.TabIndex = 6;
            // 
            // btnCriaxml
            // 
            this.btnCriaxml.Location = new System.Drawing.Point(40, 256);
            this.btnCriaxml.Name = "btnCriaxml";
            this.btnCriaxml.Size = new System.Drawing.Size(198, 23);
            this.btnCriaxml.TabIndex = 7;
            this.btnCriaxml.Text = "Gerar xml";
            this.btnCriaxml.UseVisualStyleBackColor = true;
            this.btnCriaxml.Click += new System.EventHandler(this.btnCriaxml_Click);
            // 
            // uiFormataConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.btnCriaxml);
            this.Controls.Add(this.comboFormato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultadoProcessamento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtnome);
            this.Name = "uiFormataConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Conta";
            this.Load += new System.EventHandler(this.uiFormConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultadoProcessamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboFormato;
        private System.Windows.Forms.Button btnCriaxml;
    }
}