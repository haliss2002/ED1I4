using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double escolha, fim = 0;
            Data data = new Data();
            Contato contato = new Contato();
            Livros book = new Livros();
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar livro (sintético)* ");
                Console.WriteLine("2. Pesquisar (analítico)**");
                Console.WriteLine("3. Pesquisar livro (analítico)**");
                Console.WriteLine("4. Adicionar exemplar");
                Console.WriteLine("5. Registrar empréstimo");
                Console.WriteLine("6. Registrar devolução");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    x = 10;
                }
                else if (x == 1)
                {
                    Console.Write("Digite isbn: ");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite titulo: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Digite o editora: ");
                    string editora = Console.ReadLine();                    
                    book.adicionar(new Livro(isbn, titulo, autor, editora));
                }
                else if (x == 2)
                {
                    Console.Write("Digite o isbn do  livro a ser pesquisado");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Isbn: "+book.pesquisar(new Livro(isbn, "", "", "")).Isbn);
                    Console.WriteLine("Titulo: " + book.pesquisar(new Livro(isbn, "", "", "")).Titulo);
                    Console.WriteLine("Autor: " + book.pesquisar(new Livro(isbn, "", "", "")).Autor);
                    Console.WriteLine("Editora: " + book.pesquisar(new Livro(isbn, "", "", "")).Editora);
                    Console.WriteLine("total de exemplares: " + book.pesquisar(new Livro(isbn, "", "", "")).qtdeExemplares());
                    Console.WriteLine("exemplares disponíveis: " + book.pesquisar(new Livro(isbn, "", "", "")).qtdeDisponiveis());
                    Console.WriteLine("emprestimos: " + book.pesquisar(new Livro(isbn, "", "", "")).qtdeEmprestimos());
                    Console.WriteLine("percentual de disponibilidade do título: " + book.pesquisar(new Livro(isbn, "", "", "")).percDisponibilidade());

                }
                else if (x == 3)
                {
                    Console.Write("Digite o isbn do  livro a ser pesquisado");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Isbn: " + book.pesquisar(new Livro(isbn, "", "", "")).Isbn);
                    Console.WriteLine("Titulo: " + book.pesquisar(new Livro(isbn, "", "", "")).Titulo);
                    Console.WriteLine("Autor: " + book.pesquisar(new Livro(isbn, "", "", "")).Autor);
                    Console.WriteLine("Editora: " + book.pesquisar(new Livro(isbn, "", "", "")).Editora);
                    Console.WriteLine("total de exemplares: " + book.pesquisar(new Livro(isbn, "", "", "")).qtdeExemplares());
                    Console.WriteLine("exemplares disponíveis: " + book.pesquisar(new Livro(isbn, "", "", "")).qtdeDisponiveis());
                    Console.WriteLine("emprestimos: " + book.pesquisar(new Livro(isbn, "", "", "")).qtdeEmprestimos());
                    Console.WriteLine("percentual de disponibilidade do título: " + book.pesquisar(new Livro(isbn, "", "", "")).percDisponibilidade());                    
                    foreach (Exemplar a in book.pesquisar(new Livro(isbn, "", "", "")).exemplares)
                    {
                        Console.WriteLine("exemplar tombo: "+a.Tombo);
                        Console.WriteLine("Emprestimo:");
                        foreach ( Emprestimo b in a.Emprestimos)
                        {
                            Console.WriteLine("data Emprestimo: " + b.DtEmprestimo);
                            Console.WriteLine("data Devolução: " + b.DtDevolucao);
                        }
                    }
                }
                else if (x == 4)
                {
                    Console.WriteLine("Digite o isbn do livro na qual ira adicionar o exemplar");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o tombo do exemplar");
                    int tombo = Convert.ToInt32(Console.ReadLine());
                    book.pesquisar(new Livro(isbn, "", "", "")).adicionarExemplar(new Exemplar(tombo));
                }
                else if (x == 5)
                {
                    Console.WriteLine("Digite o isbn do livro na qual ira pegar emprestado");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o tombo do exemplar");
                    int tombo = Convert.ToInt32(Console.ReadLine());
                    book.pesquisar(new Livro(isbn, "", "", "")).exemplares.Find(h => h.Tombo == tombo).emprestar() ;                        
                }
                else
                {
                    Console.WriteLine("O numero digitado é invalido.");
                }
            } while(x!=0);
        }
    }
}
