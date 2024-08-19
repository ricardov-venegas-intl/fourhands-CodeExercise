using CodeExercise.Core;

namespace CodeExercise.Tests
{
    [TestClass]
    public class FizzBuzzEngineTests
    {
        [TestMethod]
        [DataRow(0, "FizzBuzz")] // Special Case 0
        [DataRow(1, "1")] // Special Case 1
        [DataRow(3, "Fizz")] // Regular cases
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(14, "14")] // Before and after FizzBuzz
        [DataRow(15, "FizzBuzz")]
        [DataRow(16, "16")]
        [DataRow(-1, "-1")] // Negative number cases
        [DataRow(-3, "Fizz")]
        [DataRow(-4, "-4")]
        [DataRow(-5, "Buzz")]
        [DataRow(-6, "Fizz")]
        [DataRow(-14, "-14")]
        [DataRow(-15, "FizzBuzz")]
        [DataRow(-16, "-16")]
        public void TestGenerateOutput(int target, string expectedOutput)
        {
            var fizzBuzzEngine = new FizzBuzzEngine();

            var output = fizzBuzzEngine.GenerateOutput(target);

            Assert.AreEqual(expectedOutput, output);
        }

    }
}