int cube(int n){
    return n*n*n;
}

Console.WriteLine("Ввидите число");
int n = int.Parse(Console.ReadLine()?? "");
int p = 0;
for (int i = 1; i <= n; i++){
    p = cube(i);
    Console.WriteLine($"{i} {p}");
}
