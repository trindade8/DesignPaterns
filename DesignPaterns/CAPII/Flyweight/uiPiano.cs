using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPaterns.CAPII.Flyweight
{
    public partial class uiPiano : Form
    {

        List<Musica> ListExemplos = new List<Musica>();


        public uiPiano()
        {
            InitializeComponent();
            LoadListaNotasMusicais();
            LoadComboExemplos();
        }


        private void LoadListaNotasMusicais()
        {
            List<String> lista = NotasMusicais.getNameNotas();
            listNotas.DataSource = lista;
        }

        private void LoadComboExemplos()
        {
            this.ListExemplos = Piano.getExemplosMusicas();
            this.cbxMusicasExemplo.DataSource = this.ListExemplos;
            this.cbxMusicasExemplo.DisplayMember = "Nome";
            //this.cbxMusicasExemplo.ValueMember = "Notas";
        }

        private void listNotas_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox ListOrigem = sender as ListBox;
            if (ListOrigem != null && ListOrigem.SelectedItem != null)
                DoDragDrop(sender, DragDropEffects.Move);
        }

        private void listBox_DragOver(Object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            var listBoxOrigem = e.Data.GetData(typeof(ListBox)) as ListBox;
            var listBoxDestino = sender as ListBox;
            if (listBoxOrigem != null && listBoxDestino != null)
            {

                try
                {
                    if (listBoxOrigem.Name.Equals("listNotasMusica"))
                        listBoxOrigem.Items.Remove(listBoxOrigem.SelectedItem);
                    else
                        listBoxDestino.Items.Add(listBoxOrigem.SelectedItem);
                }
                catch (Exception exp )
                {

                    
                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Piano Mozart = new Piano();

            NotasMusicais nm = new NotasMusicais();
            
            int x = 0;
            foreach( var item in this.listNotasMusica.Items)
            {

                string nameItem = this.listNotasMusica.GetItemText(item);
                INota nota = nm.Pega(nameItem);
                if (nota != null)
                    MessageBox.Show(nota.GetType().Name + "-" + nota.Frequencia);
             
                
            }
        }

        private void btnCarregarMusicaExemplo_Click(object sender, EventArgs e)
        {
            var musica = this.ListExemplos[this.cbxMusicasExemplo.SelectedIndex];
            if (musica != null)
            {
                this.listNotasMusica.Items.Clear();
                List<String> notasMusica = musica.getNomeNotasDaMusica();
                
                if (notasMusica != null)
                {
                    this.listNotasMusica.Items.AddRange(musica.Notas.ToArray());
                     
                }

            }

        }

        
    }
}
