using System;

namespace Skillbox {
    public class Task1 {
        public void start() {
            Console.WriteLine("Введите целочисленное число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Число четное" : "Число нечетное");
        }
    }
}