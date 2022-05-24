using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3
{
    class Piano
    {
        Button[] notes = new Button[7]
        {
            new Button("Do"),
            new Button("Re"),
            new Button("Mi"),
            new Button("Fa"),
            new Button("Sol"),
            new Button("La"),
            new Button("Si")
        };

        Pedal left = new Pedal("Ліва педаль");
        Pedal right = new Pedal("Права педаль");


        public string[] buttons = new string[7];
        public void Tune()
        {
            
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = notes[i].ToString();
                Console.WriteLine($"Клавіша {i+1} = {notes[i]}");
            }
            
            
            Console.WriteLine("Піаніно налаштовано!");
        }

        public void PressButton()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 6);
           
            Console.WriteLine($"Натискаємо ноту {buttons[number]}!");
        }
        public void PressPedal()
        {
            Random rnd1 = new Random();
            int number1 = rnd1.Next(1, 10);
             if(number1 < 5)
                Console.WriteLine("Натискається {0}!", left);
            else Console.WriteLine("Натискається {0}!", right);
        }

        public void Play()
        {
            Random rnd = new Random();
            int counter = rnd.Next(7, 10);
            
            for (int i = 0; i < counter; i++)
            {
                int counter2 = rnd.Next(0, 6);
                Console.Write($"{buttons[counter2]}   ");
            }
            Console.WriteLine();
        }
    }
}
