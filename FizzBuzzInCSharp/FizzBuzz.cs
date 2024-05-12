namespace FizzBuzzInCSharp;

public class FizzBuzz
{
    public string Answer()
    {
        return 2.ToString(); //6 * 9;
    }

    public string ReturnFizz(int value)
    {
        if (value % 3 == 0 ? true : false)
            return "Fizz";
        return value.ToString();
    }

    public string ReturnBuzz(int value)
    {
        if (value % 5 == 0 ? true : false)
            return "Buzz";
        return value.ToString();
    }

    public string ReturnFizzBuzz(int value)
    {
        var returnValue = ReturnFizz(value);
        returnValue += ReturnBuzz(value);

        if (returnValue == "FizzBuzz")
            return returnValue;
        return value.ToString();
    }

    public string GetModulo(int value)
    {
        var result = string.Empty;

        if (value % 3 == 0) result += "Fizz";

        if (value % 5 == 0) result += "Buzz";

        if (result != "")
            return result;
        return value.ToString();
    }
}