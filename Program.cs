using moviesEFLab.models;
using moviesEFLab;

public class Program
{
    public static void Main()
    {
         MoviesCRUD crud = new MoviesCRUD();

        /*Movie a = new Movie() { Title = "Robin Hood Men in Tights", Genre = "comedy", Runtime = 193 };
        Movie b = new Movie() { Title = "Space Jam", Genre = "comedy", Runtime = 93 };
        Movie c = new Movie() { Title = "Scream", Genre = "horror", Runtime = 124 };
        Movie d = new Movie() { Title = "Men In Black", Genre = "action", Runtime = 234 };
        Movie e = new Movie() { Title = "Predator", Genre = "action", Runtime = 129 };
        Movie f = new Movie() { Title = "Monty Python and the Holy Grail", Genre = "comedy", Runtime = 69 };
        Movie g = new Movie() { Title = "Paranormal Activity", Genre = "horror", Runtime = 85 };
        Movie h = new Movie() { Title = "Shrek", Genre = "comedy", Runtime = 271 };
        Movie i = new Movie() { Title = "Rambo", Genre = "action", Runtime = 154 };
        Movie j = new Movie() { Title = "American Psycho", Genre = "horror", Runtime = 123 };
        Movie k = new Movie() { Title = "Shrek 2", Genre = "comedy", Runtime = 145 };

        crud.AddMovie(a);
        crud.AddMovie(b);
        crud.AddMovie(c);
        crud.AddMovie(d);
        crud.AddMovie(e);
        crud.AddMovie(f);
        crud.AddMovie(g);
        crud.AddMovie(h);
        crud.AddMovie(i);
        crud.AddMovie(j);
        crud.AddMovie(k);*/

        bool goAgain = true;

        while (goAgain)
        {

            try
            {

                Console.WriteLine("Welcome to the movies database. Please enter 1 to search by movie Genre. Please press 2 to see if a specific title is available in our database.");
                int userResponse = int.Parse(Console.ReadLine());
                if (userResponse == 1)
                {
                    SearchByGenre();
                    
                }
                else if (userResponse == 2)
                {
                    SearchByTitle();
                    
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid input");
                    continue;
                }

            }
            catch
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                continue;
            }

            goAgain = GoAgain();

        }







    }

    public static void SearchByGenre()
    { while (true)
        {
            MoviesCRUD crud = new MoviesCRUD();
            Console.WriteLine("Please select a genre of movie that you would like to see");
            string userResponse = Console.ReadLine().ToLower().Trim();

            if (userResponse == "comedy")
            {
                List<string> comedy = new List<string>();
                for (int i = 0; i < crud.GetMovies().Count; i++)
                {
                    if (crud.GetMovies()[i].Genre == "comedy")
                    {
                        comedy.Add(crud.GetMovies()[i].Title);
                        
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Here are our Comedy films");
                for (int i = 0; i < comedy.Count; i++)
                {
                    Console.WriteLine(comedy[i]);

                }
                break;
            }
            else if (userResponse == "action")
            {
                List<string> action = new List<string>();
                for (int i = 0; i < crud.GetMovies().Count; i++)
                {
                    if (crud.GetMovies()[i].Genre == "action")
                    {
                        action.Add(crud.GetMovies()[i].Title);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Here are our Action films");
                for (int i = 0; i < action.Count; i++)
                {
                    Console.WriteLine(action[i]);
                }
                break;
            }
            else if (userResponse == "horror")
            {
                List<string> horror = new List<string>();
                for (int i = 0; i < crud.GetMovies().Count; i++)
                {
                    if (crud.GetMovies()[i].Genre == "horror")
                    {
                        horror.Add(crud.GetMovies()[i].Title);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Here are our Horror films");
                for (int i = 0; i < horror.Count; i++)
                {
                    Console.WriteLine(horror[i]);
                }
                break;
            }
            else
            {
                Console.WriteLine("Sorry, we don't have any films in that genre.");
                continue;
            }
        }
    }
    public static void SearchByTitle()
    { MoviesCRUD crud = new MoviesCRUD();
        Console.WriteLine("Please let us know the title of the film that you would like to search for");
        string userResponse = Console.ReadLine().Trim();
        bool movieFound = false;
        for (int i = 0; i < crud.GetMovies().Count; i++)
        {
            if (crud.GetMovies()[i].Title.Contains(userResponse))
            {
                movieFound = true;
            }
            
        }
        if (movieFound == true)
        {
            Console.WriteLine($"We found {userResponse} in our database.");
        }
        else
        {
            Console.WriteLine($"We do not have {userResponse} in our database");
        }
    }
    public static  bool GoAgain()
    {
        

            Console.WriteLine("Would you like to run the program again? Please enter y/n");
            string userResponse = Console.ReadLine().Trim().ToLower();

            if (userResponse == "y")
            {
                return true;
            }
            else if (userResponse == "n")
            {
                return false;
               

            }
            else
            {
                Console.WriteLine("Sorry, I didn't quite get that. Please enter y or n");
                return GoAgain();
            }
        
    }

    
}