using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTestGUI
{
    class Record : IComparable<Record>
    {
        public int Correct;
        public int Speed;

        public Record()
        {
        }

        public Record(int i)
        {
            Correct = i / 10;
            Speed = i % 10;
        }

        public int CompareTo(Record other)
        {
            if (other == null)
            {
                return 1;
            }
            if (!IsEmpty && other.IsEmpty)
            {
                return 1;
            }
            if (!other.IsEmpty && IsEmpty)
            {
                return -1;
            }
            if (Speed == other.Speed)
            {
                return Correct - other.Correct;
            }
            else if (Speed < other.Speed)
            {
                if (Correct >= other.Correct)
                {
                    return 1;
                }
            }
            else
            {
                if (other.Correct >= Correct)
                {
                    return -1;
                }
            }
            return 0;
        }

        public static bool operator >(Record operand1, Record operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        public static bool operator <(Record operand1, Record operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        public static bool operator >=(Record operand1, Record operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        public static bool operator <=(Record operand1, Record operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        public string ToRecordString()
        {
            return $"{Correct} @ {Speed}";
        }

        public int ToInt()
        {
            return Correct * 10 + Speed;
        }

        public bool IsEmpty { get { return Correct == 0; } }
    }

    class Statistics : Record
    {
        private static Record current;
        public static Record CurrentRecord
        {
            get
            {
                if (current == null)
                {
                    using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MultiplicationTest"))
                    {
                        if (key != null)
                        {
                            current = new Record((int)key.GetValue("Record", 0));
                        }
                        else
                        {
                            current = new Record(0);
                        }
                    }
                }
                return current;
            }
            set
            {
                if (value != null)
                {
                    current = value;
                    using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MultiplicationTest"))
                    {
                        key.SetValue("Record", value.ToInt(), RegistryValueKind.DWord);
                    }
                }
            }
        }

        public int Error;
        public int Timeout;

        public string ToStatString()
        {
            return $"Correct: {Correct}\r\nErrors: {Error}\r\nTimeouts: {Timeout}\r\n\r\nAt speed: {Speed}";
        }
    }

}
