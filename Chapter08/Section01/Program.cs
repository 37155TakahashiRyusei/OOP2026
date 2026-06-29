using System.Runtime.CompilerServices;
using static System.Formats.Asn1.AsnWriter;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");

            while (true) {
                //①都道府県の入力
                Console.Write("都道府県：");
                pref = Console.ReadLine();


                if (pref == null) { //無限ループを抜ける(Ctrl + 'Z')
                    break;
                }
                //②県庁所在地を入力
                Console.Write("県庁所在地：");
                prefCaptalLocation = Console.ReadLine();


                //③県庁所在地登録処理

                string prefOfficeDict = pref;
                prefOfficeDict = prefCaptalLocation;
                //foreach (var location in prefOfficeDict) {
                //    if (input.ContainsKey(location.)) {

                //    } else {
                //        input[location.Key] = location.
                //    }
                //}
            }
        }

        //メニュー表示
        private static int menuDisp(int numMenu) {
            Console.WriteLine("\n*** メニュー ***");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.WriteLine(">");
            return numMenu;

        }

        ////検索処理
        //private static void searchPrefCaptalLocation() {
        //    Console.Write("都道府県");
        //    string? searchPref = Console.ReadLine();
        //    switch (searchPref) {
        //        case 1:
        //            Console.WriteLine("の県庁所在地は"  + "市です。");
        //            break;

        //        case 2:
        //            Console.WriteLine("都道府県：");
        //            pref = Console.ReadLine();
        //            break;

        //        case 9:
        //            break;
        //    }
        //}
    }
}


