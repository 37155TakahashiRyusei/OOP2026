using System.Xml.Linq;
using TextFileProcessor;


string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";
//Console.Write("カウントしたい単語 : ");
//LineCounterProcessor.Word = Console.ReadLine()?? "";
//?? ""でnullの警告を消す。

TextProcessor.Run<LineCounterProcessor>(path);

public class LineCounterProcessor : TextProcessor {
    private int _count = 0;

    // ?でnullでも警告がでない
    public static string Word = "";

    protected override void Initialize(string fname) {
        _count = 0;
        Console.Write("カウントしたい単語 : ");
        Word = Console.ReadLine() ?? "";
    }


    protected override void Execute(string line) =>
    //_count++;

    _count += line.Split(Word).Length - 1;


    protected override void Terminate() =>
       //Console.WriteLine("{0} 行", _count);
       Console.WriteLine($"{Word} は {_count} つ出現します");
}

