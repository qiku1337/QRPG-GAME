using System;
using System.Collections.Generic;
using System.Text;

namespace app
{

    class player
    {
        string player_name;
        int level;
        int magic_level;
        int power;
        int health;

        public player(string pn, int lvl, int ml, int pwr, int hp)
        {
            player_name = pn;
            level = lvl;
            magic_level = ml;
            power = pwr;
            health = hp;
        }

        public void get_stat()
        {
            Console.WriteLine("Name: " + player_name);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Magiclevel: " + magic_level);
            Console.WriteLine("Power; " + power);
        }
        public int get_hp()
        {
            return health;
        }
        public void loose_hp(int hp)
        {
            health -= hp;
            Console.WriteLine("Player lost hp: "+hp+" Hp left: "+health);
        }
        public int get_pwr()
        {
            return power;
        }
        public void check_isalive()
        {
            if (health <= 0)
            {
                Console.WriteLine("You are dead. \n");
            }
        }
    }
}
