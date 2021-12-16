using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cadastro cadastro = new Cadastro();
            int x;
            do
            {
                //parametros
                //cmd.Parameters.AddWithValue("",);
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Cadastrar ambiente");
                Console.WriteLine("2.Consultar ambiente");
                Console.WriteLine("3.Excluir ambiente");
                Console.WriteLine("4.Cadastrar usuario");
                Console.WriteLine("5.Consultar usuario");
                Console.WriteLine("6.Excluir usuario");
                Console.WriteLine("7.Conceder permissão de acesso ao usuario(informar ambiente e usuário - vincular ambiente ao usuário");
                Console.WriteLine("8.Revogar permissão de acesso ao usuario(informar ambiente e usuário - desvincular ambiente do usuário)");
                Console.WriteLine(" 9.Registrar acesso(informar o ambiente e o usuário - registrar o log respectivo)");
                Console.WriteLine("10.Consultar logs de acesso(informar o ambiente e listar os logs - filtrar por logs autorizados / negados / todos)");
                x = Convert.ToInt32(Console.ReadLine());
                
                if (x == 1)
                {
                    Console.WriteLine("Digite o id e nome do ambiente");
                    int a = Convert.ToInt32(Console.ReadLine());
                    string b = Console.ReadLine();
                    cadastro.adicionaAmbiente(new Ambiente(a, b));
                }
                else if (x == 2)
                {
                    Console.WriteLine("Digite o id do ambiente");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("nome:" + cadastro.pesquisarAmbiente(new Ambiente(a, "")).Nome);
                }
                else if (x == 3)
                {
                    Console.WriteLine("Digite o id do ambiente");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (cadastro.removerAmbiente(new Ambiente(a, "")))
                    {
                        Console.WriteLine("Funfo");
                    }
                    else
                    {
                        Console.WriteLine("Não Funfo");
                    };
                }
                else if (x == 4)
                {
                    Console.WriteLine("Digite o id e nome do usuario");
                    int a = Convert.ToInt32(Console.ReadLine());
                    string b = Console.ReadLine();
                    cadastro.adicionarUsuario(new Usuario(a, b));
                }
                else if (x == 5)
                {
                    Console.WriteLine("Digite o id do usuario");
                    int a = Convert.ToInt32(Console.ReadLine());
                    cadastro.pesquisarUsuario(new Usuario(a, ""));
                }
                else if (x == 6)
                {
                    Console.WriteLine("Digite o id do usuario");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (cadastro.removerUsuario(new Usuario(a, "")))
                    {
                        Console.WriteLine("Funfo");
                    }
                    else
                    {
                        Console.WriteLine("Não Funfo");
                    };
                }
                else if (x == 7)
                {
                    Console.WriteLine("Digite o id do usuario e depois o do ambiente");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (cadastro.pesquisarUsuario(new Usuario(a, "")).concederPermissao(cadastro.pesquisarAmbiente(new Ambiente(a, ""))))
                    {
                        Console.WriteLine("Funfo");
                    }
                    else
                    {
                        Console.WriteLine("não Funfo");
                    };
                }
                else if (x == 8)
                {
                    Console.WriteLine("Digite o id do usuario e depois o do ambiente");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (cadastro.pesquisarUsuario(new Usuario(a, "")).revogarPermissao(cadastro.pesquisarAmbiente(new Ambiente(a, ""))))
                    {
                        Console.WriteLine("Funfo");
                    }
                    else
                    {
                        Console.WriteLine("Não Funfo");
                    };
                }
                else if (x == 9)
                {
                    Console.WriteLine("Digite o id do usuario e depois o do ambiente");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = 0;
                    foreach (Ambiente amb in cadastro.pesquisarUsuario(new Usuario(a, "")).Ambientes)
                    {
                        if (amb.Id == cadastro.pesquisarAmbiente(new Ambiente(b, "")).Id)
                        {
                            cadastro.pesquisarAmbiente(new Ambiente(a, "")).registrarLog(new Log(DateTime.Now, cadastro.pesquisarUsuario(new Usuario(a, "")).Nome, true));
                            c = 3;
                        }
                    }
                    if (c != 3)
                    {
                        cadastro.pesquisarAmbiente(new Ambiente(a, "")).registrarLog(new Log(DateTime.Now, cadastro.pesquisarUsuario(new Usuario(a, "")).Nome, false));
                    }

                }
                else if (x == 10)
                {
                    Console.WriteLine("Digite o id do ambiente e o tipo do filtro 1 -autorizado,2-negados e 3 todos");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if( b == 1)
                    {
                        foreach (Log lg in cadastro.pesquisarAmbiente(new Ambiente(a, "")).logs)
                        {
                            if (lg.TipoAcesso == true) 
                            {
                                Console.WriteLine(lg.DtAcesso+""+lg.TipoAcesso+""+lg.Usuario);

                            }
                        }  
                    }
                    else if (b == 2)
                    {
                        foreach (Log lg in cadastro.pesquisarAmbiente(new Ambiente(a, "")).logs)
                        {
                            if (lg.TipoAcesso == false)
                            {
                                Console.WriteLine(lg.DtAcesso + "" + lg.TipoAcesso + "" + lg.Usuario);

                            }
                        }
                    }
                    else if (b == 3) 
                    {
                        foreach (Log lg in cadastro.pesquisarAmbiente(new Ambiente(a, "")).logs)
                        {                           
                                Console.WriteLine(lg.DtAcesso + "" + lg.TipoAcesso + "" + lg.Usuario);                                                       
                        }

                    }
                    else 
                    {
                        Console.WriteLine("Opção invalida");
                    }

                }
                } while (x != 0);
            cadastro.Upload();
            
        }   } 
}
