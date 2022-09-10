using System;

namespace Skillbox {
    public class Task3 {
        public void start() {
            Console.WriteLine("Добрый день, введите целое число");
            bool isSimple = true;

            string insertedLine = Console.ReadLine();
            if (int.TryParse(insertedLine, out int result) && result > 0) {
                int i = 1;
                while (i != result - 1) {
                    i++;
                    if (result == 1) {
                        break;
                    }
                    if (result % i == 0) {
                        isSimple = false;
                        break;
                    }
                }
            } else {
                Console.WriteLine("Нужно ввести целое число");
            }

            Console.WriteLine(isSimple ? "Число простое" : "Число не простое");
        }
    }
}