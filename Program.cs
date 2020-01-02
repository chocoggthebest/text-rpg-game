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
            var playerHealth = 20;
            var enemyWave = 0;
            var enemyHealth = 0;

            var words = new string[]{"kick", "headbump", "punch", "quit"};
            var kickWinWords = new string[]{"oooh, that was a great kick", "omg, you kick em really hard", "you didn't need to kick em this hard"};
            var headbumpWinWords = new string[]{"oooh, that was a hreat headbump", "omg, you bashed your head into him realy hard", "is your head ok after this headbump"};
            var punchWinWords = new string[]{"oooh, that was a great punch", "omg, you punched em really hard", "you don't need to punch em so hard"};
            /**
            kick == 1, headbump == 2, punch == 3
            same for the enemy
            **/

        while(playerHealth > 0)
        { // the game loop
            enemy_stage://here checks for what wave this is
            /**
                every 3 waves a big guy spawns with 5hp and max crit of 3
            **/

            battle:
            //the battle loop
            Console.WriteLine("You can use kick, headbump, punch \n kick > headbump \n headnump > punch \n punch > kick");
            if(enemyHealth == 0)
            {
            var input = Console.ReadLine();
            var PlayerMove = Array.IndexOf(words,input) + 1;
            int EnemyMove = ranNum(1, 3);
            if(PlayerMove == 1 || PlayerMove == 2 || PlayerMove == 3){
                if(PlayerMove > EnemyMove && !(PlayerMove == 3 && EnemyMove == 1))//if the player wins this round
                {
                    Console.Clear();
                    if(PlayerMove == 1)
                    {//1 == kick
                        int kickRanIndex = ranNum(0, kickWinWords.Length);
                    Console.WriteLine(kickWinWords[kickRanIndex]);
                    }
                    else if(PlayerMove == 2)
                    {//2 == headbump
                        int headbumpRanIndex = ranNum(0, headbumpWinWords.Length);
                    Console.WriteLine(headbumpWinWords[headbumpRanIndex]);
                    }
                    else if(PlayerMove == 3)
                    {//3 ==punch
                        int punchRanIndex = ranNum(0, punchWinWords.Length);
                    Console.WriteLine(punchWinWords[punchRanIndex]);
                    }
                    else{Console.WriteLine("fuck");}
                    enemyHealth--;
                    int chance_to_heal = ranNum(0, 100);
                    if(chance_to_heal <= 30 && playerHealth > 19)
                    {
                        playerHealth++;
                        Console.WriteLine("You manage to heal 1 HP... yey");
                    }
                    Console.WriteLine("Your health is " + playerHealth);
                    Console.WriteLine("Enemy health is " + enemyHealth);
                }
                else if(PlayerMove == EnemyMove)//if the there is a draw
                {
                    Console.Clear();
                    Console.WriteLine("draw \n You both take don't take damage");
                    Console.WriteLine("Your health is " + playerHealth);
                    Console.WriteLine("Enemy health is " + enemyHealth);
                }
                else//if the player loses this round
                {
                    Console.Clear();
                     Console.WriteLine("You took a hit  -1 hp");
                     playerHealth--;
                     Console.WriteLine("Your health is " + playerHealth);
                     Console.WriteLine("Enemy health is " + enemyHealth);
                }
            }
            else if(PlayerMove == 4){break;}//if the player types quit
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
