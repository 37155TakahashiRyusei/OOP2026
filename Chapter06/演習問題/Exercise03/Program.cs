
namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {

            var count = text.Count(c => c == ' ');
            Console.WriteLine(count);
            Console.WriteLine();//改行用
        }

        private static void Exercise2(string text) {
            //p142参考
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
            Console.WriteLine();//改行用
        }

        private static void Exercise3(string text) {



            Console.WriteLine();//改行用
        }

        private static void Exercise4(string text) {
            var word = text.Split(' ');
            Console.WriteLine(word.Length);
            Console.WriteLine();//改行用
        }

        private static void Exercise5(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in words) {
                Console.WriteLine(item);
            }

            //text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);即時実行しても良い時の書き方

            //for (int i = 0; i < text.Length; i++) {
            //    if (words[i] <= 4) {
            //        Console.WriteLine(words);
            //    }
            //}
            Console.WriteLine();//改行用
        }

        //アルファベットの数をカウントして表示する
        private static void Exercise6(string text) {
            var str = text.ToLower().Replace(" ", "");

            //辞書（ディクショナリ）を使った集計
            //var alphDicCount = Enumerable.Range('a', 26).
            //    ToDictionary(num => ((char)num).ToString(), num => 0 );

            var dict = new SortedDictionary<char, int>();
            foreach (var c in str) {
                if (dict.ContainsKey(c))
                    //登録されている場合
                    dict[c]++; 
                else
                    //未登録の場合
                    dict[c] = 1; 
            }
            foreach (var word in dict) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }
           







            //'a'から順にカウントして集計
        }
    }
}
