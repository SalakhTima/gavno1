using System.Data.Common;

namespace Tamagotchi
{
    class Programm
    {
        static void Main()
        {
            // создали кошку
            Cat cat = new Cat { name = "Pushok", hunger = 0 };
            Fruit pivko = new Fruit { type = "баутика", health = 5 };
            DoMeal(cat, pivko); // покормили кошку пивком

            
            while (cat.IsAlive())
            {
                int code = int.Parse(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        Console.WriteLine("Вызов метода игры.");
                        cat.Play();
                        break;

                    case 2:
                        Console.WriteLine("Вызов метода бега.");
                        cat.Run();
                        break;

                    case 3:
                        Console.WriteLine("Вызов метода просмотра голода.");
                        break;

                }
            }
        }
        static void DoMeal(Cat c, Fruit f)
        {
            c.Eat(f); // кошка {имя кошки} съела фрукт
        }
    }
}