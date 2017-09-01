using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Alfa
{
    public class Capitulo1
    {

        public static void Cidade()
        {
            bool loopingCidade = true;
            Program.protagonista1.x = 9; //Setando a posição inicial no capitulo 2
            Program.protagonista1.y = 1;

            while (loopingCidade) //Se aprovarem a gente continua colocar um modo da velhinha falar só uma vez e andar na cidade virar um Looping
            {
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sua posição atual é: {0},{1}", Program.protagonista1.x, Program.protagonista1.y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ao chegar na cidade uma senhora chega perto de você e diz:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" Ohhh Jhon voce voltou para min, que saudades meu filho querido, quanto tempo, por onde voce andou, vamos para minha casa agora?");
                Console.ForegroundColor = ConsoleColor.White;
                Program.protagonista1.fala = Console.ReadLine().ToUpper();
                if (Program.protagonista1.fala == "SIM") { Console.WriteLine("Que filho da mae tu vai enganar a velhina mesmo assi? Desculpa mas nao fiz essa parte ainda kkkk Fale nao e depois PAULO"); }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Por que voce estA ai parado? voce quer vir comigo?");
                Console.ForegroundColor = ConsoleColor.White;
                Program.protagonista1.fala = Console.ReadLine().ToUpper();
                if (Program.protagonista1.fala == "NAO")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Desculpe meu jovem, pensei que era o meu filho perdido, voce e' tao parecido com ele\n");
                    Console.WriteLine("Voce conhece alguem daqui?");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.protagonista1.fala = Console.ReadLine().ToUpper();
                    if (Program.protagonista1.fala == "PAULO")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Entao voce esta na casa do Paulo, Okay levarei voce ate la");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }


                loopingCidade = false;
            }

            Console.WriteLine("NO MEIO DO CAMINHO VOCE ENCONTRA UM DOGGO SE PREPARE!!!");
            Console.WriteLine("precione qualquer tecla para continuar...");
            Console.ReadKey();
            CombateTeste.LutaInicio("Cachorro", 5, 6, 0, 2, 1, 0);

        }


    }
}
