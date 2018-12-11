using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTestGUI
{
    class Problem
    {
        public string Equation { get; set; }
        public string CorrectAnswer { get; set; }
    }

    class ProblemGenerator
    {
        private Random rnd = new Random();

        public Problem Next()
        {
            Problem result = new Problem();
            int a = rnd.Next(11) + 2;
            int b = rnd.Next(11) + 2;
            if (rnd.Next() % 2 == 0)
            {
                result.Equation = a + " * " + b + " = ";
                result.CorrectAnswer = "" + a * b;
            } else
            {
                int a1 = a * b;
                result.Equation = a1 + " / " + b + " = ";
                result.CorrectAnswer = "" + a;
            }
            return result;
        }
    }
}
