// 17.10.22 | Общая часть

// целочисленная переменная выбора задачи
int iTaskChoice = 0;
// цикл выбора задачи
while(true){
    Console.WriteLine("ДЗ | 17.10.22\nВыберите задачу (1-3): ");
    char? chTaskChoice;

    chTaskChoice = Console.ReadKey().KeyChar;
    // строка
    string? ch = Convert.ToString(chTaskChoice);
    if (!int.TryParse(ch, out iTaskChoice)) {
        Console.Clear();
        Console.WriteLine("\nОшибка ввода, попробуйте ещё раз! ");
        continue;
    }

    // отсеивание ошибочных значений
    if (iTaskChoice <= 0 || iTaskChoice > 3) {
        Console.Clear();
        Console.WriteLine("\nЗадание не найдено, Попробуйте ещё раз! ");
        continue;
    } else break;
}


int num = -1;
int res;
switch (iTaskChoice){
    case 1:
        Console.WriteLine("\nЗадание 1.");
        // ввод (написать)
        // ...
        res = taskOne(num);
        if(res>-1 && res<10)
            Console.WriteLine($"Вторая цифра числа {num} -> {res}");
        else {
            Console.WriteLine("Ошибка выполнения..");
            return;
        }
        break;
    case 2:
        Console.WriteLine("\nЗадание 2.");
        res = taskOne(num);
        res = taskTwo(1);
        break;
    case 3:
        Console.WriteLine("\nЗадание 3.");
        res = taskOne(num);
        res = taskThree(1);
        break;
    default:
        Console.WriteLine("\nНеверный номер задания!\n");
        break;
}

/* 
    Задача 1. Напишите программу, которая принимает на вход трёхзначное число (three-digit number) и на выходе показывает вторую цифру этого числа.
*/
int taskOne(int TDnum){
    return 0;
}

/*
    Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
int taskTwo(int TDnum){
    return 0;
}

/*
    Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
int taskThree(int TDnum){
    return 0;
}