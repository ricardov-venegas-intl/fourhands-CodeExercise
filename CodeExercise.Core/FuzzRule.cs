using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Core
{
    internal class FizzRule : IOutputRule
    {
        public bool GenerateOutput(int number, string currentResult,  out string result)
        {
            if (number % 3 == 0)
            {
                result = currentResult+ "Fizz";
                return true;
            };
            result = currentResult;
            return true;
        }
    }
}
