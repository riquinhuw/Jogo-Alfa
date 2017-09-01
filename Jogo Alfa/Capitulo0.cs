using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Alfa
{
    class Capitulo0
    {
        
        public static void Comeco()
        {
            
            bool loopingInicial=true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Você está em uma linha reta, no ponto 0,0 o seu unico caminho é seguir pelo norte");
            while (loopingInicial)
            {
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Faça sua acao:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Program.protagonista1.fala = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.White;
                Program.protagonista1.AndarVertical();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sua posição atual é: {0},{1}", Program.protagonista1.x, Program.protagonista1.y);
                Console.ForegroundColor = ConsoleColor.White;


                if (Program.protagonista1.x == 3) // VELHO NA ESTRADA DANDO DICA DA CIDADE
                {
                    Console.WriteLine("Você encontra um velho no meio da estrada");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Faça sua acao:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Program.protagonista1.fala = Console.ReadLine().ToUpper();
                    Console.ForegroundColor = ConsoleColor.White;
                    if (Program.protagonista1.fala == "FALAR" || Program.protagonista1.fala == "CONVERSAR" || Program.protagonista1.fala == "INTERAGIR" || Program.protagonista1.fala == "AJUDAR")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("O velho diz:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" Bom dia meu jovem, vejo que está bastante cansado, daqui 6 passos para o norte você acharA uma vila para o leste\n");
                        Console.WriteLine("Se precisar de um lugar para dormir e' só falar que conhece o Paulo");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else {
                        Program.protagonista1.AndarVertical();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sua posição atual é: {0},{1}", Program.protagonista1.x, Program.protagonista1.y);
                        Console.ForegroundColor = ConsoleColor.White;
                    } 
                    
                }

                if (Program.protagonista1.x == 9) //PRIMEIRA CIDADE PROCURAR CASA PARA DORMIR PAALVRA CAHVE "PAULO"
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Faça sua acao:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Program.protagonista1.fala = Console.ReadLine().ToUpper();
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.protagonista1.AndarVerticalELeste();

                }
                if (Program.protagonista1.x == 9 && Program.protagonista1.y == 1) { loopingInicial = false; }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Uau bb, chegou na cidade, c e' o bichao mesmo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sua posição atual é: {0},{1}", Program.protagonista1.x, Program.protagonista1.y);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
