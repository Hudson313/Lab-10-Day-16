using Lab_10_Day_16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list. ");

            string userContinue;
            do
            {
                Console.WriteLine("What category are you interested in? ");

                string userCategoryInterested;

                Console.WriteLine("Please enter one of these categories: animated drama horror or scifi ");
                userCategoryInterested = Console.ReadLine();
                do
                {
                    if (userCategoryInterested == "animated" || userCategoryInterested == "drama" || userCategoryInterested == "horror" || userCategoryInterested == "scifi")
                    { break; }

                    else

                    {
                        Console.WriteLine(" Oops! Please enter one of these categories: animated drama horror or scifi ");
                        userCategoryInterested = Console.ReadLine();

                    }

                }

                while (userCategoryInterested != "animated" || userCategoryInterested != "drama" || userCategoryInterested != "horror" || userCategoryInterested != "scifi");


                List < Movie > filteredList = new List<Movie>();



                    foreach (Movie movie in MovieIO.default_MovieCatalog)
                    {
                        if (movie.HasCategory(userCategoryInterested))
                        {

                            filteredList.Add(movie);
                        }
                    }

                    for (int i = 0; i < filteredList.Count; i++)
                    {

                        Console.WriteLine(filteredList[i].Title);
                        if (i > 10) { break; }
                    }

                Console.WriteLine("Continue? (y/n)");
                userContinue = Console.ReadLine();                     
            }


       while (userContinue.ToLower() == "y");
        }
    }
}
