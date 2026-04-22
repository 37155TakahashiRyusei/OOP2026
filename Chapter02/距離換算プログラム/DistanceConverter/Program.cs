

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3 && int.TryParse(args[1], out int start) && int.TryParse(args[2], out int stop))
            {
                if (args.Length >= 1 && args[0] == "-tom")
                {
                    PrintFeetToMeterList(start, stop);  //メートルへの変換
                }
                else if (args.Length >= 1 && args[0] == "-tof")
                {
                    PrintMeterToFeetList(start, stop);  //フィートへの変換
                }
                else
                {
                    //エラーメッセージ
                    Console.WriteLine("引数エラー");
                }
            }
            else
            {
                Console.WriteLine("変換できません");
            }

            static void PrintFeetToMeterList(int start, int stop)
            {
                //フィートからメートルへの対応表を出力
                for (int feet = start; feet <= stop; feet++)
                {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine($"{feet}ft = {meter:0.0000}m");
                }
            }

            static void PrintMeterToFeetList(int start, int stop)
            {
                //メートルからフィートへの対応表を出力
                for (int meter = start; meter <= stop; meter++)
                {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine($"{meter}m = {feet:0.0000}ft");
                }
            }
            //フィートからメートルを求める
            static double FeetToMeter(int feet)
            {
                return feet * 0.3084;
            }
            //メートルからフィートを求める
            static double MeterToFeet(int meter)
            {
                return meter / 0.3048;
            }
        }
    }
}
