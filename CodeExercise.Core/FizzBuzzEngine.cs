namespace CodeExercise.Core;

public class FizzBuzzEngine : IOutputEngine
{
    FizzRule fizzRule = new FizzRule();

    public KeyValuePair<int,string> GenerateOutput(int number)
    {
        string output = "";

        if (number % 7 == 0)
        {
            output = "Bar";
        }
        else
        {
            if (fizzRule.GenerateOutput(number, output, out output) == false)
            {
                return new KeyValuePair<int, string>(number, output);
            }

            if (number % 5 == 0)
            {
                output += "Buzz";
            }
            if (output.Length == 0)
            {
                output = number.ToString();
            } 
        }
        if (number % 9 == 0)
        {
            output = output.ToUpper();
        }

        return new KeyValuePair<int,string>(number, output);
    }
}
