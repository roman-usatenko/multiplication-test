using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTestGUI
{
    class Statistics
    {
        public int Correct;
        public int Error;
        public int Timeout;
        public int Speed;

        public override string ToString()
        {
            return $"Correct: {Correct}\r\nErrors: {Error}\r\nTimeouts: {Timeout}\r\n\r\nAt speed: {Speed}";
        }
    }
}
