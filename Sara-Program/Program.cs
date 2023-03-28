using System;

namespace PersonalityTraitApp
{
    class Program
    {
        public static void determinePersonality()
        {
            Console.WriteLine("Welcome to the Personality Trait App!");
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("What is your gender? (M/F) ");
            string gender = Console.ReadLine().ToUpper();
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.Write("What is your favorite animal? ");
            string animal = Console.ReadLine();

            Console.WriteLine("\nPersonality trait:");

            if (age >= 18 && gender == "M" && color == "Blue" && animal == "Dog"){
                Console.WriteLine("You are a loyal and dependable person.");
            }
            else if (age >= 18 && gender == "F" && color == "Pink" && animal == "Cat"){
                Console.WriteLine("You are a nurturing and independent person.");
            }
            else if (age >= 18 && gender == "M" && color == "Green" && animal == "Bird"){
                Console.WriteLine("You are an adventurous and curious person.");
            }
            else if (age >= 18 && gender == "F" && color == "Purple" && animal == "Fish"){
                Console.WriteLine("You are a creative and intuitive person.");
            }
            else{
                Console.WriteLine("Sorry, we couldn't determine your personality trait based on your answers.");
            }
            Console.ReadLine();
        }

        public static void determineAge(int year,int month, int date)
        {
            DateTime birthdate = new DateTime(year, month, date); 
            TimeSpan age = DateTime.Today - birthdate;
            float years = (float)(age.TotalDays / 365.25); 
            Console.WriteLine("Age: " + years.ToString("0.00"));
        }
        static void Main(string[] args)
        {
           // determinePersonality();
            determineAge(2000,3,28);
        }
    }
}