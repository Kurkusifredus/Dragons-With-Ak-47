using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons_With_AK_47
{
    class Jugador
    {
        public int health;
        public const  int playerMaxHealth = 100;
        public int balasRestantes;
        public const int balasMax =30;
        public int mags;
        public const int maxMags =10;
        public int chutes;
        public const int maxchutes =3;

        public Jugador() 
        {
            health = playerMaxHealth;
            balasRestantes = balasMax;
            mags = maxMags;
            chutes = maxchutes;
        }    
    }
}
