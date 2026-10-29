using TextFileProcessorDI;

var service = new LineCounterService();
var processor = new TextFileProcessor(service);
Console.Write("パスの入力 : ");
processor.Run(Console.ReadLine() ?? "");
//string fileName = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\演習問題\Exercise01_WPF\走れメロス.txt";
//processor.Run(fileName);