using Calculatorrr;

internal class Program
{
    private static void Main(string[] args)
    {


        Menu();


        static void Menu()
        {
            Calculator calc = new Calculator();
            int a = 0;
            while (true)
            {
                Console.WriteLine("Выберите действие: \n 1. Сложение \n 2. Вычитание \n 3. Умножение \n 4. Деление \n 5. Выход \n");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Для выбора операции нужно воодить только цифру от 1 до 5!");
                    Menu();
                }
                if (a == 5) break;
                else
                {
                    switch (a)
                    {
                        case 1: calc.Plus(); break;
                        case 2: calc.Minus(); break;
                        case 3: calc.Multiplication(); break;
                        case 4: calc.Division(); break;
                        default: Console.WriteLine("Неверная операция! Попробуйте снова..."); break;
                    }
                }

            }
        }
    }
}