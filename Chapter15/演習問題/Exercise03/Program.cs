using Exercise03;

var service = new Take20Service();
var processor = new TextFileProcessor(service);
//Console.Write("パスの入力 : ");
//processor.Run(Console.ReadLine() ?? "");
//string fileName = @"C:\Users\infosys\source\repos\OOP2026\Chapter15\演習問題\Exercise03\枕草子.txt";

string fileName = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\演習問題\Exercise01_WPF\吾輩は猫である.txt";
processor.Run(fileName);
