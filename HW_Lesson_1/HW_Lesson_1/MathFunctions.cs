using System;

namespace HW_Lesson_1
{
    public sealed class MathFunctions
    {

        private int _inputValue;
        private int _factorial = 1;
        private int _sum = 0;
        private int _evenNumber;


        public MathFunctions(int value)
        {
            _inputValue = value;
        }

        public int Factorial()
        {
            for(int i = 1; i <= _inputValue; i++)
            {
                _factorial *= i;
            }

            return _factorial;
        }

        public int SumValues()
        {
            for (int i = 1; i <= _inputValue; i++)
            {
                _sum += i;
            }

            return _sum;
        }

        public int EvenNumber()
        {
            for (int i = 1; i <= _inputValue; i++)
            {
                if (i % 2 == 0)
                {
                    _evenNumber = i;
                }
            }

            return _evenNumber;
        }

    }
}
