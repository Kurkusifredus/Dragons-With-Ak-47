using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons_With_AK_47
{
    public class Dragon
    {
        public const int DRAGONS_MAX_HEALTH = 255;
        public int health;
        public int MAX_DRAGON_SKILL = 3;
        public int dragonSkillCounter;

        public Dragon() 
        {
            health = DRAGONS_MAX_HEALTH;
            dragonSkillCounter = 0;
        } 
    }
}
