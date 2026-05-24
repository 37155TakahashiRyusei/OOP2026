namespace Section01 {
    internal class Program {

        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };
            //6文字以上
            var name = cities.Exists(s => 6 <= s.Length);
            Console.WriteLine(name);
            var names = cities.FindAll(s => 6 <= s.Length);
            foreach (var s in names) {
                Console.WriteLine(s);
            }

            //'o'を含む
            var exists1 = cities.Exists(s => s.Contains('o'));
            Console.WriteLine(exists1);
            
            //最後にnが付く
            var exist = cities.Exists(s => s.EndsWith('n'));
            Console.WriteLine(exist);
            
            //1行で出力
            var exists = cities.Exists(s => 6 <= s.Length && s.Contains('o') && s.EndsWith('n'));
            Console.WriteLine(exists);
            //var index = cities.Find(s => 0 == 'o');
            //Console.WriteLine(index);

            //(List限定)短い方↓
            //var exists = cities.FindAll(s => s[0] == 'B');
            //exists.ForEach(s => Console.WriteLine(s));
        }
    }
}
