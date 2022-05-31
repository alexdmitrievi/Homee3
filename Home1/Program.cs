//Показать таблицу квадратов чисел от 1 до N

int sqr(int n){
    return n*n;
}

Console.WriteLine("Ввидите число");
int n = int.Parse(Console.ReadLine()?? "");
int p = 0;
for (int i = 1; i <= n; i++){
    p = sqr(i);
    Console.WriteLine($"{i} {p}");
}
