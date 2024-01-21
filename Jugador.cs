using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons_With_AK_47
{
    public  class Jugador
    {
        public  int health;
        public  int MaxHealth = 100;
        public  int balasRestantes;
        public  const int BalasMax = 30;
        public  int mags;
        public  int MaxMags =5;
        public  int chutes;
        public  int Maxchutes =3;
        public bool  firelock,  fireTypeSemi, fireTypeAuto, chutado;

        public Jugador() 
        {
            health = MaxHealth;
            balasRestantes = BalasMax;
            mags = MaxMags;
            chutes = Maxchutes;
            chutado = false;
            SetFireLock();
        }

        public int GetDamage()
        {
            if (fireTypeSemi) 
            {
                return 5;
            }

            else if (fireTypeAuto)
            {
                return 25;
            }

            else 
            {
                return 0;
            }
        }
        
        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        public void SetFireLock() 
        {
            firelock = true;
            fireTypeSemi = false;
            fireTypeAuto = false;
        }

        public void SetFireTypeSemi()
        {
            firelock = false;
            fireTypeSemi = true;
            fireTypeAuto = false;
        }

        public void SetFireTypeAuto()
        {
            firelock = false;
            fireTypeSemi = false;
            fireTypeAuto = true;
        }

        public void Heal(int healAmount)
        {
            if (health + healAmount >= MaxHealth)
            {
                health = MaxHealth;
            }
            else if (chutes <= 0)
            {
                health += 0;
            }
            else
            {
                health += healAmount;
            }

            if (chutado)
            {
                chutes--;
            }
            
        }

        public void PlayerShoot()
        {
            if (fireTypeSemi)
            {
                balasRestantes--;
            }
            if (fireTypeAuto)
            {
                balasRestantes-= 5;
            }
        }
    }
}
