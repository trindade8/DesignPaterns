namespace DesignPaterns.Formularios
{
    partial class uiDesconto
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnClearItens = new System.Windows.Forms.Button();
            this.btnAplicaDesconto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalOrcamento = new System.Windows.Forms.TextBox();
            this.txtValorNewItem = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfoDesconto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStatusOrcamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAplicaDescontoStatus = new System.Windows.Forms.Button();
            this.btnApplyDescontoStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(41, 96);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(87, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClearItens
            // 
            this.btnClearItens.Location = new System.Drawing.Point(147, 96);
            this.btnClearItens.Name = "btnClearItens";
            this.btnClearItens.Size = new System.Drawing.Size(86, 23);
            this.btnClearItens.TabIndex = 4;
            this.btnClearItens.Text = "Remover Itens";
            this.btnClearItens.UseVisualStyleBackColor = true;
            this.btnClearItens.Click += new System.EventHandler(this.btnClearItens_Click);
            // 
            // btnAplicaDesconto
            // 
            this.btnAplicaDesconto.Location = new System.Drawing.Point(41, 126);
            this.btnAplicaDesconto.Name = "btnAplicaDesconto";
            this.btnAplicaDesconto.Size = new System.Drawing.Size(192, 23);
            this.btnAplicaDesconto.TabIndex = 5;
            this.btnAplicaDesconto.Text = "Aplicar Desconto";
            this.btnAplicaDesconto.UseVisualStyleBackColor = true;
            this.btnAplicaDesconto.Click += new System.EventHandler(this.btnAplicaDesconto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Orçamento";
            // 
            // txtTotalOrcamento
            // 
            this.txtTotalOrcamento.Location = new System.Drawing.Point(41, 193);
            this.txtTotalOrcamento.Name = "txtTotalOrcamento";
            this.txtTotalOrcamento.ReadOnly = true;
            this.txtTotalOrcamento.Size = new System.Drawing.Size(192, 20);
            this.txtTotalOrcamento.TabIndex = 6;
            // 
            // txtValorNewItem
            // 
            this.txtValorNewItem.Location = new System.Drawing.Point(41, 70);
            this.txtValorNewItem.Name = "txtValorNewItem";
            this.txtValorNewItem.Size = new System.Drawing.Size(192, 20);
            this.txtValorNewItem.TabIndex = 2;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(42, 248);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(192, 20);
            this.txtDesconto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desconto";
            // 
            // lblInfoDesconto
            // 
            this.lblInfoDesconto.AutoSize = true;
            this.lblInfoDesconto.Location = new System.Drawing.Point(75, 275);
            this.lblInfoDesconto.Name = "lblInfoDesconto";
            this.lblInfoDesconto.Size = new System.Drawing.Size(34, 13);
            this.lblInfoDesconto.TabIndex = 8;
            this.lblInfoDesconto.Text = "Info : ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor :";
            // 
            // cbxStatusOrcamento
            // 
            this.cbxStatusOrcamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatusOrcamento.FormattingEnabled = true;
            this.cbxStatusOrcamento.Location = new System.Drawing.Point(41, 307);
            this.cbxStatusOrcamento.Name = "cbxStatusOrcamento";
            this.cbxStatusOrcamento.Size = new System.Drawing.Size(193, 21);
            this.cbxStatusOrcamento.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status : ";
            // 
            // btnAplicaDescontoStatus
            // 
            this.btnAplicaDescontoStatus.Location = new System.Drawing.Point(41, 333);
            this.btnAplicaDescontoStatus.Name = "btnAplicaDescontoStatus";
            this.btnAplicaDescontoStatus.Size = new System.Drawing.Size(193, 23);
            this.btnAplicaDescontoStatus.TabIndex = 14;
            this.btnAplicaDescontoStatus.Text = "Aplicar  Status";
            this.btnAplicaDescontoStatus.UseVisualStyleBackColor = true;
            this.btnAplicaDescontoStatus.Click += new System.EventHandler(this.btnAplicaDescontoStatus_Click);
            // 
            // btnApplyDescontoStatus
            // 
            this.btnApplyDescontoStatus.Location = new System.Drawing.Point(40, 362);
            this.btnApplyDescontoStatus.Name = "btnApplyDescontoStatus";
            this.btnApplyDescontoStatus.Size = new System.Drawing.Size(193, 23);
            this.btnApplyDescontoStatus.TabIndex = 15;
            this.btnApplyDescontoStatus.Text = "Aplicar desconto Status";
            this.btnApplyDescontoStatus.UseVisualStyleBackColor = true;
            this.btnApplyDescontoStatus.Click += new System.EventHandler(this.btnApplyDescontoStatus_Click);
            // 
            // uiDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 425);
            this.Controls.Add(this.btnApplyDescontoStatus);
            this.Controls.Add(this.btnAplicaDescontoStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxStatusOrcamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblInfoDesconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValorNewItem);
            this.Controls.Add(this.txtTotalOrcamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAplicaDesconto);
            this.Controls.Add(this.btnClearItens);
            this.Controls.Add(this.btnAddItem);
            this.Name = "uiDesconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDesconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClearItens;
        private System.Windows.Forms.Button btnAplicaDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalOrcamento;
        private System.Windows.Forms.TextBox txtValorNewItem;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfoDesconto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxStatusOrcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAplicaDescontoStatus;
        private System.Windows.Forms.Button btnApplyDescontoStatus;
    }
}