using System;
using System.Diagnostics;

namespace Skillbox {
    public class Task5 {
        public void start() {
            while (1 == 1) {
                Console.WriteLine("Добрый день, введите конечно число (программа создаст случайно от 0 до вашего числа)");
                
                if (int.TryParse(Console.ReadLine(), out int maxLength) && maxLength > 0) {
                    Random rnd = new Random();
                    var secretInt = rnd.Next(0, maxLength);
                    Console.WriteLine("Угадайте число:");
                    if (int.TryParse(Console.ReadLine(), out int guess) && maxLength > 0) {
                        if (guess == secretInt) {
                            Console.WriteLine($"Вы угадали - правильно число {secretInt}");
                        } else {
                            Console.WriteLine($"Вы не угадали - правильно число {secretInt}");
                        }
                        Console.WriteLine("Чтобы отменить введите N - чтобы продолжить - что угодно");
                        if (Console.ReadLine() == "N") {
                            break;
                        }
                        
                    } else {
                        Console.WriteLine("Нужно ввести целое число больше 0");
                    }
                } else {
                    Console.WriteLine("Нужно ввести целое число больше 0");
                }
            }
        }
    }
}