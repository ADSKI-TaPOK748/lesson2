using System.ComponentModel.Design;

void Nazvanie()
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
while(true)
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

