using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var array = line.Split(';', '=');
            //Console.WriteLine(array);
            //var array2 = line.Split('='); 

            var sb = new StringBuilder();
            sb.Append(array);

            for (int i = 0; i < line.Length; i++) {
                //array[i].Split('=');
                Console.WriteLine(array[i]);

            }

            //int i = 0;
            //foreach (var word in array) {
            //    sb.Append(word + ":");
            //    // Console.Write(array[i]);
            //    Console.WriteLine(word);
            //    //i++;
            //}
            //Console.WriteLine(sb);
            //Console.WriteLine();
            //Console.WriteLine(line + ":");




        }
       public static string ToJapanese(string key) {
            return key switch {
                "Novelist" => "作家",
                "BestWork" => "代表作",
                "Born" => "誕生年",
                _ => "引数keyは、正しい値ではありません"
            };
            //古い書き方
            //switch (key) {
            //    case "Novelist":　
            //        return "作家";
            //    case "BestWork":
            //        return "代表作";
            //    case "Born":
            //        return "誕生年";
            //    default:
            //        return "引数keyは、正しい値ではありません";
            //}
        }
    }
}
