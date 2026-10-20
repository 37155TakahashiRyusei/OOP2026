using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;


namespace Exercise01_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() is true) {
                TextArea.Text = await TextReaderSample.ReadTextAsync(ofd.FileName);
            }
        }
    }

    //非同期ファイル読み込み処理
    static class TextReaderSample {
        public static async Task<string> ReadTextAsync(string fileName) {

            using (StreamReader sr =
             new StreamReader(fileName, Encoding.UTF8)) {
                return await sr.ReadToEndAsync();
            }
        }
        //var sb = new StringBuilder();

        ////ここに非同期でテキストファイルを読み込む処理を記述する
        //StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("Shift_JIS"));
        //     string str =await sr.ReadToEndAsync();

        ////string str = sr.ReadToEnd();
        ////sr.Close();
        ////Console.WriteLine(str);
        ////Console.ReadKey();
        //return await sr.ReadToEndAsync();
        ////return sb.ToString();
    }
}
