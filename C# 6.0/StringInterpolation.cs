using System;

class Program
{
    static void Main(string[] args)
    {
        #region General String Format

        string name="Alperen",surname="Güneş",ID="12345678910";
        int age = 23;

        Console.WriteLine("Identity Number: " + ID + ", Name: " + name + ", Surname: " + surname +
            ", Age: " + age ) ;

        #endregion

        #region $(String Interpolation) (C# 6.0)




        Console.WriteLine($"Identity Number: {ID}, Name: {name}, Surname: {surname}, Age: {age}");


        #endregion
        //The conclusion is the genereal string format not as efficient as String Interpolation which came with 



        // Wait for user input before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
