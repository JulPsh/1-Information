using System;

namespace Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя:");
            string name = Console.ReadLine();
            Console.Write("Ваш возраст:");
            string age = Console.ReadLine();
            int a = Convert.ToInt32(age); 
            Console.Write("Где Вы живете:");
            string live = Console.ReadLine();
            Console.WriteLine($"Ну что ж {name}, мы получили все данные, которые нужны были.Теперь готовьтесь! За Вами выехали!");
        }
    }
}
