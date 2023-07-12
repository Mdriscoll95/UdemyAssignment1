namespace UdemyAssignment1;

class Program
{
    static void Main(string[] args)
    {
        string stringForFloat = "0.85"; // datatype should be float
        string stringForInt = "12345"; // datatype should be int
        float f = float.Parse(stringForFloat);
        int i = Int32.Parse(stringForInt);

        System.Console.WriteLine("Int = {0}, Float = {1}", i, f);
        Console.Read();
    }
}

