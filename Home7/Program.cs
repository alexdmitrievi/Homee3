//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++){
    array[i] = rnd.Next(0,2);
    Console.WriteLine($"{array[i]}");
}
