using System;

namespace text_rpg_c__project
{
    class Program
    {
        static void Main(string[] args)
        {
        static int ranNum (int x, int y)
        {
          Random random = new Random();
          int randomNumber = random.Next(x, y);
          return randomNumber;
        }
            start_of_the_game:
            Console.WriteLine("You can use kick, headbump, punch \n kick > headbump \n headnump > punch \n punch > kick");
            var player_health = 20;
            var enemy_wave = 0;

            var words = new string[]{"kick", "headbump", "punch", "quit"};
            var win_words = new string[]{"duma1", "duma2", "dima3"};
            /**
            kick == 1, headbump == 2, punch == 3
            same for the enemy
            **/

        while(player_health > 0)
        { // the game loop
            enemy_stage:

            var enemy_health = 0;
            
            battle:
            //the battle loop
            if(enemy_health == 0)
            {
            var input = Console.ReadLine();
            var PlayerMove = Array.IndexOf(words,input) + 1;
            int EnemyMove = ranNum(1, 3);
            if(PlayerMove == 1 || PlayerMove == 2 || PlayerMove == 3){
                if(PlayerMove > EnemyMove && !(PlayerMove == 3 && EnemyMove == 1))
                {
                    int ranIndex = ranNum(0, win_words.Length);
                    Console.WriteLine(win_words[ranIndex]);
                    Console.WriteLine("Your health is " + player_health);
                    Console.WriteLine("Enemy health is " + enemy_health);
                    enemy_health--;
                    int chance_to_heal = ranNum(0, 100);
                    if(chance_to_heal >= 30)
                    {
                        player_health++;
                        Console.WriteLine("You manage to heal 1 HP... yey");
                    }
                    goto battle;
                }
                else if(PlayerMove == EnemyMove)
                {
                    Console.WriteLine("draw");
                    goto battle;
                }
                else
                {
                     Console.WriteLine("You took 1 hit  -1 hp");
                     player_health--;
                     Console.WriteLine("Your health is " + player_health);
                     Console.WriteLine("Enemy health is " + enemy_health);
                     goto battle;
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again, you idiot");
                goto battle;
            }
            }
            else
            {

            }
        }
        }
    }
}
