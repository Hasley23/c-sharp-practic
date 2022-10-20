void quarterFinder(int iQuarter) {
    switch(iQuarter) {
        case 1:
            Console.WriteLine("x>0;y>0");
            break;
        case 2:
            Console.WriteLine("x<0;y>0");
            break;
        case 3:
            Console.WriteLine("x<0;y<0");
            break;
        case 4:
            Console.WriteLine("x>0;y<0");
            break;
        default:
            Console.WriteLine("wrong quarter");
        break;
    }
}

Console.WriteLine("quarter pls");
int n = Convert.ToInt32(Console.ReadLine());
quarterFinder(n);