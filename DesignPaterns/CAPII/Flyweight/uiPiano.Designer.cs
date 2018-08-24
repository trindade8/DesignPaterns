namespace DesignPaterns.CAPII.Flyweight
{
    partial class uiPiano
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
            this.listNotas = new System.Windows.Forms.ListBox();
            this.listNotasMusica = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbxMusicasExemplo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregarMusicaExemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNotas
            // 
            this.listNotas.AllowDrop = true;
            this.listNotas.FormattingEnabled = true;
            this.listNotas.Items.AddRange(new object[] {
            "Teste,",
            "um,",
            "dois,"});
            this.listNotas.Location = new System.Drawing.Point(12, 86);
            this.listNotas.Name = "listNotas";
            this.listNotas.Size = new System.Drawing.Size(151, 160);
            this.listNotas.TabIndex = 0;
            this.listNotas.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listNotas.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.listNotas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listNotas_MouseDown);
            // 
            // listNotasMusica
            // 
            this.listNotasMusica.AllowDrop = true;
            this.listNotasMusica.FormattingEnabled = true;
            this.listNotasMusica.Location = new System.Drawing.Point(194, 86);
            this.listNotasMusica.Name = "listNotasMusica";
            this.listNotasMusica.Size = new System.Drawing.Size(159, 160);
            this.listNotasMusica.TabIndex = 1;
            this.listNotasMusica.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listNotasMusica.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.listNotasMusica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listNotas_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notas Disponiveis";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(191, 57);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(162, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbxMusicasExemplo
            // 
            this.cbxMusicasExemplo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMusicasExemplo.FormattingEnabled = true;
            this.cbxMusicasExemplo.Location = new System.Drawing.Point(12, 25);
            this.cbxMusicasExemplo.Name = "cbxMusicasExemplo";
            this.cbxMusicasExemplo.Size = new System.Drawing.Size(162, 21);
            this.cbxMusicasExemplo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Musicas de Exemplo : ";
            // 
            // btnCarregarMusicaExemplo
            // 
            this.btnCarregarMusicaExemplo.Location = new System.Drawing.Point(191, 23);
            this.btnCarregarMusicaExemplo.Name = "btnCarregarMusicaExemplo";
            this.btnCarregarMusicaExemplo.Size = new System.Drawing.Size(162, 23);
            this.btnCarregarMusicaExemplo.TabIndex = 6;
            this.btnCarregarMusicaExemplo.Text = "Carregar Exemplo";
            this.btnCarregarMusicaExemplo.UseVisualStyleBackColor = true;
            this.btnCarregarMusicaExemplo.Click += new System.EventHandler(this.btnCarregarMusicaExemplo_Click);
            // 
            // uiPiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 266);
            this.Controls.Add(this.btnCarregarMusicaExemplo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMusicasExemplo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listNotasMusica);
            this.Controls.Add(this.listNotas);
            this.Name = "uiPiano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiPiano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNotas;
        private System.Windows.Forms.ListBox listNotasMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cbxMusicasExemplo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregarMusicaExemplo;
    }
}