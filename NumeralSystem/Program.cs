
Console.WriteLine("1. 10 to X");
Console.WriteLine("2. X to 10");

var type = Console.ReadLine();

if (type == "1")
{
    Console.WriteLine("Pls enter num: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Pls enter num sys: ");
    int numSys = int.Parse(Console.ReadLine());
    var answer = Convert.ToString(number, numSys);
    Console.WriteLine(answer);
}
else if (type == "2")
{
    Console.WriteLine("Pls enter num: ");
    string number = Console.ReadLine();
    Console.WriteLine("Pls enter num sys");
    int numSys = int.Parse(Console.ReadLine());
    int answer = Convert.ToInt32(number, numSys);
    Console.WriteLine(answer);
}

else
{
    Console.WriteLine("Wrong number");
}
