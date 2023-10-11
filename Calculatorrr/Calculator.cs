using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorrr
{
    internal class Calculator
    {

        private int Costyl;
        public void Plus()
        {
            Costyl = 1;
            Console.Write("Введите первое число: ");
            string a = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string b = Console.ReadLine();
            CheckNumbers(a, b);

            var c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine ("Результат сложения: " + c);


        }

        public void Minus()
        {
            Costyl = 2;
            Console.Write("Введите первое число: ");
            string a = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string b = Console.ReadLine();
            CheckNumbers(a, b);

            var c = Convert.ToInt32(a) - Convert.ToInt32(b);
            Console.WriteLine("Результат разности: " + c);
        }

        public void Multiplication()
        {
            Costyl = 3;
            Console.Write("Введите первое число: ");
            string a = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string b = Console.ReadLine();
            CheckNumbers(a, b);

            var c = Convert.ToInt32(a) * Convert.ToInt32(b);
            Console.WriteLine("Результат умножения: "+ c);
        }

        public void Division()
        {
            Costyl = 4;
            Console.Write("Введите первое число: ");
            string a = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string b = Console.ReadLine();
            CheckNumbers(a, b);

            double c = Convert.ToDouble(a) / Convert.ToDouble(b);
            Console.WriteLine("Результат деления: "+ c);
        }

        private void CheckNumbers(string a, string b)
        {
            foreach (char i in a) 
            {
                if (!Char.IsNumber(i))
                {
                    Console.WriteLine("Что-то не так. Попробуйте снова...");
                    CostylMethod();

                }
            }

            foreach (char i in b)
            {
                if (!Char.IsNumber(i))
                {
                    Console.WriteLine("Что-то не так. Попробуйте снова...");
                    CostylMethod();
                }
            }
        }
        private void CostylMethod()
        {
            switch(Costyl)
            {
                case 1: Plus(); break;
                case 2: Minus(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
            }
        }
    }
}
