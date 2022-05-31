//Найти сумму чисел от 1 до А


int sum(int a)
{
    int s = 0;
    for (int i = 1; i <= a; i++){
        s = s + i;
    }
    return s;
} 
 
Console.WriteLine("Ввидите число");
int n = int.Parse(Console.ReadLine()?? "");
Console.WriteLine($"{sum(n)}");