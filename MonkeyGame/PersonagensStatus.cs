using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonkeyGame;
namespace Jogo_do_macaco___feira
{
    public class PersonagensStatus
    {
        public int vida { get ; set; }
        public int defesa { get; set; }
        public int dano { get; set; }
        public int carga { get; set; }
        public String HabilidadeEspecial { get; set; }

        public PersonagensStatus(int vida, int defesa, int dano, string habilidadeEspecial, int carga)
        {
            this.vida = vida;
            this.defesa = defesa;
            this.dano = dano;
            HabilidadeEspecial = habilidadeEspecial;
            this.carga = carga;
        }
    }

    public class Personagem
    {
        public string nome { get; set; }
        public PersonagensStatus status { get; set; }
        
        public Personagem(string Nome, PersonagensStatus Status)
        {
            nome = Nome;
            status = Status;
        }

    }
        
    }
