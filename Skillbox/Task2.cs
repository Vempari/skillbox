using System;

namespace Skillbox {
    public class Task2 {
        public void start() {
            Console.WriteLine("Добрый день, сколько у вас карт?");
            int count = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < count; i++) {
                Console.WriteLine($"{i + 1} карта:");
                string insertedLine = Console.ReadLine();
                if (int.TryParse(insertedLine, out int result)) {
                    switch (result) {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            total += result;
                            break;
                        default:
                            Console.WriteLine("Можно использовать цифры с 1 до 9");
                            i--;
                            break;
                    }
                } else {
                    switch (insertedLine) {
                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            total += 10;
                            break;
                        default:
                            Console.WriteLine("Можно использовать буквы J,Q,K,T");
                            i--;
                            break;
                    }
                }
                
                Console.WriteLine($"Осталось {count - i - 1} карт");
            }
            Console.WriteLine($"всего {total} очков");
        }
    }
}