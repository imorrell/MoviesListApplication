using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesList
{
   public class Movie
    {

        #region fields
        private string title;
        private string category;
        #endregion

        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }

        }

        public string Category
        {
            get { return category; }
            set { category = value; } 
        }
        #endregion

        #region methods
        public Movie()
        {


        }

        public Movie(string movieTitle, string movieCategory)
        {
            title = movieTitle;
            category = movieCategory;
        }

        private static List<string> MovieCategory(List<Movie> list)
        {
            List<String> movieCategory = new List<string>();

            foreach (Movie movie in list)
            {
                if (!movieCategory.Contains(movie.Category))
                {
                    movieCategory.Add(movie.Category);
                }
            }

            return movieCategory;
        }

        public static void PrintMovieCategories(List<Movie> movieList)
        {
            List<string> movieCategory = Movie.MovieCategory(movieList);

            for (int i = 0; i < movieCategory.Count; i++)
            {
                Console.WriteLine($"{i+1}. {movieCategory[i]}");
            }

        }

        //The print out movie by category method accepts a movies list and integer. 
        //It will print out movies based off number selection
        public static List<string> PrintMovieByCategory(List<Movie> movieList, int selection)
        {
            List<string> moviesCategory = new List<string>();

            //use switch statement to process the users input
            switch (selection)
            {
                //user chooses action
                case 1:
                    {
                        Console.WriteLine("Action movies");
                        //print out all the movies in the list that are action
                        for (int i = 0; i < movieList.Count; i++)
                        {
                            if (movieList[i].Category.Equals("action", StringComparison.OrdinalIgnoreCase))
                            {
                                //print out action movies
                                moviesCategory.Add(movieList[i].Title);
                            }
                        }
                        return moviesCategory;
                    }
                //user chooses crime
                case 2:
                    {
                        Console.WriteLine("Crime movies");
                        //print out all the movies in the list that are crime
                        for (int i = 0; i < movieList.Count; i++)
                        {
                            if (movieList[i].Category.Equals("crime", StringComparison.OrdinalIgnoreCase))
                            {
                                //print out action movies
                                moviesCategory.Add(movieList[i].Title);
                            }
                        }

                        return moviesCategory;
                    }

                //user chooses mystery
                case 3:
                    {
                        Console.WriteLine("Mystery movies");
                        //print out all the movies in the list that are mystery
                        for (int i = 0; i < movieList.Count; i++)
                        {
                            if (movieList[i].Category.Equals("mystery", StringComparison.OrdinalIgnoreCase))
                            {
                                //print out action movies
                                moviesCategory.Add(movieList[i].Title);
                            }
                        }
                        return moviesCategory;
                    }

                //user chooses biography
                case 4:
                    {
                        Console.WriteLine("Biography movies");
                        //print out all the movies in the list that are mystery
                        for (int i = 0; i < movieList.Count; i++)
                        {
                            if (movieList[i].Category.Equals("biography", StringComparison.OrdinalIgnoreCase))
                            {
                                //print out action movies
                                moviesCategory.Add(movieList[i].Title);
                            }
                        }
                        return moviesCategory;
                    }
                default:
                    {
                        //movie category not found
                        Console.WriteLine("Movie catergory not found. \n");
                        return moviesCategory;
                    }
                    
            }
        }
        #endregion
        
    }
}
