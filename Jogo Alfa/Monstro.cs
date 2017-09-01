using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Alfa
{
    public class Monstro
    {

        public string nome;
        public int exp;
        public int hp;
        public int mana;
        public int dano;
        public int defesa;
        public int dinheiro; //DROP

        public Monstro(string nome, int exp, int hp, int mana, int dano, int defesa, int dinheiro)

        {
            this.nome = nome;
            this.exp = exp;
            this.hp = hp;
            this.mana = mana;
            this.dano = dano;
            this.defesa = defesa;
            this.dinheiro = dinheiro;

        }
        



        //public static void CriarMonstroInicial()
        //{
            
        //        Monstro monstroCachorro = new Monstro("Cachorro", 5, 5, 0, 2, 1, 0);
                
        //}
    }
    



}
