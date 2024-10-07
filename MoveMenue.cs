using Movie_Class_Library;
using System;
public class MovieMenu
{
    static MovieManager manager = new MovieManager();

    public static void ShowMenu()
    {
        Console.WriteLine("======Welcome To Movie manager======");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Choose Your Option");
            Console.WriteLine("1.Display Movies");
            Console.WriteLine("2.Add New Movie");
            Console.WriteLine("3.Edit Movie");
            Console.WriteLine("4.Find Movie By Id");
            Console.WriteLine("5.Find Movie By Name");
            Console.WriteLine("6.Remove Movie By Id");
            Console.WriteLine("7.Remove Movie By Name");
            Console.WriteLine("8.Clear All Movies");
            Console.WriteLine("9.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayMovies();
                    break;
                case 2:
                    AddNewAccount();
                    break;
                case 3:
                    EditMovie();
                    break;
                case 4:
                    FindMovieById();
                    break;
                case 5:
                    FindMovieByName();
                    break;
                case 6:
                    RemoveMovieById();
                    break;
                case 7:
                    RemoveMovieByName();
                    break;
                case 8:
                    ClearAllMovies();
                    break;
                case 9:
                    Exit();
                    break;
                default:
                    break;
            }
        }

    }
    public static void DisplayMovies()
    {
        try
        {
            manager.DisplayMovies();
        }
        catch (IsEmptyException ac)
        {
            Console.WriteLine(ac.Message);
        }
        Console.WriteLine();
    }
    public static void AddNewAccount()
    {
        try
        {
            Console.Write("Enter Movie Id:");
            double movieId = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter MovieName:");
            string movieName = Console.ReadLine();
            Console.Write("Enter MovieGener:");
            string movieGenre = Console.ReadLine();
            Console.Write("Enter MovieYear:");
            double movieYear = Convert.ToDouble(Console.ReadLine());
            manager.AddNewMovie(movieId, movieName, movieGenre, movieYear);//exception
        }
        catch (ListOverFlowException ac)
        {
            Console.WriteLine(ac.Message);
        }
        Console.WriteLine();
    }
    public static void EditMovie()
    {
        try
        {
            Console.Write("Enter Movie Id:");
            double movieId = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter MovieName:");
            string newmovieName = Console.ReadLine();
            Console.Write("Enter MovieGener:");
            string newmovieGenre = Console.ReadLine();
            Console.Write("Enter MovieYear:");
            double newmovieYear = Convert.ToDouble(Console.ReadLine());
            manager.EditMovie(movieId, newmovieName, newmovieGenre, newmovieYear);
            Console.Write("Movie Edited succesfully");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
    }
    public static void FindMovieById()
    {
        try
        {
            Console.Write("Enter Movie Id:");
            int movieId = Convert.ToInt32(Console.ReadLine());

            manager.FindMovieById(movieId);
            var movie = manager.FindMovieById(movieId);
            if (movie != null)
            {
                Console.WriteLine($"MovieId::{movie.MovieId}");
                Console.WriteLine($"MovieName::{movie.MovieName}");
                Console.WriteLine($"MovieGener::{movie.MovieGenre}");
                Console.WriteLine($"MovieYear::{movie.MovieYear}");

            }
        }
        catch (FindMovieByIdException ex)
        {
            Console.WriteLine(ex.Message);
        }
       
        Console.WriteLine();

    }
    public static  void FindMovieByName()
    {
        try
        {
            Console.Write("Enter Movie Name:");
            string movieName = Console.ReadLine();
           var movie= manager.FindMovieByName(movieName);
            if (movie != null)
            {
                Console.WriteLine($"MovieId::{movie.MovieId}");
                Console.WriteLine($"MovieName::{movie.MovieName}");
                Console.WriteLine($"MovieGener::{movie.MovieGenre}");
                Console.WriteLine($"MovieYear::{movie.MovieYear}");

            }
        }
        catch (FindMovieByNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
        

        Console.WriteLine();

    }
    public static void RemoveMovieById()
    {
        try
        {
            Console.Write("Enter Movie Id:");
            double movieId = Convert.ToDouble(Console.ReadLine());
            manager.RemoveMovieById(movieId);




        }
        catch (RemoveMoviessException ab)
        {
            Console.WriteLine(ab.Message);
        }
        catch (Exception ab)
        {
            Console.WriteLine(ab.Message);
        }

        Console.WriteLine("Removed Succesfully");

        Console.WriteLine();

    }
    public static void RemoveMovieByName()
    {
        try
        {
            Console.Write("Enter Movie Name:");
            string movieName = Console.ReadLine();
            manager.RemoveMovieBYName(movieName);
        }
        catch(Exception ab)
        {
            Console.WriteLine(ab.Message);
        }
        Console.WriteLine("Removed Succesfully");

        Console.WriteLine();
    }
    public static void ClearAllMovies()
    {
        Console.WriteLine();
        manager.ClaerAllMovies();
        Console.WriteLine("All Movies cleared");

    }
    public static void Exit()
    {
        manager.Exit();
        Console.WriteLine("Exiting.....");
    }
}

