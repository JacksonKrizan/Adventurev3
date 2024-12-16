using System.Windows;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        bool game = true;
        int arrows = 0;
      string question1 = ("You've stumbled into the dark cave. \nYou found a bow and {0} arrows\nDo you pick the bow up or leave it?\n(PickUp) or (Leave it)\n");
      string option1 = ("You have entered the cave. You have found a large stick on the ground. \nYou decide to pick it up");

      string question2 = ("You have entered the cave, you see something furry, do you pet it?");
      string option2 = ("You have found a bunny that leads you to some food");

      string question3 = ("Do you decide to eat the food, you are rather hungry");
      string option3 = ("You see the bunnies die! You made the right choice");

      while (game == true){

      Console.WriteLine("It a pleasure to meet you, once every 500 years this cave has amazing weapons treasures and dangers.\nWhat is your name?\n"); //Welcomes the Cave dweller

      var playerName = Console.ReadLine();


      Console.WriteLine ("Wow, {0} what a horrible name.\n", playerName);
      Choice (question1, "yes", option1);
      Choice (question2, "yes", option2);
      Choice (question3, "no", option3);




     
            void Choice (string firstQuestion, string correct, string option)
            {
                
                // First Question 
                Console.WriteLine (firstQuestion);
                var enter = Console.ReadLine();

                //if they enter or not
                if (enter != null)
                {
                    if (enter.Equals (correct, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(option);
                    }
                    else{
                    
                    EndGame();
                    }
                }
            }

            void EndGame()
            {
            {
                Console.WriteLine("You have decided to leave. Good Bye!");
                game = false;
                System.Environment.Exit (0);
            }
            }
    }
      

     
      

      
      
      
  


      

    }

}