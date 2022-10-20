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
    Console.Write("\n");
    while(i - 1 < fdArray.Length) {
        Console.Write($"Введите цифру {i}: ");
        if (!int.TryParse(Console.ReadLine(), out fdArray[i - 1])){
            Console.WriteLine("Некорректный ввод! Ожидось число.");
            continue;
        }
        i++;
    }
    string ans = $"Число {fdArray[0]}{fdArray[1]}{fdArray[2]}{fdArray[3]}{fdArray[4]} ";
    if (!(fdArray[0] == fdArray[4] &&
        fdArray[1] == fdArray [3]))
        ans+="не ";
    Console.WriteLine(ans+"является палиндромом!");
}

switch(iTaskChoice){
    case 1:
        palindumber(); 
        break;
}
