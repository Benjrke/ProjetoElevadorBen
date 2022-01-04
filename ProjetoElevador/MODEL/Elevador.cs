﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.MODEL
{
    public class Elevador
    {
        int qtd_Andares = 0;
        int capac_Pessoas = 10;
        int Pessoas_Elevador = 0;
        int andar_Atual = 0;

        public void Inicializar()
        {
           

        }
        public void Entrar() //metodo atribui uma pessoa ao elevador caso o mesmo nao esteja cheio!!!
        {    
            if ( Pessoas_Elevador < capac_Pessoas)
            {
                Pessoas_Elevador++;
                Console.WriteLine( Pessoas_Elevador + " Pessoas no Elevador.");
            }
            else
            {
                Console.WriteLine("Desculpe, Elevador está Cheio.");
            }

        }
        public void Sair()//metodo retira uma pessoa do elevador caso tenha!!!
        {
            if (Pessoas_Elevador > 0)
            {
                Pessoas_Elevador--;
                Console.WriteLine( Pessoas_Elevador + " Pessoas no Elevador.");
            }
            else
            {
                Console.WriteLine("!! Não existem pessoas no elevador !!");
            }
           
        }
        public void Subir()
        {
            if (andar_Atual >= qtd_Andares)
            {
                Console.WriteLine("Voce já está no ultimo andar.");
            }
            else
            {
                andar_Atual++;
                Console.WriteLine("Voce está no andar: "+andar_Atual);
            }


        }
        public void Descer()
        {
            if (andar_Atual == 0)
            {
                Console.WriteLine("Voce já está no Térreo");
            }
            else
            {
                andar_Atual--;
                Console.WriteLine("Voce já está andar: " + andar_Atual);
            }
        }

    }
}