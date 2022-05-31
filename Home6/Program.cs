//Показать кубы чисел, заканчивающихся на четную цифру

int cube(int a){
    return a*a*a;
}

int ifeven(int b)
{   
    if (b % 2 == 0){
        return 0;
    }
    else {
        return 1;
    } 
}
// return b % 2 (строка 9-14)

for (int i = 0; i < 100; i++){
    if (ifeven(i) == 0){
       Console.WriteLine($"{cube(i)}");
    }
}

