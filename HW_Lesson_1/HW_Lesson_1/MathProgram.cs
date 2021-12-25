using System;

namespace HW_Lesson_1
{
    class MathProgram
    {

        static void Main(string[] args)
        {

            #region Old Code
            //Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            //Console.WriteLine("пажалуйста введите число. ");

            //String S = Console.ReadLine();

            //if (S == "q")
            //{
            //    return;
            //}
            //int M = Int32.Parse(S);
            //int c1 = 1; int c2 = 0;
            //int c3 = 0;
            //for (int i = 1; i <= M; i++)
            //{
            //    c1 = c1 * i;
            //    c2 = c2 + i;
            //    if (i % 2 == 0)
            //    {
            //        c3 = i;
            //    }
            //}
            //Console.WriteLine("Факториал равет " + c1); Console.WriteLine("Сума от 1 до N равна " + c2);

            //Console.WriteLine("максимальное четное число меньше N равно" + c3);
            //Console.ReadLine();
            #endregion


            #region Refactored Code

            Console.WriteLine("Здравствуйте вас приветствует математическая программа!");
            Console.Write("Пожалуйста введите число N: ");

            string input = Console.ReadLine();

            if (input == "q" || input == "quit")
            {
                return;
            }

            int inputValue;
            bool inputReuslt = int.TryParse(input, out inputValue);

            if (inputReuslt)
            {
                Console.WriteLine($"Вы ввели число {inputValue}.");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число.");
                Console.ReadLine();
                return;
            }



            MathFunctions functions = new MathFunctions(inputValue);

            int factorial = functions.Factorial();
            int sum = functions.SumValues();
            int evenNumber = functions.EvenNumber();

            Console.WriteLine($"Факториал числа {inputValue} равен {factorial}."); 
            Console.WriteLine($"Сума чисел от 1 до {inputValue} равна {sum}.");

            Console.WriteLine($"Максимальное четное число меньше {inputValue} равно {evenNumber}");
            Console.ReadLine();





            #endregion

        }
    }
}
