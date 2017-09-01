using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Alfa
{
    public class Protagonista
    {
        //Criar outra classe para iventario, onde irá conter os itens do jogador
        private string nome;
        private int progresso = 0;
        public int x = 0; // posição X horizontal
        public int y = 0; // posição Y vertical
        private bool missao1 = false; // alguma missao extra a parte ou coisa do tipo
        private int karma = 0; // para alguma coisa do roleplay
        private int atrocidade = 0; // serve para quando se faz algo muito ruim, para não afetar muito o Karma em si
        private int santidade = 0; //Serve para quando faz algo MUITO MUITO bom, para não afetar o Karma em si
        public int hp = 7; // A vida dele, caso que seja usado, caso que tenha sistema de batalha no alfa
        public int mana = 2; // MANA
        public int dano = 1; // sim você é fraco, lutar não é uma opção, mas se for necessario LUTE - SOBREVIVA - CONQUISTE
        public int defesa = 1;
        public int dinheiro = 0; // quem é vc? lek? tu acha que é o ricão? seu burguês safado
        public string fala; // o que o joador responde
        
        public Protagonista(string nome,int progresso, int x, int y, bool missao1,int karma, int atrocidade, int santidade, int hp,int mana, int defesa,int dinheiro,string fala,int dano)
        {
            this.nome = nome;
            this.progresso = progresso;
            this.x = x;
            this.y = y;
            this.missao1 = missao1;
            this.karma = karma;
            this.atrocidade = atrocidade;
            this.santidade = santidade;
            this.hp = hp;
            this.dano = dano;
            this.mana = mana;
            this.defesa = defesa;
            this.dinheiro = dinheiro;
            this.fala = fala;

        }

        public void Andar()
        {

            if (this.fala == "NORTE")
            {
                this.x = this.x + 1;

            }
            else if (this.fala == "SUL")
            {
                this.x = this.x - 1;

            }
            else if (this.fala == "LESTE")
            {
                this.y = this.y + 1;

            }
            else if (this.fala == "OESTE")
            {
                this.y = this.y - 1;

            }

        }

        public void AndarVertical()
        {
            if (this.fala == "NORTE")
            {
                this.x = this.x + 1;

            }
            else if (this.fala == "SUL")
            {
                this.x = this.x - 1;

            }

        }

        public void AndarHorizontal()
        {
            if (this.fala == "LESTE")
            {
                this.y = this.y + 1;

            }
            else if (this.fala == "OESTE")
            {
                this.y = this.y - 1;

            }

        }

        public void AndarVerticalEOeste()
        {
            if (this.fala == "NORTE")
            {
                this.x = this.x + 1;

            }
            else if (this.fala == "SUL")
            {
                this.x = this.x - 1;

            }
            else if (this.fala == "OESTE")
            {
                this.y = this.y - 1;

            }

        }

        public void AndarVerticalELeste()
        {
            if (this.fala == "NORTE")
            {
                this.x = this.x + 1;

            }
            else if (this.fala == "SUL")
            {
                this.x = this.x - 1;

            }
            else if (this.fala == "LESTE")
            {
                this.y = this.y + 1;

            }

        }

    }
}
