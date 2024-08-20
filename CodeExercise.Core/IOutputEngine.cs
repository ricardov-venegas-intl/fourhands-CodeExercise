namespace CodeExercise.Core
{
    public interface IOutputEngine
    {
        KeyValuePair<int,string> GenerateOutput(int number);
    }
}