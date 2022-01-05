using System;
using ProjetoElevador.MODEL;

namespace ProjetoElevador
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            elevador.Inicializar();
            int result = 0;// variavel para ser tratada no metodo sair

        parada1:// Rótulo para condicação de salto da função goto, caso a escolha seja um numero inválido.
            Console.WriteLine(@"Deseja entrar no Elevador:
                    1 - Sim
                    2 - Não
                            ");

            int escolha1 = int.Parse(Console.ReadLine());
            Console.Clear();


            switch (escolha1)
            {
                case 1: elevador.Entrar(); break;
                case 2:
                    Console.WriteLine("---Volte Sempre---");
                    Environment.Exit(escolha1);
                        break;
                default:
                    Console.WriteLine("==Escolha Inválida==");
                    goto parada1;

            }


        parada2:// Rótulo para condicação de salto da função goto, caso a escolha seja um numero inválido.
            Console.WriteLine(@"Escolha uma Opção:
                    1 - Subir
                    2 - Descer
                    3 - Sair
                                ");
            int escolha2 = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (escolha2)
            {
                case 1: elevador.Subir(); break;
                case 2: elevador.Descer(); break;
                case 3:
                    elevador.Sair(result);
                    result = elevador.Sair(result);

                    if (result == 1)
                    {
                        goto parada2;
                    }
                    if (result == 2)
                    {
                        Environment.Exit(escolha2);

                    }; break;
                default:
                    Console.WriteLine("==Escolha Inválida==");
                    goto parada2;
            }

            goto parada2;// rotuulo para o salto para a linha 40

        }

    }

}
