using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Core
{
    internal interface IOutputRule
    {
        /// <summary>
        /// Generates a poutput
        /// </summary>
        /// <param name="number">Number to process</param>
        /// <param name="number">Current Value</param>
        /// <param name="output">Corresponding valueValue</param>
        /// <returns>True if more rules should be processed.</returns>
        bool GenerateOutput(int number, string currentResult, out string result);
    }
}
