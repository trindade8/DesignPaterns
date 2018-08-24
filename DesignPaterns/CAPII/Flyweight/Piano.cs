using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.CAPII.Flyweight
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
                Console.Beep(nota.Frequencia, 300);
        }

        public static List<Musica> getExemplosMusicas()
        {
            List<Musica> musicas = new List<Musica>();
            String nomeMusica = "Sinfonia 40 - Mozart";
            string _notas = "fa,mi,mi,fa,mi,mi,fa,mi,mi,do,do,si,la,la,sol,fa,fa,mi,re,re,mi,re,re,mi,re,mi,re,re,si";
            Musica Sinfonia40 = new Musica(nomeMusica, _notas);

            musicas.Add(Sinfonia40);

            return musicas;


        }
    }

    public class Musica
    {
        public String Nome { get; set; }
        public List<INota> Notas { get; private set; }

        public Musica(string nome)
        {
            this.Nome = nome;
            this.Notas = new List<INota>();
        }

        public Musica(string nome, List<INota> nota) : this(nome)
        {
            this.Notas = nota;
        }

        public Musica(string nome, string stringNotas) : this(nome)
        {
            string[] notas = stringNotas.Split(',');
            NotasMusicais nm = new NotasMusicais();
            foreach (string nota in notas)
            {
                this.AddNota(nm.Pega(nota));
            }
        }

        
        public void AddNota(INota nota)
        {
            if (this.Notas == null)
                this.Notas = new List<INota>();

            this.Notas.Add(nota);
        }

        public List<String> getNomeNotasDaMusica()
        {
            List<string> notas = new List<string>();
            foreach (INota nota in this.Notas)
                notas.Add(nota.ToString());
            return notas;
        }



    }
}
