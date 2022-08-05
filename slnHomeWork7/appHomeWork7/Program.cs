namespace appHomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsOintment Oinment1 = new clsOintment("Мазь Навазин 70", 8.50, 0, 0, 75);
            Oinment1.AddToListOfDeseases("Растяжение; Ушибы");

            clsSyrup Syrup1 = new clsSyrup("ABC", 17.25, 1, 0, "Лимон");
            Syrup1.AddToListOfDeseases("");

            clsTablet Tablet1 = new clsTablet("Ношпа", 31.23, 2, 1, "светло-желтый");
            Tablet1.AddToListOfDeseases("Тяжесть в желудке");

            Oinment1.Print();
            Syrup1.Print();
            Tablet1.Print();

            Console.WriteLine("");

            var MedList = new List<clsMedicamentBase>
            {
                Oinment1,
                Syrup1,
                Tablet1
            };

            foreach(var Item in MedList)
            {
                Item.Print();
            }
        }
    }
}