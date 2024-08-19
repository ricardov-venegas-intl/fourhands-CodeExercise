namespace CodeExercise.Core;

public class FizzBuzzEngine : IOutputEngine
{
    public string GenerateOutput(int number)
    {
        string output = "";
        if (number % 3 == 0)
        {
            output += "Fizz";
        }
        if (number % 5 == 0)
        {
            output += "Buzz";
        }
        if (output.Length == 0)
        {
            output = number.ToString();
        }
        return output;
    }
}
