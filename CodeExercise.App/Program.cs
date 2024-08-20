using CodeExercise.Core;

namespace CodeExercise.App;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var fizzBuzzEngine = new FizzBuzzEngine();
        for (int i = 0; i <= 100; i++)
        {
            var kv = fizzBuzzEngine.GenerateOutput(i);
            Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
        }
    }
}