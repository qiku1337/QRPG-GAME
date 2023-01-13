using System;

namespace app
{
    class Program 
    {
        private static player player;
        private static monster monster;

        static void Main(string[] args)
        {
            player = new player("Qiku",5,15,5,15); //add player
            monster = new monster("rat", 1, 5,15); //add monster

            Console.WriteLine("RPG full life WORLD \n");  
            player.get_stat();
        
            player.loose_hp(monster.get_pwr());
            player.check_isalive();
            player.loose_hp(monster.get_pwr());
            player.check_isalive();
            player.loose_hp(monster.get_pwr());
            player.check_isalive();
        }
    }
}
