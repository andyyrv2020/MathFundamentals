namespace NumeralSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter system: ");
            int numberSystem = int.Parse(Console.ReadLine());
            var answer = Convert.ToString(num, numberSystem);
            Console.WriteLine(answer);
        }
    }
}
