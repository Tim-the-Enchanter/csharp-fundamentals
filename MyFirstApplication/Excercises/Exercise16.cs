namespace MyFirstApplication;
// CAC-103 Exercise 16 Collections
internal class Exercise16
{
    /*
     1. Write a method that has no parameters and a no return type. Create a List<T> of your Horse objects.
    When creating your list, utilize all the constructors you created with your Horse class. Using a foreach 
    loop, printout the results of your collection using a Console WriteLine statement.
     */
    public void MyHorseList()
    {
        List<string> myStringList = new List<string>();
        myStringList.Add("Size");
        myStringList.Add("9 Hands");
        myStringList.Add("Mane");
        myStringList.Add("Flowing");
        myStringList.Add("Motion");
        myStringList.Add("Grazing");

        foreach (string item in myStringList)
        {
            Console.WriteLine(item);
        }
    }

    /*
     2. Write a method that has no parameters and noreturn type. Using only the data you used when building 
    your favorite movies from exercise 15, create a Dictionary collection that takes an int key and string 
    value. When adding Dictionary elements, pick an int value as the key and use the favorite movies data 
    as the string. Using a foreach loop, print out the results of your collection using a Console WriteLine 
    statement.
     */

    public void MyMovieDictionary()
    {
        Dictionary<int, string> phrases = new Dictionary<int, string>();
        phrases.Add(6, "ZombieLand"); 
        phrases.Add(9, "JohnWick");
        phrases.Add(7, "Matrix");
        phrases.Add(10, "DeadPool");

        string value;
        if (phrases.TryGetValue(10, out value))
        {
            Console.WriteLine($"I rated {value} - 10 Stars");
        }
        // iterate through the list
        foreach (KeyValuePair<int, string> item in phrases)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

    }
}
