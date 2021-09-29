using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fim=10;
            int dia = 0;
            string desc = "";
            string nome = "";
            string email = "";
            int qtde = 0;
            int verifica = 0;
            Participante pessoa = new Participante("halisson","halisson@");
            Console.WriteLine("Hello World!"+pessoa.ToString());
            Evento entos = new Evento(1,"Show",4);
            Eventos entoss = new Eventos();
            entos.inscreverParticipante(new Participante("halisson", "halisson@"));
            Console.WriteLine(entos.ToString());
            entoss.adicionarEvento(new Evento(0, "Show", 4));
            entoss.OsEventos[0].inscreverParticipante(new Participante("halisson", "halisson@"));
            Console.WriteLine(entoss.listaEventos());
            Console.WriteLine(entoss.pesquisarParticipante(new Participante("halisson", "halisson@")));

            do
            {
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Adicionar evento(escolher o dia, onde 1 = SEG, 2 = TER, ..., 6 = SAB)");
                Console.WriteLine("2.Pesquisar evento(deverá retornar os dados do evento + participantes)");
                Console.WriteLine("3.Listar eventos(informar dados básicos do evento + qtde participantes)");
                Console.WriteLine("4.Adicionar participante(retornando o status da operação com mensagem)");
                Console.WriteLine("5.Pesquisar participante(utilizar o e - mail como critério de pesquisa)");
                Console.WriteLine("6.Informar quantidade total de participantes nos eventos da semana");
                fim = Convert.ToInt32(Console.ReadLine());
                if(fim==1)
                {
                    Console.WriteLine("Adicionar evento(escolher o dia, onde 1 = SEG, 2 = TER, ..., 6 = SAB), descrição e quantidade de pessoas");
                    dia = Convert.ToInt32(Console.ReadLine());
                    desc = Console.ReadLine();
                    qtde = Convert.ToInt32(Console.ReadLine());
                    entoss.adicionarEvento(new Evento(dia, desc, qtde));
                }
                if(fim==2)
                {
                    Console.WriteLine("Pesquisar evento(deverá retornar os dados do evento + participantes) digite o dia do evento");
                    dia = Convert.ToInt32(Console.ReadLine());
                    foreach (Evento s in entoss.OsEventos)
                    {
                        if (s.Id==dia)
                        {
                            Console.WriteLine(s.ToString());
                        }
                    }
                }
                if (fim == 3)
                {
                    Console.WriteLine("3.Listar eventos(informar dados básicos do evento + qtde participantes)");
                    Console.WriteLine(entoss.listaEventos());
                }
                if(fim == 4)
                {
                    Console.WriteLine("4.Adicionar participante(retornando o status da operação com mensagem) digite o nome  e email e o evento");
                    nome = Console.ReadLine();
                    email = Console.ReadLine();
                    dia = Convert.ToInt32(Console.ReadLine());
                    dia = entoss.OsEventos[dia].inscreverParticipante(new Participante(nome, email));
                    if(dia==0)
                    {
                        Console.WriteLine("0 - Inscrição efetuada");
                    }
                    if (dia == 1)
                    {
                        Console.WriteLine("1 - Evento lotado");
                    }
                    if (dia == 2)
                    {
                        Console.WriteLine("2 - Excedido limite de inscrições para o participante");
                    }
                }
                if (fim == 5)
                {
                    Console.WriteLine("5.Pesquisar participante(utilizar o e - mail como critério de pesquisa)");
                    email = Console.ReadLine();                    
                    Console.WriteLine(entoss.pesquisarParticipante(new Participante("", email)));
                }
                if (fim == 5)
                {
                    Console.WriteLine("6.Informar quantidade total de participantes nos eventos da semana");
                    Console.WriteLine(entoss.qtdeParticipantes());
                }

            } while (fim != 0);



        }
    }
}
