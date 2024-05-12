namespace FizzBuzzInCSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        var testNumbers = 100;
        var fizzbuzz = new FizzBuzz();
        Console.WriteLine("Hello, World!");
        int numberToCheck;
        for (numberToCheck = 1; numberToCheck < testNumbers; numberToCheck++)
        {
            var result = fizzbuzz.GetModulo(numberToCheck);
            Console.WriteLine(result);
        }
    }
}