
using System;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        private static void Exercise1() {
            //if-else文を使用(4-9)参考にする
            Console.Write("入力：");
            var line = Console.ReadLine();
            if (!int.TryParse(line, out int num)) {
                Console.WriteLine("入力に誤りがあります");
                return; // ここで終了      
            }
                 
            if (num < 0) {
                Console.WriteLine(num);

            } else if (num >= 0 && num < 100) {
                Console.WriteLine(num * 2);

            } else if (num >= 100 && num < 500) {
                Console.WriteLine(num * 3);

            } else {
                Console.WriteLine(num);
            }
        }

        

        private static void Exercise2() {
            //switch文を使用(4-10)参考にする
            Console.Write("入力：");
            var line = Console.ReadLine();

            if (!int.TryParse(line, out int num)) {
                Console.WriteLine("入力に誤りがあります");
                return;
            }

            switch (num) {
                case < 0:
                    Console.WriteLine(num);
                    break;

                case >= 0 and < 100:
                    Console.WriteLine(num * 2);
                    break;

                case >= 100 and < 500:
                    Console.WriteLine(num * 3);
                    break;

                default:
                    Console.WriteLine(num);
                    break;
            }
        }
        

        private static void Exercise3() {
            //switch式を使用(4-11)参考にする
            Console.Write("入力：");
            var line = Console.ReadLine();

            if (!int.TryParse(line, out int num)) {
                Console.WriteLine("入力に誤りがあります");
                return;
            }

            var num2 = int.Parse(line);
            var text = num switch {
                < 0 => num.ToString(),
                >= 0 and < 100 => (num * 2).ToString(),
                >= 100 and < 500 => (num * 3).ToString(),
                _ => num.ToString()
            };
            Console.WriteLine(text);
        }
    }
}

