// Подсчитать сумму цифр в числе

int number(int a){
    int sum = 0;
    while (a != 0)
    {
        sum = a % 10 + sum;
        a = a / 10;
    }
    return sum;
}

Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine($"{number(a)}");