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
            Console.Write("Введите число (минимум 3 знака): ");
            sInput = Console.ReadLine();
            if (!int.TryParse(sInput,out iInput)) {
                Console.WriteLine("Ошибка ввода!");
                continue;
            }
            int iTemp = taskTwo(iInput);
            if (iTemp == -3) {
                Console.WriteLine($"У числа {sInput} нет третьей цифры!");
                return;
            }
            Console.WriteLine($"Третья цифра числа {iInput}: {iTemp}");
            break;
        }
        break;
    case 3:
        Console.WriteLine("\nЗадание 3.");
        char ch;
        // цикл ввода для задания 3
        while(true){
            Console.WriteLine("Введите день недели (цифру, обозначающую его): ");
            ch = Console.ReadKey().KeyChar;
            string res = taskThree(ch);
            if (res == "#") {
                Console.WriteLine("\nОшибка ввода!");
                continue;
            }
            Console.WriteLine("\n" + res);
            break;
        }
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
    int cut = 0;
    int cutted = 0;
    if (iInput.ToString().Length < 3) {
        return -3;
    } else if (sInput.Length > 2) {
        cut = iInput.ToString().Length - 3;
        cutted = iInput;
        while(cut>0){
            cutted/=10;
            cut--;
        }
    }
    return cutted % 10;
}

/*
    Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
string taskThree(char ch){
    switch(ch){
        case '1':
            return "Понедельник, не выходной";
        case '2':
            return "Вторник, не выходной";
        case '3':
            return "Среда, не выходной";
        case '4':
            return "Четверг, не выходной";
        case '5':
            return "Пятница, не выходной";
        case '6':
            return "Суббота, выходной";
        case '7':
            return "Воскресенье, выходной";
        default:
            return "#";
    }
}