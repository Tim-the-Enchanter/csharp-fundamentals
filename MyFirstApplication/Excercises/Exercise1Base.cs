namespace MyFirstApplication
{
    public class Exercise1Base
    {

        /*
        2. Write a method that will accept 3 argument parameters and a void return type.
        // Parameters are byte, short and int. Use Implicit conversion with variables converted
        from byte to int, from short to long and int to float
        */
        public void ExcerciseImplicit()
        {
            Exercise1 myLesson = new Exercise1();
            byte vIn = 35;
            int vOut = Convert.ToInt32(vIn);
            Console.WriteLine(vOut);
            Console.WriteLine(vIn);

            int intToConvert = 35;
            byte resultAsByte = (byte)intToConvert;

        }
    }
}