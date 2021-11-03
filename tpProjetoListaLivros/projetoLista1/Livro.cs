using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        public List<Exemplar> exemplares;

        public int Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public Livro()
        {
            this.isbn = 0;
            this.titulo = "";
            this.autor = "";
            this.editora = "";
            this.exemplares = new List<Exemplar>();
        }
        public Livro(int isbn,string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = new List<Exemplar>();
        }
        public void adicionarExemplar(Exemplar exemplar) {
           if (!Equals(exemplar)) 
           { exemplares.Add(exemplar); }
        }
        public int qtdeExemplares() {
            return exemplares.Count; }
        public int qtdeDisponiveis()
        {
            int count = 0;
            foreach (Exemplar e in exemplares)
            {
                if (e.disponivel())
                {
                    count++;
                }
            }
            return count;
        }

        public int qtdeEmprestimos() {
            int count = 0;
            foreach (Exemplar e in exemplares)
            {
                if (!e.disponivel())
                {
                    count++;
                }
            }
            return count;
        }
        public double percDisponibilidade() {
            double perc = 0;
            if (exemplares.Count != 0){
                perc = (qtdeEmprestimos() * 100) / exemplares.Count;
            }            
            return perc; 
        }

        public override bool Equals(object obj)
        {
            return this.exemplares.Equals(((Exemplar)obj).Tombo);
        }
    }
}
