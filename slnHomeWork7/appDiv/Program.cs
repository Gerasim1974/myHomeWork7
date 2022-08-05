namespace appDiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чеслитель как целое число:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите знаменатель как целое число:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество знаков после запятой:");
            byte n3 = Byte.Parse(Console.ReadLine());

            clsMath Fraction = new clsMath();

            Console.WriteLine($"В десятичном представлении дробь = {clsMath.FractionResult(n1, n2, n3)}");

            clsMath.ReduceFraction(n1, n2);

        }
    }
}