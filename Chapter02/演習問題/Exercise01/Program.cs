
using System.Diagnostics.Metrics;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new List<Song>();
            while (true) {
                Console.WriteLine("***** 曲の登録 *****");
                Console.Write("曲名：");
                String? title = Console.ReadLine();
                if (title.ToLower() == "end") {
                    break;
                }
                Console.Write("アーティスト名：");
                String? artistName = Console.ReadLine();
                Console.Write("演奏時間(秒)：");
                int length = Console.Read();
                Console.ReadLine();//改行用
                Song song = new Song(title, artistName, length);
                songs.Add(song);
            }
            PrintSongs(songs);
        }
        private static void PrintSongs(List<Song> songs) {
            foreach (var song in songs) {
                Console.Write("曲名 " + $"{song.Title},{"アーティスト名 " + song.ArtistName}");
                Console.WriteLine($"演奏時間 {song.Length / 60}:{song.Length % 60:00}");
            }
        }
    }
    //Mainメソッド内の PrintSongs(songs); をクリックして
    //Alt + Enterを押してメソッドを生成を選択すると、以下のメソッドが自動的に作成される
    //2.1.4

    // 2.1.3
    //var songs = new Song[] {
    //    new Song("Let it be", "The Beatles", 243),
    //    new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
    //    new Song("Close To You", "Carpenters", 276),
    //    new Song("Honesty", "Billy Joel", 231),
    //    new Song("I Will Always Love You", "Whitney Houston", 273),
    //};

}




