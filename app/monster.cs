using System;
using System.Collections.Generic;
using System.Text;

namespace app
{
    class monster
    {
        string monster_name;
        int level;
        int power;
        int health;

        public monster(string mn, int lvl, int pwr, int hp)
        {
            monster_name = mn;
            level = lvl;
            power = pwr;
            health = hp;
        }
        public void get_hp()
        {
            Console.WriteLine("monster health " + health);
        }
        public int get_pwr()
        {
            return power;
        }
        public void set_hp(int hp)
        {
            health -= hp;
        }
    }
}
