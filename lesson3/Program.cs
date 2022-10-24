// Вид 1. Ничего не принимают, ничего не возвращают
void func1(){
    Console.WriteLine("Выполняется вид 1...");
}
// Вид 2. Принимают, ничего не возвращают
void func2(int a, string b){
    Console.WriteLine($"a = {a}; b = {b}");
}
// Вид 3. Ничего не принимают, возвращают
int func3(){
    return DateTime.Now.Year;
}
// Вид 4. Принимают, возвращают
int func4(int a){
    a*=a;
    return a;
}

// Точка входа
func1();
func2(32, "Hello");
Console.WriteLine($"Выполняется вид 3... {func3()}");
Console.WriteLine($"Выполняется вид 4... {func4(8)}");

// Цикл
for(int i=2;i<64;i*=2){
    Console.WriteLine($"i = {i}");
}
Console.WriteLine();
for(int i = 2; i<=10;i++){
    for(int j = 2; j<=10;j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

string s = "Ехал Грека через реку. Видит Грека - в реке рак. Сунул Грека руку в реку, рак за руку Греку ЦАП!";
Console.WriteLine(String.Empty+s[0]+s[1]+s[2]+s[3]);

Console.WriteLine("Сортировка массива перестановками:");

int[] iArray = {6,8,3,2,1,4,5,7};

foreach(int o in iArray){
    Console.Write($"{o} ");
}
Console.WriteLine();

int index;
for(int i = 0;i < iArray.Length; i++){
    index = i;
    for(int j = i; j < iArray.Length; j++){
        if (iArray[j]<iArray[index]){
            int temp = iArray[index];
            iArray[index] = iArray[j];
            iArray[j] = temp;
        }
    }
}

foreach(int o in iArray){
    Console.Write($"{o} ");
}