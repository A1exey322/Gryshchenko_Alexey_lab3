using System;

namespace part2
{
    /*Шкала прозорості:
       1 - Прозорий
       2 - Напівпрозорий
       3 - Просвічуючий
       4 - Напівпросвічуючий
       5 - Непрозорий
    */

    class Program
    {
        static void Main(string[] args)
        {
            Stone diamond = new ValuableStone("Діамант", 360, 0.41, 1, 10);
            Stone sapphire = new ValuableStone("Сапфір", 155, 0.32, 4, 10);
            Stone aquamarine = new ValuableStone("Аквамарин", 180, 0.7, 2, 10);
            Stone amber = new SemiValuableStone("Бурштин", 50, 3.3, 5, 10);
            Stone nephritis = new SemiValuableStone("Нефрит", 15, 4.6, 2, 10);
            Stone rubin = new ValuableStone("Рубін", 225, 0.47, 3, 10);


            Necklace neck = new Necklace();
            neck.necklace = new Stone[] { diamond, amber, nephritis, rubin };

            Console.WriteLine("Намисто:");
            Console.WriteLine(new string('-', 40));
            neck.ShowNecklace();
            Console.WriteLine("Загальна вартість намиста:");
            Console.WriteLine(neck.CountPrice());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Загальна вага намиста:");
            Console.WriteLine($"{neck.CountWeight()} карат");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Сортування намиста по цінності каменя:");
            neck.Sort();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Сортування намиста по прозорості каменя:");
            Console.WriteLine("Min:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max:");
            int max = int.Parse(Console.ReadLine());
            neck.VisSort(min,max);

        }
    }
}
