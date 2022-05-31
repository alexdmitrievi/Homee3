//Возведите число А в натуральную степень B используя цикл

int power(int a, int b)
{   
    int p = 1;
    for (int i = 0; i < b; i++){
        p = p * a;
    }
    return p;
}

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()?? "");
Console.WriteLine($"{power(a,b)}");
