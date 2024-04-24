using ConsoleApp1.LabSession.Lab6_19April;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab6_19April
{
    public class Movie
    {
        public int MovieId { set; get; }
        public string MovieName { set; get; }
        public double TicketCost { set; get;}
        public string ProducerName { set; get; }
   
    }

    public class MovieMain
    {
        static Movie[] movies = new Movie[10];
        static int count = 0;

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("-----------Movie------------");
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Update Movie");
                Console.WriteLine("3.Delete Movie");
                Console.WriteLine("4.Display Movie by Id");
                Console.WriteLine("5.Display All Movies");
                Console.WriteLine("6.Search Movie By Name");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        InsertMovie();
                        break;
                    case 2:
                        UpdateMovie();
                        break;
                    case 3:
                        DeleteMovie();
                        break;

                    case 4:
                        DisplayMovieById();
                        break;
                    case 5:
                        DisplayAllMovies();
                        break;
                    case 6:
                        SearchMovieByName();
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;


                }
            }
        }


        public static void InsertMovie()
        {
            if (count<movies.Length) {
                Movie movie = new Movie();
                Console.WriteLine("Enter Movie Id:");
                movie.MovieId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Movie Name:");
                movie.MovieName = Console.ReadLine();
                Console.WriteLine("Enter Ticket Cost:");
                movie.TicketCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Producer Name:");
                movie.ProducerName = Console.ReadLine();

                movies[count++] = movie;
                Console.WriteLine("Movie Added successfully...");
            }
            else
            {
                Console.WriteLine("Movie array is full ...");
            }
        }

        public static void UpdateMovie()
        {
            Console.WriteLine("Enter Movie Id to Update:");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = FindMovieById(id);

            if (index != -1)
            {
                Console.WriteLine("Enter Movie Name:");
                movies[index].MovieName = Console.ReadLine();
                Console.WriteLine("Enter Ticket Cost:");
                movies[index].TicketCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Producer Name:");
                movies[index].ProducerName = Console.ReadLine();
                Console.WriteLine("Movie Updated Successfully...");

                Console.WriteLine("\n-------------------------------");
                DisplayAllMovies();
                Console.WriteLine("\n-------------------------------");
            }
        }

        public static void DeleteMovie() 
        {
            Console.WriteLine("Enter Movie Id to Delete:");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = FindMovieById(id);

            if (index != -1)
            {
                for (int i = index;i< count -1;i++)
                {
                    movies[i] = movies[i+1];
                }
                count--;
                Console.WriteLine("Movie Deleted Successfully...");
            }

            Console.WriteLine("\n-------------------------------");
            DisplayAllMovies();
            Console.WriteLine("\n-------------------------------");
        }


        static void DisplayMovieById()
        {
            Console.Write("Enter Movie Id to display: ");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = FindMovieById(id);
            if (index != -1)
            {
                Console.WriteLine($"Movie Id: {movies[index].MovieId}");
                Console.WriteLine($"Movie Name: {movies[index].MovieName}");
                Console.WriteLine($"Ticket Cost: {movies[index].TicketCost}");
                Console.WriteLine($"Producer Name: {movies[index].ProducerName}");
            }
            else
            {
                Console.WriteLine("Movie not found with the given Id...");
            }
        }

        public static void DisplayAllMovies()
        {
            Console.WriteLine("Display All Movies:");

            for (int i = 0; i <count ; i++)
            {
                Console.WriteLine($"Movie Id: {movies[i].MovieId}, Name: {movies[i].MovieName}, Ticket Cost: {movies[i].TicketCost}, Producer Name: {movies[i].ProducerName}");
            }
        }

        public static void SearchMovieByName()
        {
            Console.Write("Enter Movie Name to Search:");
            string name = Console.ReadLine();
            for (int i = 0;i <count ; i++)
            {
                if (movies[i].MovieName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Movie Id: {movies[i].MovieId}");
                    Console.WriteLine($"Movie Name: {movies[i].MovieName}");
                    Console.WriteLine($"Ticket Cost: {movies[i].TicketCost}");
                    Console.WriteLine($"Producer Name: {movies[i].ProducerName}");
                }
            }
        }
        public static int FindMovieById(int id)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].MovieId == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

/*Movie Id: 1, Name: Gangs of Wasseypur, Ticket Cost: 340, Producer Name: Anurag Kashyap
Movie Id: 2, Name: 3 Idiots, Ticket Cost: 400, Producer Name: Rajkumar Hirani
Movie Id: 3, Name: Water, Ticket Cost: 200, Producer Name: Deepti Misra*/
