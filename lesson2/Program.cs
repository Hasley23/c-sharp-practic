Random rand = new Random();
/*Console.WriteLine("Занятие 2. (15.10.22)\n Поиск максимума без функций, циклов и массивов");

// Если бы массивов и циклов не было
int a1 = rand.Next(100);
int b1 = rand.Next(100);
int c1 = rand.Next(100);
int a2 = rand.Next(100);
int b2 = rand.Next(100);
int c2 = rand.Next(100);
int a3 = rand.Next(100);
int b3 = rand.Next(100);
int c3 = rand.Next(100);

Console.WriteLine($"{a1}, {b1}, {c1},  {a2}, {b2}, {c2}, {a3}, {b3}, {c3}");

int max = a1;
if (b1>max) max = b1;
if (c1>max) max = c1;
if (a2>max) max = a2;
if (b2>max) max = b2;
if (c2>max) max = c2;
if (a3>max) max = a3;
if (b3>max) max = b3;
if (c3>max) max = c3;
// Вывод максимума способом 1
Console.WriteLine($"max = {max}");

// Создадим функцию
int Max(int arg1, int arg2, int arg3) {
    int res = arg1;
    if (arg2>res)
        res = arg2;
    else if (arg3>res)
        res = arg3;
    return res;
}

// Воспользуемся функцией
max = Max(Max(a1, b1, c1),
          Max(a2, b2, c2),
          Max(a3, b3, c3));
// Вывод максимума способом 2
Console.WriteLine("Поиск максимума с функцией, но без массива:");
Console.WriteLine($"max = {max}");
*/
// Воспользуемся массивом
Console.WriteLine("Поиск максимума с функцией и массивом:");
int[] array = new int[9];
int i = 0;
while(i < array.Length){
    array[i] = rand.Next(100);
    Console.Write($"{array[i]} "); 
    i++;
}
int searchMax(int[] a) {
    /*
    if (array[i] > maximum)
    {
       maximum  = array[i];
       index = i;
    }
    */
    int index = 0;
    for(int i = 0; i < a.Length;i++){
        if(a[i]>a[index])
            index = i;
        i++;
    }
    return a[index];
}
// Вывод максимума способом 3
void printMax(int max) {
    Console.WriteLine($"\nmax = {max}");
}
printMax(searchMax(array));