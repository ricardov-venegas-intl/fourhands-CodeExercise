namespace CodeExercise.Core;

public class FizzBuzzEngine
{
    public void Run(int limit = 100)
    {
        for (int i = 1; i <= limit; i++)
        {
            string output = "";
            if (i % 3 == 0)
            {
                output += "Fizz";
            }

            // TODO: Finish the FizzBuzz implementation

            Console.WriteLine("{0}: {1}", i, output);
        }
    }
}
