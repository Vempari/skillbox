using System;

namespace Skillbox {
    public class Task4 {
        public void start() {
            Console.WriteLine("Добрый день, введите длину последовотельности");
            int? result = null;
            if (int.TryParse(Console.ReadLine(), out int count)) {
                for (int i = 0; i < count; i++) {
                    Console.WriteLine($"Введите {i + 1} число");
                    if (int.TryParse(Console.ReadLine(), out int number)) {
                        if (number < result) {
                            result = number;
                        }
                    } else {
                        Console.WriteLine("Нужно ввести целое число");
                    }
                    if (i == 0) {
                        result = number;
                    }
                }
            } else {
                Console.WriteLine("Нужно ввести целое число");
            }
            Console.WriteLine($"Самое мелкое число: {result}");
        }
    }
}