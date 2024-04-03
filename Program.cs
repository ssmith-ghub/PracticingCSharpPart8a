using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double boomersAge = 8.5;
            int acesAge = 6;
            double carolinesAge = 17.7;

            double allAge = boomersAge + acesAge + carolinesAge;
            double multipleAge = boomersAge + acesAge;
            double multipleAge2 = boomersAge + carolinesAge;
            double multipleAge3 = acesAge + carolinesAge;

            string dogNameOne = "Boomer";
            string dogNameTwo = "Ace";
            string catNameOne = "Caroline";
            char plural = 's';

            Console.WriteLine(dogNameOne + " is close to " + (Math.Ceiling(boomersAge)) + " years old in age.");
            Console.ReadKey();
            Console.WriteLine(dogNameTwo + " is " + (Math.Abs(acesAge)) + " years from birth.");
            Console.ReadKey();
            Console.WriteLine(catNameOne + " is older than " + (Math.Floor(carolinesAge)) + " and not yet " + Math.Ceiling(carolinesAge));
            Console.ReadKey();

            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Your Name is " + usersName);
            Console.ReadKey();
            Console.WriteLine("How Oldd\b are you?");
            string usersAge = Console.ReadLine();
            int usersAgeTwo = Convert.ToInt32(usersAge);
            Console.WriteLine("You are " + usersAgeTwo + " years old");
            Console.ReadKey();
            Console.WriteLine("How long have you had " + dogNameOne + " in years as a pet?");
            string yearsAsPet = Console.ReadLine();
            int yearsAsPet2 = Convert.ToInt32(yearsAsPet);
            Console.WriteLine("You have had " + dogNameOne + " for " + yearsAsPet2 + " years.");
            Console.ReadKey();
            int boomersAgeThree = Convert.ToInt32(boomersAge);
            Console.WriteLine(usersName + " spent " + (usersAgeTwo - yearsAsPet2) + " years living before getting " + dogNameOne);
            Console.ReadKey();
            Console.WriteLine(usersName + " is " + (usersAgeTwo - multipleAge3) + " years older than " + dogNameTwo + " and " + catNameOne+plural + " ages combined");
            Console.ReadKey();
            Console.Beep();

        }
    }
}
