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
            string gender = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.Write("What is your favorite animal? ");
            string animal = Console.ReadLine();

            Console.WriteLine("\nPersonality trait:");

            if (age >= 18 && gender == "M" && color == "Blue" && animal == "Dog"){
                Console.WriteLine("You are a sweet person.");
            }
            else if (age >= 18 && gender == "F" && color == "Pink" && animal == "Cat"){
                Console.WriteLine("You are an independent person.");
            }
            else if (age >= 18 && gender == "M" && color == "Green" && animal == "Bird"){
                Console.WriteLine("You are an adventurous person.");
            }
            else if (age >= 18 && gender == "F" && color == "Purple" && animal == "Fish"){
                Console.WriteLine("You are a creative person.");
            }
            else{
                Console.WriteLine("Sorry, we couldn't determine your personality.");
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

        public static void determineZodiac()
        {
            Console.Write("Enter month number: ");
            int month = Convert.ToInt32(Console.ReadLine());

            string zodiacSign = "";

            switch (month)
            {
                case 1: // January
                    zodiacSign = "Capricorn";
                    break;
                case 2: // February
                    zodiacSign = "Aquarius";
                    break;
                case 3: // March
                    zodiacSign = "Pisces";
                    break;
                case 4: // April
                    zodiacSign = "Aries";
                    break;
                case 5: // May
                    zodiacSign = "Taurus";
                    break;
                case 6: // June
                    zodiacSign = "Gemini";
                    break;
                case 7: // July
                    zodiacSign = "Cancer";
                    break;
                case 8: // August
                    zodiacSign = "Leo";
                    break;
                case 9: // September
                    zodiacSign = "Virgo";
                    break;
                case 10: // October
                    zodiacSign = "Libra";
                    break;
                case 11: // November
                    zodiacSign = "Scorpio";
                    break;
                case 12: // December
                    zodiacSign = "Sagittarius";
                    break;
                default:
                    zodiacSign = "none";
                    break;
            }
            
            Console.WriteLine(zodiacSign);

        }
        static void Main(string[] args)
        {
            // determinePersonality();
            determineZodiac();
            //determineAge(2000,3,28);
        }
    }
}