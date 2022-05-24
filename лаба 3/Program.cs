using System;

namespace лаба_3
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Piano piano = new Piano();

            Console.WriteLine("Налаштуємо піаніно:");
            piano.Tune();

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Натиснемо клавішу:");
            Console.WriteLine(new string('-', 30));
            piano.PressButton();

            piano.PressPedal();
            piano.PressButton();
            piano.PressPedal();

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Зіграємо мелодію:");
            piano.Play();


            Console.WriteLine(new string('-', 30));

        }
    }
}
