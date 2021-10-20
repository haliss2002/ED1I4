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
            Contatos contatos = new Contatos();
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contatos");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    x = 10;
                }
                else if (x == 1)
                {
                    Console.Write("Digite email: ");
                    string email = Console.ReadLine();
                    Console.Write("Digite nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite telefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Digite o dia: ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o mes: ");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o ano: ");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    data = new Data(dia, mes, ano);
                    contato = new Contato(email, nome, telefone, data);
                    Console.WriteLine(contatos.adicionar(contato));
                }
                else if (x == 2)
                {
                    Contato pesquisar = new Contato();
                    Console.Write("Digite o email a ser pesquisado: ");
                    string emailPesquisar = Console.ReadLine();
                    pesquisar.email = emailPesquisar;
                    Console.WriteLine(contatos.pesquisar(pesquisar).ToString());
                }
                else if (x == 3)
                {
                    Console.WriteLine(contatos.alterar(contato));
                }
                else if (x == 4)
                {
                    Console.WriteLine(contatos.remover(contato));
                }
                else if (x == 5)
                {
                    foreach (Contato ctt in contatos.agenda)
                    {
                        Console.WriteLine(ctt.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("O numero digitado é invalido.");
                }
            } while(x!=0);
        }
    }
}
