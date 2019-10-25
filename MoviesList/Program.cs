/*Program: Movies list
 *Programmer: Ivoire Morrell 
 *Date: 10-24-19 
 *Description: This proram creates a list of movie 
 *objects and allows the user to print out movies by category
 * 
 */
using System;
using System.Collections.Generic;

namespace MoviesList
{
    class Program
    {
        static void Main(string[] args)
        {
            //initalize variables
            bool ok = true;
            int selection;
            List<string> categoryMovies = new List<string>();

            //initalize list of movies with at least 10 movies
            List<Movie> movieList = new List<Movie>
            {
                new Movie("The Dark Knight", "Action"),
                new Movie("The Departed", "Crime"),
                new Movie("Shutter Island", "Mystery"),
                new Movie("12 Years A Slave", "Biography"),
                new Movie("Kill Bill V1", "Action"),
                new Movie("Goodfellas", "Biography"),
                new Movie("Wolf on Wall Street", "Biography"),
                new Movie("Pirates of the Carabean: Dead Mans Chest", "Action"),
                new Movie("Scarface", "Crime"),
                new Movie("Traning Day", "Crime"),

            };

            //welcome the user to the program
            Console.WriteLine("Welcome to the movie application! \n");

            Console.WriteLine("There're are 10 movies in this list. \n");

            //wrap code in while loop to determine if the user wants to slect a different category
            while (ok)
            {


                //Display the category list
                Movie.PrintMovieCategories(movieList);

                Console.WriteLine();

                //call the ParseString method to convert users 
                //string input to int and check if number is valid
                selection = ValidateRange("Which category would you like to choose from? \n", 1, movieList.Count - 1);

                //call movies by category method
                categoryMovies = Movie.PrintMovieByCategory(movieList, selection);

                Console.WriteLine();

                //sort category movies
                categoryMovies.Sort();

                //print out the movies
                foreach (string movie in categoryMovies)
                {
                    Console.WriteLine(movie);
                }

                Console.WriteLine();
                //ask user if they would like to go again
                ok = GetContinue("Continue (y/n)\n");
                Console.WriteLine();
            }
}
        public static int ValidateRange(string message, int min, int max)
        {
            int number = ParseString(message);

            if (number >= min && number < max)
            {
                return number;
            }
            else
            {
                //This student does not exist
                Console.WriteLine("This category does not exist.\n");
                return ValidateRange(message, min, max);
            }
        }
        public static int ParseString(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad input. We need a number \n");
                return ParseString(message);
            }

        }
        public static string GetUserInput(string message)
        {
            string input;

            Console.WriteLine(message);

            input = Console.ReadLine();

            return input;
        }
        public static bool GetContinue(string message)
        {
            //create variables
            String choice;
            bool ok = true;
            bool result = true;

            //create while loop to determine if user wants to continue
            while (ok)
            {
                Console.WriteLine(message);

                //retrieve user input
                choice = Console.ReadLine();

                //determine the users input and return corresponding message
                if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    //user wants to continue. exit the while loop and return true
                    ok = false;
                    result = true;
                }
                else if (choice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    //user does not want to continue
                    ok = false;
                    result = false;
                }
                else
                {
                    //user did not enter y or n
                    Console.WriteLine("Error! Please enter Y or N. Please enter correct input \n");
                }

            }

            return result;
        }
    }
}
