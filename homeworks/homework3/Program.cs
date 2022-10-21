#nullable disable // отключение проверки nullable (нет необходимости в данной работе)

// 17.10.22 | General part
string[] tasks = new string[4];
tasks[0] = "ДЗ 17.10.22";
tasks[1] = "1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.";
tasks[2] = "2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.";
tasks[3] = "3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.";
foreach(string s in tasks){
    Console.Write(s+"\n");
}

// main input cycle
int iTaskChoice = 0;
while(true){
    Console.Write("Выберите задачу (1-3): ");
    char chTaskChoice;

    chTaskChoice = Console.ReadKey().KeyChar;
    string ch = Convert.ToString(chTaskChoice);
    if (!int.TryParse(ch, out iTaskChoice)) {
        Console.Clear();
        Console.WriteLine("\nОшибка ввода, попробуйте ещё раз! ");
        continue;
    }
    if (iTaskChoice <= 0 || iTaskChoice > 3) {
        Console.Clear();
        Console.WriteLine("\nЗадание не найдено, Попробуйте ещё раз! ");
        continue;
    } else break;
}

// complex solution for the first task
void palindumber(){
    int[] fdArray = new int[5];
    int i = 1;
    while(i - 1 < fdArray.Length) {
        Console.Write($"\nВведите цифру {i}: ");
        char ch = Console.ReadKey().KeyChar;
        if (!int.TryParse(ch.ToString(), out fdArray[i - 1])){
            Console.WriteLine("Некорректный ввод! Ожидось число.");
            continue;
        }
        i++;
    }
    string ans = $"\nЧисло {fdArray[0]}{fdArray[1]}{fdArray[2]}{fdArray[3]}{fdArray[4]} ";
    if (!(fdArray[0] == fdArray[4] &&
        fdArray[1] == fdArray [3]))
        ans+="не ";
    Console.WriteLine(ans+"является палиндромом!");
}

// complex solution for the second task
void distanceFinder() {
    double[] tdArray = new double[6];
    int i = 1;
    Console.WriteLine("\nВведите последовательно координаты двух точек вида (a,b,c):");
    while(i - 1 < tdArray.Length) {
        Console.Write($"Введите число с плавающей запятой двойной точности {i}: ");
        if (!double.TryParse(Console.ReadLine(), out tdArray[i - 1])){
            Console.WriteLine("Некорректный ввод! Ожидось число с плавающей запятой двойной точности.");
            continue;
        }
        i++;
    }
    // 3D distance formula directly from wiki :)
    double distance = Math.Sqrt(Math.Pow(tdArray[3] - tdArray[0], 2) + 
                                Math.Pow(tdArray[4] - tdArray[1], 2) +
                                Math.Pow(tdArray[5] - tdArray[2], 2));
    Console.WriteLine($"Расстояние между точками ({tdArray[0]};{tdArray[1]};{tdArray[2]}) и ({tdArray[3]};{tdArray[4]};{tdArray[5]}): {Math.Round(distance, 2)}");
}

// complex solustion for the third task
void qubeTables() {
    int integer;
    Console.WriteLine("\n");
    while(true){
        Console.Write("Введите целое число: ");
        if (!int.TryParse(Console.ReadLine(),out integer)){
            Console.WriteLine("Некорректный ввод!");
            continue;
        }
        else break;
    }
    for (int i = 1; i <= integer;i++)
        Console.WriteLine($"{i}^3 = {i*i*i}"); // it must work faster than Math.Pow
}

// selector
switch(iTaskChoice){
    case 1:
        palindumber(); 
        break;
    case 2:
        distanceFinder();
        break;
    case 3:
        qubeTables();
        break;
    default:
        Console.WriteLine("Задание не найдено! Выход...");
        return;
}
