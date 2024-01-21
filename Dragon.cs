using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons_With_AK_47
{
    public  class Dragon
    {
        public  int MAX_HEALTH = 255;
        public  int health;
        public  int MAX_DRAGON_SKILL = 3;
        public  int skillCounter;
        public bool fireTypeSemi, fireTypeAuto;
        public bool usedHashM;

        public Dragon()
        {
            health = MAX_HEALTH;
            skillCounter = 0;
            usedHashM = false;
            SetFireTypeSemi();
        }
        public void IncreaseSkillCounter() 
        {
            if (skillCounter +2 >= MAX_DRAGON_SKILL) 
            { 
                skillCounter = MAX_DRAGON_SKILL;
            }
            else
            {
                skillCounter += 2;
            }
        }
        public void DecreaseSkillCounter() 
        {
            

            if (skillCounter <= 0) 
            {
                if (usedHashM)
                {
                    Console.WriteLine("El Aura del dragón parece apagarse, cuidado con los cambios que haces, el dragón sabe que en tu vida has usado un Breakpoint.");
                }

            }
            else
            {
                skillCounter--;
            }
        }

        public int GetDamage() 
        {
            if (fireTypeAuto)
            {
                return 20;
            }

            else
            {
                return 10;
            }
        }
        public void TakeDamage(int damage) 
        {
            health -= damage;
        }

        public void SetFireTypeSemi()
        {
            fireTypeSemi = true;
            fireTypeAuto = false;
        }

        public void SetFireTypeAuto()
        {
            fireTypeSemi = false;
            fireTypeAuto = true;
        }
        public void Heal()
        {
            if (fireTypeSemi)
            {
                if (health + 4 >= MAX_HEALTH)
                {
                    health = MAX_HEALTH;
                }
                else
                {
                    health += 4;
                }
            }
            else
            {
                if (health + 18 >= MAX_HEALTH)
                {
                    health = MAX_HEALTH;
                }
                else
                {
                    health += 18;
                }
            }
        }
    }
}
