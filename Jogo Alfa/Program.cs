using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jogo_Alfa
{
    class Program
    { 

        public static bool loopingInicial = true;
       // public static bool loopingCidade = true;
        public static Protagonista protagonista1 = new Protagonista("nomes",0,0,0,false,0,0,0,7,2,1,0,"norte"); //Criação do protagonista
        static void Main()
        
        {            
            /*Declaração das variaveis 
            Não esquecer de por todos os capitulos cada um em um "Classe" tem o nome certo, mas não me lembro é tipo EVENTo ou MODULO sei lá
            int x=0,y=0;  // X e Y posição no mapa
            */

            Console.WriteLine("*****  GAME ALFA TESTE  *****\n\n");
            //Corrigir Bug que pode Saltar para o CAP 2 - Mas pode deixar para facilitar a vida dos programadores <3
            Console.WriteLine("Bem vindo ao Game Alfa, o jogo consiste em você descobrir o que precisa falar na hora certa com cada NPC\n pretendo adicionar um sistema de itens futuramente, mas isso é besteira\n");
            Console.WriteLine("Todas as acoes precisam estA no infinitivo, para poder acontecer, e para se movimentar basta falar os Cardeais");
            Console.WriteLine("Preparado para jogar? s/n");
            protagonista1.fala = Console.ReadLine().ToUpper();
            if (protagonista1.fala == "S")
            { Capitulo0.Comeco(); }       //INICIO DO PROLOGO TUTORIAL Colocar um ELSE, fechar jogo
 

            char resposta = 'n';
            Console.WriteLine("Deseja continaur? (s/n)");
            resposta = char.Parse(Console.ReadLine());
            if (resposta == 's')
            {
                Console.WriteLine("Deseja limpar a tela? (s/n)");
                resposta = char.Parse(Console.ReadLine());
                if (resposta == 's') { Console.Clear(); resposta = 'n'; Capitulo1.Cidade(); }

            }
            else { };

        }

    }
}
