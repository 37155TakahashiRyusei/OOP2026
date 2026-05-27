
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            Console.WriteLine("---4.1.1---");

            //foreach文
            Console.WriteLine("foreachで出力");
            var lan1 = langs.FindAll(s => s.Contains('S'));
            foreach (var s in lan1) {
                Console.WriteLine(s);
            }

            //for文
            Console.WriteLine("\nforで出力");
            //var lan2 = langs.FindAll(s => s.Contains('S'));
            for (int i = 0; i < langs.Count; i++) {
                //var lan2 = langs.Count(s => s.Contains('S'));
                //Console.WriteLine(langs[i]);
                if (langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
            }

            //while文
            Console.WriteLine("\nwhileで出力");
            int counter = 0;
            while (counter < langs.Count) {
                if (langs[counter].Contains('S')) {
                    Console.WriteLine(langs[counter]);
                }
                counter++;
            }
        }


        private static void Exercise2(List<string> langs) {
            Console.WriteLine("\n ---4.1.2---");
            //LINQを使用する（where）
            var wh = langs.Where(s => s.Contains('S'));
            Console.WriteLine();
            //foreach (var item in wh) {
            //    Console.WriteLine(item);
            //}
        }

        private static void Exercise3(List<string> langs) {
            Console.WriteLine("\n ---4.1.3---");
        }
    }
}
