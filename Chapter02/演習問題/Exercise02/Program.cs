namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintInchToMeterList(1, 10);
        }
        static void PrintInchToMeterList(int start, int stop) {
            //インチからメートルへの対応表を出力
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.FromInch(inch);
                Console.WriteLine($"{inch}inch = {meter:0.0000}m");
            }
        }
    }
}
