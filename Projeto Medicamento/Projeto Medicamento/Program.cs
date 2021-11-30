using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
               
                Medicamentos medicamentos = new Medicamentos();
                Console.WriteLine("0. Finalizar processo");
                Console.WriteLine("1. Cadastrar medicamento");
                Console.WriteLine("2. Consultar medicamento (sintético: informar dados1) ");
                Console.WriteLine("3. Consultar medicamento (analítico: informar dados1 + lotes2)");
                Console.WriteLine("4. Comprar medicamento (cadastrar lote) ");
                Console.WriteLine("5. Vender medicamento (abater do lote mais antigo)");
                Console.WriteLine("6. Listar medicamentos (informando dados sintéticos)");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    x = 10;
                }
                else if (x == 1)
                {
                    Console.WriteLine("Digite o id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite laboratorio: ");
                    string laboratorio = Console.ReadLine();
                    medicamentos.adicionar(new Medicamento(id, nome, laboratorio));
                }
                else if (x == 2)
                {
                    Console.WriteLine("Digite o id do Medicamento");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(medicamentos.pesquisar(new Medicamento(id,"","")).ToString());
                }
                else if (x == 3)
                {
                    Console.WriteLine("Digite o id do Medicamento");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(medicamentos.pesquisar(new Medicamento(id, "", "")).ToString());
                    foreach (Lote a in medicamentos.pesquisar(new Medicamento(id, "", "")).lotes)
                    {
                        Console.WriteLine(a.ToString());                        
                    }
                }
                else if (x == 4)
                {
                    Console.WriteLine("Digite o id do Medicamento");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o id do Lote");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a qtde do Lote");
                    int qtde = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o vencimento do Lote");
                    DateTime vec = Convert.ToDateTime(Console.ReadLine());
                    medicamentos.pesquisar(new Medicamento(id, "", "")).comprar(new Lote(id2,qtde,vec));
                }
                else if (x == 5)
                {
                    Console.WriteLine("Digite o id do Medicamento");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a qtde da venda");
                    int qtde = Convert.ToInt32(Console.ReadLine());
                    if(medicamentos.pesquisar(new Medicamento(id, "", "")).vender(qtde))
                    {
                        Console.WriteLine("Vendido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Não Vendido");
                    }
                }
                else
                {
                    Console.WriteLine("O numero digitado é invalido.");
                }
            } while (x != 0);
        }
    }
}
