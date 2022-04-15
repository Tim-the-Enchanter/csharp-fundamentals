// CAC-103 Exercise 7 Structs & Records

namespace MyFirstApplication;
    /*
     1.Change the type from class to struct. Change the name of the struct from Exercise7 to Employee.
    The file name should not be changed. Create 2 struct variables. The first one will be of type int and be named _id.
    The second variable should be of type string and be named _name. Create a constructor that takes 2 arguments, with 
    the first being an int and the second a string. The struct variables should be assigned to the constructor parameters.
    Create properties for these 2 variables.
    */

internal struct Employee
{   // struct variables
    private readonly int _id;
    private readonly string _name;

    // constructor
    public int Id
    {
        get { return _id; }
    }

    public string EmployeeName
    {
        get { return _name; }
    }   
    public Employee (int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

} // End Struct
    
    /*
    2.Create a Record based on your Boat object from the Object Oriented Programming lesson. In your record body, include 
    the boat method that you defined. This record can be in the same file as exercise 1. Just put the code under it as seen 
    in the lecture. Test your record to ensure it is working correctly.       
     */




