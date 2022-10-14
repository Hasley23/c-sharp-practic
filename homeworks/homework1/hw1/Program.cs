/* 13.10.22
    Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Решение: В условии не сказано, какие именно число должна принимать программа, поэтому выбран тип float 
    (число с плавающей запятой одинарной точности).
*/
// Вывод запроса о вводе 2х чисел
Console.WriteLine("Последовательно введите 2 числа, разделяя их клавишей ввода:");

// Чтение данных (допускаем null, так как литерал его допускает)
string? sA = Console.ReadLine();
string? sB = Console.ReadLine();

// Объявление и начальная инициализация чисел fA, fB
float fA = 0.0f,fB = 0.0f;

// Цикл с проверкой корректности ввода
while(true)
    if (float.TryParse(sA, out fA) && float.TryParse(sB, out fB))
        break;
    else {
        Console.WriteLine("Ошибка ввода!");
        return;
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