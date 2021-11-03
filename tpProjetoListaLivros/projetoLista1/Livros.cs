using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Livros
    {
        public List<Livro> acervo;
        public Livros()
        {
            this.acervo = new List<Livro>();
        }

        public void adicionar(Livro livro) {
            acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro) { 
            foreach (Livro a in acervo)
            {
                if (a.Isbn == livro.Isbn)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
