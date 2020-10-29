using System;

namespace MEC_OCTOBER_PROBLEM___TRY
{
    class Program{
   static void Main(string[] args)
        {
             int num;
             String ans;
            String That = "That is";
            String Itis = "It is!";
            Console.Write("Hello there, pick a number from 1 to 7 to know which day in a week it corresponds to: ");
            num = Convert.ToInt32(Console.ReadLine());
           switch (num) {
                case 1:
                Console.WriteLine(That + " Monday!");
                break;
                case 2:
                Console.WriteLine(That + " Tuesday!");
                break;
                case 3:
                Console.WriteLine(That + " Wednesday!");
                break;
                case 4:
                Console.WriteLine(That + " Thursday!");
                break;
                case 5:
                Console.WriteLine(That + " Friday!");
                break;
                case 6:
                Console.WriteLine(That + " Saturday!");
                break;
                case 7:
                Console.WriteLine("Sunday" + Itis );
                break;
                // exception
                default:
                Console.WriteLine("Please only input a number from 1 to 7 :)");
                break;
           }
Console.WriteLine("Do you want to try again? (Y/N)");
ans = Console.ReadLine();
if(ans == "Y" || ans == "y"){
    Console.Write("Input a number from 1 to 7: ");
    num = Convert.ToInt32(Console.ReadLine());
     switch (num) { case 1:
                Console.WriteLine(That + " Monday!");
                break;
                case 2:
                Console.WriteLine(That + " Tuesday!");
                break;
                case 3:
                Console.WriteLine(That + " Wednesday!");
                break;
                case 4:
                Console.WriteLine(That + " Thursday!");
                break;
                case 5:
                Console.WriteLine(That + " Friday!");
                break;
                case 6:
                Console.WriteLine(That + " Saturday!");
                break;
                case 7:
                Console.WriteLine("Sunday" + Itis );
                break;
                // exception
                default:
                Console.WriteLine("Please only input a number from 1 to 7 :)");
                break;
           }
           Console.WriteLine("Have a great day! Bye.");
}
else if (ans == "N" || ans == "n"){
    Console.WriteLine("Understandable, have a great day \n Exiting...");
}
                Console.ReadKey();
        }

    }
}


