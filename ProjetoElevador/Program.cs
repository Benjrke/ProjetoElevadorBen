using System;
using ProjetoElevador.MODEL;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.WriteLine("Olá, Seja bem vindo!!!");
            Console.WriteLine("=======================");
            Console.WriteLine("Quantos andares terá o edifício?");
            int qtd_Andares = int.Parse(Console.ReadLine());

            Console.WriteLine(@"Deseja entrar no Elevador:
                    1 - Sim
                    2 - Não
                            ");
            int escolha1 = int.Parse(Console.ReadLine());

            switch (escolha1)
            {
                case 1: elevador.Entrar(); break;
                case 2: Console.WriteLine("---Volte Sempre---");break;            
                default:
                    break;
            }

            Console.WriteLine(@"Escolha uma Opção:
                    1 - Subir
                    2 - Descer
                    3 - Sair
                                ");
            int escolha2 = int.Parse(Console.ReadLine());

            switch (escolha2)
            {
                case 1: elevador.Subir(); break;
                case 2: elevador.Descer(); break;
                case 3: elevador.
               
                default:
                    break;
            }

        }
    }
}
