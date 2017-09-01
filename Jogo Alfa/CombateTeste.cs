using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Alfa
{
    
    public class CombateTeste
    {
        private static string nomeAtual;
        private static int expAtual=0;
        private static int hpAtual = 0;
        private static int manaAtual = 0;
        private static int danoAtual = 0;
        private static int defesaAtual = 0;
        private static int dinheiroAtual = 0;
        private static bool batalha = true;
        private static bool fugirFalha = false;
        private static bool ataqueFalha = false;
        

        public static void Tutorial()
        {   //81 caracteres de largura e 12 de altura

            Console.Clear();

            Console.Write(@"                                             .");Console.Write("NOME: Dragao Marinho\n");
            Console.Write(@"               /-/--\                        .");Console.Write("HP: 123\n");
            Console.Write(@"             (@~@)   )/\                     .");Console.Write("MANA: 75\n");
            Console.Write(@"         ___/--      \  |                    .");Console.Write("DEFESA: 6\n");
            Console.Write(@"        (oo)__ _      )_/                    .");Console.Write("ATAQUE: 4\n");
            Console.Write(@"         ^^___/       \                      .");Console.Write("\n");
            Console.Write(@"               \       |/-\                  .");Console.Write("\n");
            Console.Write(@"                (      )   |                 .");Console.Write("\n");
            Console.Write(@"                |       \_/                  .");Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@"[1] ATACAR                                  HP: 7                               ."); Console.Write("\n");
            Console.Write(@"[2] MAGIA  N TEM                            MANA: 2                             ."); Console.Write("\n");
            Console.Write(@"[3] ITENS  N TEM                            ATQ: 2                              ."); Console.Write("\n");
            Console.Write(@"[4] FUGIR                                   DEF: 1                              ."); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@" TEXTO DO JOGADOR                                                               ."); Console.Write("\n");

        }

        

        public static void LutaTelaRefresh() // Arrumar o sisetma de batalha.....
        {
            int ataqueDoProtagonista = defesaAtual - Program.protagonista1.dano;
            while (batalha)
            {
                if (Program.protagonista1.fala == "1")
                {
                    

                    hpAtual = hpAtual - Program.protagonista1.dano ;

                }

                if (Program.protagonista1.fala == "4") { fugirFalha = true; }

                Console.Clear();

                Console.Write(@"                                             ."); Console.Write("NOME: {0}\n", nomeAtual);
                Console.Write(@"               /-/--\                        ."); Console.Write("HP: {0}\n", hpAtual);
                Console.Write(@"             (@~@)   )/\                     ."); Console.Write("MANA: {0}\n", manaAtual);
                Console.Write(@"         ___/--      \  |                    ."); Console.Write("DEFESA: {0}\n", defesaAtual);
                Console.Write(@"        (oo)__ _      )_/                    ."); Console.Write("DANO: {0}\n", danoAtual);
                Console.Write(@"         ^^___/       \                      ."); Console.Write("\n");
                Console.Write(@"               \       |/-\                  ."); Console.Write("\n");
                Console.Write(@"                (      )   |                 ."); Console.Write("\n");
                Console.Write(@"                |       \_/                  ."); Console.Write("\n");
                if (fugirFalha) { Console.Write("VOCÊ TENTOU CORRER, MAS O CACHORRO NÃO DEIXOU!"); Console.Write("\n"); fugirFalha = false; }
                else
                {
                    Console.Write(@"                                                                                ."); Console.Write("\n");
                }

                if (fugirFalha) { Console.Write("O CACHORRO TENTOU TE ATACAR, MAS ERROU!!!"); Console.Write("\n"); ataqueFalha = false; }
                else
                {
                    Console.Write(@"                                                                                ."); Console.Write("\n");
                }
                Console.Write(@"                                                                                ."); Console.Write("\n");
                Console.Write(@"x                                                                                "); Console.Write("\n");
                Console.Write(@"x                                                                                "); Console.Write("\n");
                Console.Write(@"x                                                                                "); Console.Write("\n");
                Console.Write(@"x                                                                                "); Console.Write("\n");
                Console.Write(@"x                                                                                "); Console.Write("\n");
                Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
                Console.Write(@"[1] ATACAR                                  HP: {0}                              .", Program.protagonista1.hp); Console.Write("\n");
                Console.Write(@"[2] MAGIA  N TEM                            MANA: {0}                            .", Program.protagonista1.mana); Console.Write("\n");
                Console.Write(@"[3] ITENS  N TEM                            ATQ: {0}                             .", Program.protagonista1.dano); Console.Write("\n");
                Console.Write(@"[4] FUGIR                                   DEF: {0}                             .", Program.protagonista1.defesa); Console.Write("\n");
                Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
                if (hpAtual <= 0) { batalha = false; Vitoria(); } //acabar a luta
                Console.Write(@"Sua acao:");
                Program.protagonista1.fala = Console.ReadLine();
                Console.Write("\n");

            }
        }

        public static void LutaFim()
        {
            Console.Clear();

            Console.Write(@"                                             ."); Console.Write("NOME: {0}\n", nomeAtual);
            Console.Write(@"               /-/--\                        ."); Console.Write("HP: {0}\n", hpAtual);
            Console.Write(@"             (@~@)   )/\                     ."); Console.Write("MANA: {0}\n", manaAtual);
            Console.Write(@"         ___/--      \  |                    ."); Console.Write("DEFESA: {0}\n", defesaAtual);
            Console.Write(@"        (oo)__ _      )_/                    ."); Console.Write("DANO: {0}\n", danoAtual);
            Console.Write(@"         ^^___/       \                      ."); Console.Write("\n");
            Console.Write(@"               \       |/-\                  ."); Console.Write("\n");
            Console.Write(@"                (      )   |                 ."); Console.Write("\n");
            Console.Write(@"                |       \_/                  ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"  PARABENS VOCE VENCEU O CACHORRO, C E' DO MAL, MALTRATANDO OS ANIMAIS          ."); Console.Write("\n");
            Console.Write(@" TU VAI E' SER PRESO PARA APRENDER, FIM DE JOGO OTARIO                          ."); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"   GANHASSE :{0} DE XP POR FAZER ESSA ATROCIDADE                                 ",expAtual); Console.Write("\n");
            Console.Write(@"   E TB GANHASSE {0} DE GOLD, FELIZ? EU NAO, PQ ELE ERA TAO FOFO, OBRIGADO.....  ",dinheiroAtual); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@"[1] ATACAR                                  HP: {0}                              .",Program.protagonista1.hp); Console.Write("\n");
            Console.Write(@"[2] MAGIA  N TEM                            MANA: {0}                             .",Program.protagonista1.mana); Console.Write("\n");
            Console.Write(@"[3] ITENS  N TEM                            ATQ: {0}                              .",Program.protagonista1.dano); Console.Write("\n");
            Console.Write(@"[4] FUGIR                                   DEF: {0}                              .",Program.protagonista1.defesa); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.WriteLine("Fim da TECDEMO, PQ TU E' TAO DO MAL QUE PERDI A VONTADE DE CRIAR O JOGO");
            Console.WriteLine("NÃO QUERO QUE MAIS ANIMAIS INOCENTES SE MACHUQUEM POR SUA CULPA, SEU LOUCO");
        }

        public static void LutaInicio(string nome, int exp, int hp, int mana, int dano, int defesa, int dinheiro)
        {
            Console.Clear();
            nomeAtual = nome;
            expAtual = exp;
            hpAtual = hp;
            manaAtual = mana;
            danoAtual = dano;
            defesaAtual = defesa;
            dinheiroAtual = dinheiro;

            
            Console.Write(@"                                             ."); Console.Write("NOME: {0}\n",nome);
            Console.Write(@"               /-/--\                        ."); Console.Write("HP: {0}\n",hp);
            Console.Write(@"             (@~@)   )/\                     ."); Console.Write("MANA: {0}\n",mana);
            Console.Write(@"         ___/--      \  |                    ."); Console.Write("DEFESA: {0}\n",defesa);
            Console.Write(@"        (oo)__ _      )_/                    ."); Console.Write("DANO: {0}\n",dano);
            Console.Write(@"         ^^___/       \                      ."); Console.Write("\n");
            Console.Write(@"               \       |/-\                  ."); Console.Write("\n");
            Console.Write(@"                (      )   |                 ."); Console.Write("\n");
            Console.Write(@"                |       \_/                  ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"x                                                                                "); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@"[1] ATACAR                                  HP: {0}                              .", Program.protagonista1.hp); Console.Write("\n");
            Console.Write(@"[2] MAGIA  N TEM                            MANA: {0}                             .", Program.protagonista1.mana); Console.Write("\n");
            Console.Write(@"[3] ITENS  N TEM                            ATQ: {0}                              .", Program.protagonista1.dano); Console.Write("\n");
            Console.Write(@"[4] FUGIR                                   DEF: {0}                              .", Program.protagonista1.defesa); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@"Sua acao:");Program.protagonista1.fala = Console.ReadLine(); Console.Write("\n");
            LutaTelaRefresh();
        }


        public static void Vitoria() { LutaFim();  }

        public static void Ataque()
        {

            if (new Random().Next(10) % 2 == 0)
            {
                Program.protagonista1.hp = Program.protagonista1.hp - (Program.protagonista1.defesa - danoAtual);
            }
            else { ataqueFalha = true; }
        }

        public static void Flower()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"                                                                                .");
            Console.WriteLine(@"█████████████▀▀▀▀▀███████▀▀▀▀▀█████████████  .");
            Console.WriteLine(@"█████████▀░░▀▀█▄▄▄▄▄▄██▄▄▄▄▄▄█▀░░▀█████████  .");
            Console.WriteLine(@"████████▄░░▄▄████▀▀▀▀▀▀▀▀▀████▄▄░░▄████████  .");
            Console.WriteLine(@"████▀▀▀▀█████▀░░░░░░░░░░░░░░░▀█████▀▀▀▀████  .");
            Console.WriteLine(@"██▀░░░░░░██▀░░░░░░██░░░██░░░░░░▀██░░░░░░▀██ .");
            Console.WriteLine(@"█▄▄░░░░░░██░░░░▄░░▀▀░░░▀▀░░▄░░░░██░░░░░░▄▄█  .");
            Console.WriteLine(@"████▄░░░░▀██░░░░███████████░░░░██▀░░░░▄████  .");
            Console.WriteLine(@"██████████▀██▄░░░▀███████▀░░░▄██▀██████████   .");
            Console.WriteLine(@"███████▀░░░████▄▄░░░░░░░░░▄▄████░░░▀███████  .");
            Console.WriteLine(@"██████░░░▄▀░░▀▀▀███████████▀▀▀░░▀▄░░░██████  .");
            Console.WriteLine(@"██████░░░▀░░░░░░░░▄▄▄█▄▄▄░░░░░░░░▀░░░██████  .");
            Console.WriteLine(@"████████▄▄▄▄▄▄███████████████▄▄▄▄▄▄████████  .");
            Console.WriteLine(@"██████████████████▀░░▀█████████████████████  .");
            Console.WriteLine(@"█████████████████▀░░░▄█████████████████████  .");
            Console.WriteLine(@"█████████████████░░░███████████████████████  .");
            Console.WriteLine(@"██████████████████░░░▀█████████████████████  .");
            Console.WriteLine(@"███████████████████▄░░░████████████████████  .");
            Console.WriteLine(@"█████████████████████░░░███████████████████  .");

        }

        public static void Jogo()
        {
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"                                                                                ."); Console.Write("\n");
            Console.Write(@"+------------------------------------------------------------------------------+."); Console.Write("\n");
            Console.Write(@" TEXTO DO JOGADOR                                                               ."); Console.Write("\n");




        }


    }
}
