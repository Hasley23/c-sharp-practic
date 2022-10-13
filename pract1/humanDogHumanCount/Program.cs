// two humans one dog
// init block
int count = 0;
float distance = 10000f;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
float time = 0.0f;

// task output
Console.Write("Два человека идут навстречу друг другу. Собака перебегает от одного друга к другому.\n");
Console.Write("Сколько раз собака пробежит постоянно сокращающееся расстояние?\n\nРешение:\n");

// main loop
while(distance>10){
    // main branching
    if (friend == 1) {
        time = distance / (firstFriendSpeed + dogSpeed); // t = s / v
        friend = 2;
    }
    else {
        time = distance / (secondFriendSpeed + dogSpeed); // t = s / v
        friend = 1;
    }
    
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time; // s = v * t

    //debug
    Console.WriteLine("count = " + count + ", friend = " + friend + ", time = " + time + ", distance = " + distance);
    count++;
}
Console.WriteLine("Ответ: собака перебежит " + count + " раз.");
