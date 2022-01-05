using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.MODEL
{
    public class Elevador
    {
        int qtd_Andares = 0;
        int capac_Pessoas = 0;
        int Pessoas_Elevador = 0;
        int andar_Atual = 0;


        public void Inicializar()
        {
            Console.WriteLine("Olá, Seja bem vindo!!!");
            Console.WriteLine("=======================");

            Console.WriteLine("Qual a capacidade de pessoas no Elevador?");
            capac_Pessoas = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Quantos andares terá o edifício?");
            qtd_Andares = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void Entrar() //metodo atribui uma pessoa ao elevador caso o mesmo nao esteja cheio!!!
        {
            if (Pessoas_Elevador < capac_Pessoas)
            {
                Pessoas_Elevador++;
                Console.WriteLine("Quantidade de Pessoas no Elevador: " + Pessoas_Elevador);

            }
            else
            {
                Console.WriteLine("Desculpe, Elevador está Cheio.");

            }

        }

        public int Sair(int valor)//metodo retira uma pessoa do elevador caso tenha e afirma se esta vazio!!!
        {
            if (Pessoas_Elevador > 0)
            {
                --Pessoas_Elevador;
                valor = 1;
            }
            else if (Pessoas_Elevador == 0 || Pessoas_Elevador < 0)
            {
                Console.WriteLine("!! Elevador está vazio !!");
                Console.WriteLine("!! obrigado por usar o Elevador!!");
                valor = 2;

            }
            return valor;
        }

        public void Subir()//metodo para subir o elevador
        {
            if (andar_Atual >= qtd_Andares)// condição para avisar que está no ultimo andar
            {
                Console.WriteLine("Voce já está no ultimo andar, só pode 2-(Descer) ou 3-(Sair).");
            }
            else
            {
                andar_Atual++;
                Console.WriteLine("Voce está no andar: " + andar_Atual);

            }
        }

        public void Descer() //metodo para descer 1 andar por vez
        {
            if (andar_Atual == 0)
            {
                Console.WriteLine("Voce já está no Térreo, só pode 1-(Subir) ou 2-(Sair).");

            }
            else
            {
                andar_Atual--;
                Console.WriteLine("Voce está no andar: " + andar_Atual);

            }

        }

    }
}
