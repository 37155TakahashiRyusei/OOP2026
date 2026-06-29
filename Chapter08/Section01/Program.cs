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

                //既に都道府県が登録されているか？
                if(prefOfficeDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if(Console.ReadLine() == "N") {
                        continue;
                    }
                }

                //③県庁所在地登録処理

                prefOfficeDict[pref] = prefCaptalLocation;

                Console.WriteLine();//改行
            }

            Boolean endFlag = false; //終了フラグ（メニューの無限ループを抜ける用）
            while(!endFlag) {
                switch (menuDisp()) {
                    case 1: //一覧出力処理
                        allDisp();
                        break;
                    case 2:
                        searchPrefCaptalLocation();
                        break;
                    default:
                        endFlag = true;
                        break;
                }
            }
        }


        //メニュー表示
        private static int menuDisp() {
            Console.WriteLine("\n*** メニュー ***");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.Write(">");

            //メニュー番号を入力させて呼び出し元へ返却
            var menuSelect = int.Parse(Console.ReadLine() ??"9");
            return menuSelect;
        }

        //一覧表示処理
        private static void allDisp() {
            //コレクション　（prefOfficeDict）
            foreach (var p in prefOfficeDict) {
                Console.WriteLine($"{p.Key}の県庁所在地は{p.Value}です。");
            }
        }

        ////検索処理
        private static void searchPrefCaptalLocation() {
            Console.Write("都道府県");
            var searchPref = Console.ReadLine();
            if (searchPref is null) {
                return;
            }
            if(prefOfficeDict.ContainsKey(searchPref)) {
                Console.WriteLine(searchPref + "の県庁所在地は" + prefOfficeDict[searchPref] + "です");
            }
        }
    }
}


