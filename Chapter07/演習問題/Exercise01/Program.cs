
using System.Collections.Generic;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];


            Console.WriteLine("\n7.1.1");
            Exercise1(numbers);

            Console.WriteLine("\n7.1.2");
            Exercise2(numbers);

            Console.WriteLine("\n7.1.3");
            Exercise3(numbers);

            Console.WriteLine("\n7.1.4");
            Exercise4(numbers);

            Console.WriteLine("\n7.1.5");
            Exercise5(numbers);
        }

        private static void Exercise1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Exercise2(int[] numbers) {
            var last = numbers.TakeLast(2);
            foreach (var num in last) {
                Console.WriteLine(num);
            }
        }

        private static void Exercise3(int[] numbers) {
            //P173参照
            var num = numbers.Select(x => x.ToString("000")).ToArray();
            foreach (var item in num) {
                Console.WriteLine(item);
            }
        }
       
        private static void Exercise4(int[] numbers) {
            //P175参照
            var sort = numbers.Order()
            .Take(3);
            foreach (var item in sort) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise5(int[] numbers) {
            //P174参照
            var numDis = numbers.Distinct()
            .Count(x => x > 10);
            Console.WriteLine(numDis);
            //foreach (var item in numDis) {
            //    Console.WriteLine(item);
            //}
        }
    }
}
