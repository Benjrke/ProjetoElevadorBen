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

            Console.WriteLine(@"Deseja entrar no Elevador:
                    1 - Sim
                    2 - Não
                            ");
            int escolha1 = int.Parse(Console.ReadLine());

            if (escolha1 == 1)
            {
                elevador.Entrar();

            }
            else if (escolha1 == 2)
            {
                Console.WriteLine("---Volte Sempre---");
                return;
            }
            else
            {
                while (escolha1 != 1)

                {
                    Console.WriteLine("Escolha ivalida, digite 1 ou 2");
                    escolha1 = int.Parse(Console.ReadLine());

                    if (escolha1 == 2)
                    {
                        Console.WriteLine("---Volte Sempre---");
                        return;
                    }

                }
                elevador.Entrar();
            }


            Console.WriteLine(@"Escolha uma Opção:
                    1 - Subir
                    2 - Descer
                    3 - Sair
                                ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
            {
                elevador.Subir();
            }
            else if (escolha2 == 2)
            {
                elevador.Descer();
            }
            else if (escolha2 == 3)
            {
                elevador.Sair();
            }
            else
            {
                while (escolha2 != 1)

                {
                    Console.WriteLine("Escolha ivalida, digite 1 (Subir), 2 (Descer) ou 3 (Sair)");
                    escolha2 = int.Parse(Console.ReadLine());
                    

                    if (escolha2 == 1)
                    {
                        elevador.Subir();
                    }
                    else if (escolha2 == 2)
                    {
                        elevador.Descer();
                        return;
                    }
                    else if (escolha2 == 3)
                    {
                        elevador.Sair();
                        escolha2 = 1;
                    }

                }
            }

        }

    }

}
