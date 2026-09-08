namespace CarReportSystem {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            Application.Run(new Form1());

            try {
                //SQLiteデータベースを初期化する
                //products.dbが存在しない場合は作成され
                //Productsテーブルも存在しない場所だけ作成される
                Database.Initialize();
                Application.Run(new Form1());
            } catch (Exception ex) {
                MessageBox.Show(
                    $"アプリケーションの起動に失敗しました。\n\n{ex.Message}",
                    "起動エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}