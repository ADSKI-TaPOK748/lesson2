using System.ComponentModel.Design;
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
    xInt = Int32.Parse(Console.ReadLine());
    Console.WriteLine(xInt + " Ваше значение. ");

    Console.WriteLine("Введите переменную: ");
    string xString;
    xString = Console.ReadLine();
    Console.WriteLine(xString + " Ваше значение. ");

    Console.WriteLine("Введите переменную: ");
    int xBool;
    xBool = Int32.Parse(Console.ReadLine());
    Console.WriteLine(xBool + " Ваше значение. ");

    Console.WriteLine("Введите переменную: ");
    int xChar;
    xChar = Int32.Parse(Console.ReadLine());
    Console.WriteLine(xChar + " Ваше значение. ");

    Console.WriteLine("Введите переменную: ");
    int xDouble;
    xDouble = Int32.Parse(Console.ReadLine());
    Console.WriteLine(xDouble + " Ваше значение. ");
}
void Condition()
{
    Console.WriteLine("Введите баланс");

    int amountofmoney = Int32.Parse(Console.ReadLine());

    if (amountofmoney >= 2000)
    {
        Console.WriteLine("я богат");
    }
    else if (amountofmoney > 0)
    {
        Console.WriteLine("есть но нету");
    }
    else if (amountofmoney < 0) ;
    {
        Console.WriteLine("опять кредиты");
    }
else
    {
        Console.WriteLine("я бедный");
    }
}

int i = 0;
// цикл с пред усл
while(i < 5)
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
} while (i<0);
// цикл фор
for(i = 0;i<=52;i++)
{
    Console.WriteLine(i);
}
int x, y=1;
for(i=2; i<=100;y++)
{
    x = i * y;
    Console.WriteLine(x+"*"+i+"="+i*x);
}
int[] numbers;
int[] numbers_1 = new int[10];
int[] numbers_2 = new int[5] { 1, 5, 23, -4, 10 };
int[] numbers_3 = { 1, 24, 3, -8 };
int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


foreach (int a in numbers_2);
{
    Console.WriteLine(a );
}
for(int b=0; b<numbers_2.Length;b++)
{
    Console.WriteLine(b);
    Console.WriteLine(numbers_2[b]);
    Console.WriteLine("в ячейке" + b + "значение" + numbers_2[b]);
}