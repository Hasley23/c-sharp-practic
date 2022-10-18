#nullable disable // отключение проверки nullable (нет необходимости в данной работе)

// 17.10.22 | Общая часть
// целочисленная переменная выбора задачи
int iTaskChoice = 0;
// цикл выбора задачи
while(true){
    Console.WriteLine("ДЗ | 17.10.22\nВыберите задачу (1-3): ");
    char chTaskChoice;

    chTaskChoice = Console.ReadKey().KeyChar;
    // строка
    string ch = Convert.ToString(chTaskChoice);
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


// Переменная для ввода
string sInput;
int iInput;
switch (iTaskChoice){
    case 1:
        Console.Write("\nЗадание 1. ");
        // цикл ввода для задачи 1
        while(true) {
            Console.Write("Введите трехзначное число: ");
            sInput = Console.ReadLine();
            if (sInput.Length != 3 || !int.TryParse(sInput,out iInput)){
                Console.WriteLine("Ошибка ввода! Введите повторно.");
                continue;
            }
            break;
        }
        Console.WriteLine($"Вторая цифра числа {iInput}: {taskOne(iInput)}");
        break;
    case 2:
        Console.WriteLine("\nЗадание 2.");
        // цикл ввода для задачи 2
        while(true) {
            
            break;
        }
        break;
    case 3:
        Console.WriteLine("\nЗадание 3.");
        //res = taskThree(1);
        break;
    default:
        Console.WriteLine("\nНеверный номер задания!\n");
        break;
}

/* 
    Задача 1. Напишите программу, которая принимает на вход трёхзначное число (three-digit number) 
    и на выходе показывает вторую цифру этого числа.
*/
int taskOne(int TDnum){
    TDnum %= 100; // обрезаем левый разряд
    TDnum /= 10; // обрезаем правый разряд
    return TDnum;
}

/*
    Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
int taskTwo(int TDnum){
    string sNum = TDnum.ToString();
    if (sNum.Length < 3)
        return -1;
    else {
        return TDnum % 10;
    }
}

/*
    Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
int taskThree(int TDnum){
    return 0;
}