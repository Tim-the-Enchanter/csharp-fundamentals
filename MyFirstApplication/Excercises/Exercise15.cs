namespace MyFirstApplication;
// CAC-103 Exercise 15 Enums & Tuples

/*
 1. Above the class, write an enum called Favorite Movies. Add your own favorite movies to the enum. 
Write a method that has a string return type and an enum parameter. This enum parameter will be your 
favorite movie enum. Write a switch expression that takes the enum and prints out a string return. 
Use string interpolation in your return message that includes the name of the movie chosen.
 */

public enum MyMovies { ZombieLand, JohnWick, Matrix, DeadPool };

internal class Exercise15
{
    public string FavoriteMovies(MyMovies movies)
    {
        string message = movies switch
        {
            MyMovies.ZombieLand => $"My favorite is {MyMovies.ZombieLand}.",
            MyMovies.JohnWick => $"My favorite is {MyMovies.JohnWick}.",
            MyMovies.Matrix => $"My favorite is {MyMovies.Matrix}.",
            _ => $"My favorite movie is {MyMovies.DeadPool}."
        };
        return message;
    }
}
/*
2. Write a method that takes an enum parameter. This enum will be your favorite movie enum. The method 
will have a tuple return type(intnum, stringmovie).Using an explicit int cast on one of your enum, assign 
the value to an int variable. Create second variable of type string. Assign the same enum value you used 
and use the ToString() at the end of it. Return both variables as a tuple.See example below for clarity.
a.Int value = (int)Enum.Value;
b.string something = Enum.Value.ToString();

*/
/*
 // Write a method that takes an enum parameter
public (int num, string movie) MyMovies(favoriteMovies movie)
{
    // method that returns a tuple.
    int val = (int)favoriteMovies.Batman;
    string val1 = movie.ToString();
    return (val, val1);
}

}
*/

