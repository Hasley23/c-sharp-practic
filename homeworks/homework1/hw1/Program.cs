/* 13.10.22
    Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Решение: В условии не сказано, какие именно число должна принимать программа, поэтому выбран тип float 
    (число с плавающей запятой одинарной точности).
*/

// Вывод запроса о вводе 2х чисел
Console.WriteLine("Последовательно введите 2 числа, разделяя их клавишей ввода:");

// Объявление строк
string? sA = null, sB = null;
// Объявление и начальная инициализация чисел fA, fB
float fA = 0.0f,fB = 0.0f;
// Цикл с проверкой корректности ввода
while(true){
    bool flag = true;
    // Чтение данных (допускаем null, так как литерал его допускает)
    sA = Console.ReadLine();
    if (!float.TryParse(sA, out fA))
        flag = false;
    sB = Console.ReadLine();
    if (!float.TryParse(sB, out fB))
        flag = false;
    if (!flag){
        Console.WriteLine("Ошибка ввода! Введите чила заново, разделяя их клавишей Enter: ");
        continue;
    }
    else break;
}

// Строка вывода
string sOutput;

// Условие задачи
if (fA>fB)
    sOutput = $"{fA} > {fB}";
else if (fA<fB)
    sOutput = $"{fA} < {fB}";
else
    sOutput = $"{fA} = {fB}";

// Вывод результата
Console.WriteLine(sOutput);

/*
    Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
/*
// Вывод запроса о вводе 3х чисел
Console.WriteLine("Последовательно введите 3 числа, разделяя их клавишей ввода:");

// Чтение данных (допускаем null, так как литерал его допускает)
string?[] sArray = new string?[3]; //= {Console.ReadLine(),Console.ReadLine(),Console.ReadLine()};

// Объявление массива чисел
float[] fArray = new float[3];

// Цикл с проверкой корректности ввода
int i = 0;
while(i<3){
    if (float.TryParse(Console.ReadLine(), out fArray[i])){
        i++;
    }
    else{
        Console.Write("Ошибка введите число повторно: ");
        continue;
    }
}

i = 1;
int indexMax = 0;
// Условие задачи (цикл поиска максимума)
while(i<3) {
    if (fArray[i] > fArray[indexMax])
        indexMax = i;
    i++;
}
// Вывод результата
Console.WriteLine($"Среди чисел {fArray[0]}; {fArray[1]}; {fArray[2]} наибольшим является {fArray[indexMax]}");
*/
/*
    Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
*/
/*
// Вывод запроса о вводе числа
Console.Write("Введите число: ");
// Объявление переменной
int iNum;
// Проверка корректности ввода
while(!int.TryParse(Console.ReadLine(), out iNum)) {
    Console.Write("Ошибка ввода! Введите повторно: ");
}
//Условие задачи
if (iNum % 2 == 0)
    Console.WriteLine($"Число {iNum} является чётным!");
else
    Console.WriteLine($"Число {iNum} не является чётным!");
*/
/*
    Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
/*
Console.Write("Введите число: ");
// Число (N)
int iNum;
// Проверка корректности ввода
while(!int.TryParse(Console.ReadLine(), out iNum)) {
    Console.Write("Ошибка ввода! Введите повторно: ");
}
//Условие задачи
for(int i = 1; i <= iNum; i++){
    if (i % 2 == 0) {
        if (i == iNum || i + 1 == iNum){
            Console.Write($"{i}.");
            return;
        }
        Console.Write($"{i}, ");
    }
}
*/