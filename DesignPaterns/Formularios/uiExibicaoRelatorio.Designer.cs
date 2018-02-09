namespace DesignPaterns.Formularios
{
    partial class uiExibicaoRelatorio
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
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelatorio.Location = new System.Drawing.Point(0, 0);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(284, 261);
            this.txtRelatorio.TabIndex = 0;
            // 
            // uiExibicaoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRelatorio);
            this.Name = "uiExibicaoRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "uiExibicaoRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRelatorio;
    }
}