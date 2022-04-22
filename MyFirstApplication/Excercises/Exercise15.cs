namespace MyFirstApplication;
// CAC-103 Exercise 15 Enums & Tuples

/*
 1. Above the class, write an enum called Favorite Movies. Add your own favorite movies to the enum. 
Write a method that has a string return type and an enum parameter. This enum parameter will be your 
favorite movie enum. Write a switch expression that takes the enum and prints out a string return. 
Use string interpolation in your return message that includes the name of the movie chosen.
 */

public enum favoriteMovies { ZombieLand, JohnWick, Matrix, DeadPool };

internal class Exercise15
{
    public string MyFavorite(favoriteMovies movie)
    {
        string message = movie switch
        {
            favoriteMovies.ZombieLand => $"My favorite is {favoriteMovies.ZombieLand}.",
            favoriteMovies.JohnWick => $"My favorite is {favoriteMovies.JohnWick}.",
            favoriteMovies.Matrix => $"My favorite is {favoriteMovies.Matrix}.",
            _ => $"My favorite movie is {favoriteMovies.DeadPool}."
        };
        return message;
    }

    /*
     2. Write a method that takes an enum parameter. This enum will be your favorite movie enum. The method 
    will have a tuple return type(intnum, stringmovie).Using an explicit int cast on one of your enum, assign 
    the value to an int variable. Create second variable of type string. Assign the same enum value you used 
    and use the ToString() at the end of it. Return both variables as a tuple.See example below for clarity.
    a.Int value = (int)Enum.Value;
    b.string something = Enum.Value.ToString();
    */
    public (int num, string movie) MyMovie(favoriteMovies movie)
    {   // tuple method
        int val1 = (int)favoriteMovies.ZombieLand;
        string val2 = movie.ToString();
        return (val1, val2);
    }
    

}
    

