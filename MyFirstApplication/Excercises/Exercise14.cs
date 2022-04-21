namespace MyFirstApplication;
// CAC-103 Exercise 14 Arrays

/*
 1.Write a method with no parameters and no return type. Write a single dimensional string array of ice cream flavors.
Using a foreach loop in your method, print out the results of your array using a Console WriteLine statement.
*/

internal class Exercise14
{
    // Single Dimension Array of Ice Cream Flavors
    public void IceCreamFlavors()
    {
        string[] flavors = { "Moose Tracks", "Pralines & Cream", "Stawberry Cheescake", "Neopolitan" };

        foreach (string item in flavors)
        {
            Console.WriteLine(item);
        }
    }

    /*
    2.Write a method with no parameters and no return type. Write a two-dimensional array using the int data type.
    Using the link below, fill in each dimension with the KC Chiefs Regular season scores. The first dimension will 
    be the home team, while the second dimension will be the away team. Using a for each loop, print out the results
    of your array using a Console WriteLine statement. To determine which team is home and away, the website includes
    the link to the box score. The link label shows both teams. The first team in the label is the away team.
    a.https://www.footballdb.com/teams/nfl/kansas-city-chiefs/results/2020
    */


    // Multi-dimensional string array using for loop.
    public void KcCheifsScores()
    {
        int[,] myKcscores = { { 34, 23, 34, 26, 32, 26, 43, 35, 33, 35, 27, 29, 17, 21 },
            { 20, 20, 20, 10, 40, 17, 16, 9, 31, 31, 24, 29, 14, 38 } };

        for (int h = 0; h < myKcscores.GetLength(0); h++)
        {
            for (int a = 0; a < myKcscores.GetLength(1); a++)
            {
                Console.WriteLine(myKcscores[h, a]);
            }
        }

    }
} // end class