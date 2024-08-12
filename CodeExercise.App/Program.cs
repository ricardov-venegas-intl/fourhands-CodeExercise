using CodeExercise.Core;

namespace CodeExercise.App;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var fizzBuzzEngine = new FizzBuzzEngine();
        fizzBuzzEngine.Run();
    }
}