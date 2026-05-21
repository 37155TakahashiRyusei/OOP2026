
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_1(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.2 *****");
            Exercise2_2(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.3 *****");
            Exercise2_3(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.4 *****");
            Exercise2_4(cities);
            Console.WriteLine();
        }

        private static void Exercise2_1(List<string> cities) {
            //できたらGitのコメント「問題3.2.1完成」
            Console.Write("入力：");
            var text = Console.ReadLine();
            var find = cities.FindIndex(s => s.Equals(text));
            Console.WriteLine(find);
            //if (find <= cities.Count) {
            //    Console.WriteLine(find);
            //} else {
            //    Console.WriteLine("-1");
            //}
        }

        private static void Exercise2_2(List<string> cities) {
            //できたらGitのコメント「問題3.2.2完成」
            var cnt = cities.Count(s => s.Contains('o'));
            Console.WriteLine(cnt);
        }

        private static void Exercise2_3(List<string> cities) {
            //できたらGitのコメント「問題3.2.3完成」
            var input = cities.Where(s => s.Contains('o')).ToArray();
            foreach (var s in input) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> cities) {
            //できたらGitのコメント「問題3.2.4完成」
            //p135を参照する

            //if(string.StartsWith('B')) {

            //}
            //var cty = cities
            //    .Where(s => s.Contains('o')).ToArray()
            //    //.Select(s => )

        }
    }
}
