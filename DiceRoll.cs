using System;

namespace DiceGame
{
    public class DiceRoll
    {
        public static void DiceRoller()
        {
          Random random = new Random();

          int noOfTimesToPlay = 7;

          int counts = 0;

          bool flag = true;

          while(flag && !(noOfTimesToPlay < 1))
          {
            int dice1 = random.Next(1, 7);
 
            int dice2 = random.Next(1,7);

            int dice3 = random.Next(1, 7);

            int total =(dice1 + dice2 + dice3); 

          
            Console.WriteLine($"{dice1} + {dice2} + {dice3} = {total}");

            if ((dice1 == dice2) && (dice2 == dice3))

            {
              Console.WriteLine(Constants.tripleThrowMessage);

              total += 6;
            }
            else if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)

            {
              Console.WriteLine(Constants.doubleThrowMessage);

              total += 2;
            }
          
            Console.WriteLine(total);
            
              var finalMessage = (total >= 15) ? Constants.winMessage : Constants.loseMessage;
            
            Console.WriteLine(finalMessage);

            if (noOfTimesToPlay > 1)

            Console.WriteLine($"You have played {++counts}, You can play {--noOfTimesToPlay} more times");

            Console.WriteLine("============================================================================");

            string Option
          }

         




        }
    }
}