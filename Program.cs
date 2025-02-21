using System.ComponentModel.Design;
internal class Program
{
    private static void Main(string[] args)
    {
        void Nazvaniya()
        {
            string variable_string = "Это строка";
            int variable_int = 12;
            double variable_double = 24.5;
            bool variable_bool = true;
            char variable_char = 'a';

            Console.WriteLine("символьный " + variable_char);
            Console.WriteLine("логический " + variable_bool);
            Console.WriteLine("строчка " + variable_string);
            Console.WriteLine("целочисленный " + variable_int);
            Console.WriteLine("дробный " + variable_double);

            Console.WriteLine("Введите переменную: ");
            int xInt;
            xInt = int.Parse(Console.ReadLine());
            Console.WriteLine(xInt + " Ваше значение. ");

            Console.WriteLine("Введите переменную: ");
            string xString;
            xString = Console.ReadLine();
            Console.WriteLine(xString + " Ваше значение. ");

            Console.WriteLine("Введите переменную: ");
            int xBool;
            xBool = int.Parse(Console.ReadLine());
            Console.WriteLine(xBool + " Ваше значение. ");

            Console.WriteLine("Введите переменную: ");
            int xChar;
            xChar = int.Parse(Console.ReadLine());
            Console.WriteLine(xChar + " Ваше значение. ");

            Console.WriteLine("Введите переменную: ");
            int xDouble;
            xDouble = int.Parse(Console.ReadLine());
            Console.WriteLine(xDouble + " Ваше значение. ");
        }
        void Condition()
        {
            Console.WriteLine("Введите баланс");

            int amountofmoney = int.Parse(Console.ReadLine());

            if (amountofmoney >= 2000)
            {
                Console.WriteLine("я богат");
            }
            else if (amountofmoney > 0)
            {
                Console.WriteLine("есть но нету");
            }
            else if (amountofmoney < 0)
            {
                Console.WriteLine("опять кредиты");
            }
            else
            {
                Console.WriteLine("я бедный");
            }
        }
        void cycles()
        {
            int i = 0;
            // цикл с пред усл
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 0;
            // цикл с пост усл
            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 0);
            // цикл фор
            for (i = 0; i <= 52; i++)
            {
                Console.WriteLine(i);
            }
            int x, y = 1;
            for (i = 2; i <= 100; y++)
            {
                x = i * y;
                Console.WriteLine(x + "*" + i + "=" + i * x);
            }
            int[] numbers;
            int[] numbers_1 = new int[10];
            int[] numbers_2 = new int[5] { 1, 5, 23, -4, 10 };
            int[] numbers_3 = { 1, 24, 3, -8 };
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            foreach (int a in numbers_2)
            {
                Console.WriteLine(a);
            }
            for (int b = 0; b < numbers_2.Length; b++)
            {
                Console.WriteLine(b);
                Console.WriteLine(numbers_2[b]);
                Console.WriteLine("в ячейке" + b + "значение" + numbers_2[b]);
            }




        }

        void Methods();
        {
            long square(long a, long b)
            {
                long result = a * b;
                return result;
            }

            Console.WriteLine(square(10, 15));
            long square_result = square(12, 5) + 10;

            var max = int.MaxValue;
            var min = int.MinValue;
            Console.WriteLine(char.MinValue + "\n" + max);

            Console.WriteLine(square(216166516651, 6526566516161616));

            int getfactorial(int x)
            {
                int result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result = result * i;
                }
                return result;
            }


            int d = getfactorial(5);
            Console.WriteLine("dfghj");

            Console.WriteLine(getfactorial(5));
        }
    }
}
        
        