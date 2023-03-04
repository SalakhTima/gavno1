using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public struct Fruit
    { // структура Фрукт
        public string type;
        public int health;
    }
    public class Cat
    {
        public string name;
        public int hunger;

        public void Eat(Fruit f) // кошка может есть фрукт
        {
            hunger -= f.health; // уменьшаем значение поля hunger на значение health фрукта
            Console.WriteLine($"Cat eats {f.type}. Hunger: {hunger}");
        }
        public void CheckHunger()
        {
            Console.WriteLine($"Hunger: {hunger}");
        }

        public void Play()
        {
            Console.WriteLine($"{name} играет и прыгает!");
            hunger += 5;
            if (hunger > 0)
            {
                Console.WriteLine($"{name} погиб от голода!");
            }
            else
            {
                int randomWaitTime = new Random().Next(1, 15);
                Console.WriteLine($"{name} устала и отдыхает {randomWaitTime} минут...");
                CheckHunger();
            }
        }

        public void Run()
        {
            Console.WriteLine($"{name} бегает!");
            hunger += 1;
            if (hunger > 0)
            {
                Console.WriteLine($"{name} погиб от голода!");
            }
            else
            {
                int randomWaitTime = new Random().Next(1, 15);
                Console.WriteLine($"{name} устала и отдыхает {randomWaitTime} минут...");
                CheckHunger();
            }
        }
        public bool IsAlive()
        {
            bool flag = true;
            if (hunger > 0)
            {
                flag = false;
            }
            return flag;
        }

    }
}
