using CodeExercise.Core;

namespace CodeExercise.Tests
{
    [TestClass]
    public class FizzBuzzEngineTests
    {
        [TestMethod]
        [DataRow(0, "BAR")] // Special Case 0
        [DataRow(1, "1")] // Special Case 1
        [DataRow(3, "Fizz")] // Regular cases
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(7, "Bar")]
        [DataRow(9, "FIZZ")]
        [DataRow(14, "Bar")] // Before and after FizzBuzz
        [DataRow(15, "FizzBuzz")]
        [DataRow(45, "FIZZBUZZ")]
        [DataRow(63, "BAR")]
        [DataRow(16, "16")]
        [DataRow(-1, "-1")] // Negative number cases
        [DataRow(-3, "Fizz")]
        [DataRow(-4, "-4")]
        [DataRow(-5, "Buzz")]
        [DataRow(-6, "Fizz")]
        [DataRow(-7, "Bar")]
        [DataRow(-14, "Bar")]
        [DataRow(-15, "FizzBuzz")]
        [DataRow(-16, "-16")]
        [DataRow(-45, "FIZZBUZZ")]
        [DataRow(-63, "BAR")]
        public void TestGenerateOutput(int target, string expectedOutput)
        {
            var fizzBuzzEngine = new FizzBuzzEngine();

            var output = fizzBuzzEngine.GenerateOutput(target);

            Assert.AreEqual(expectedOutput, output.Value);
            Assert.AreEqual(target, output.Key);
        }

    }
}