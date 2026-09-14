using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    internal class CarReportRepository {
        public List<CarReport> GetAll() {
            var Cars = new List<CarReport>();
            //CarReportRepository.GetAll();
            using var connection = Database.GetConnection();
            connection.Open();

            //SQLを実行するためのｺﾏﾝﾄﾞオブジェクトを作る
            using var command = connection.CreateCommand();

            //Productsテーブルを作るSQL
            command.CommandText =
                """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;

            """;

            //SELECTを実行し、複数行の検索結果を読み取る
            using var reader = command.ExecuteReader();

            while (reader.Read()) {
                Cars.Add(new CarReport {
                    Id = reader.GetInt32(0),
                    Date = DateTime.ParseExact((
                        reader.GetString(1)),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture),

                    Author = reader.GetString(2),
                    //C#側では列挙型、SQLite側ではINTEGERとして保存する
                    Maker = (CarReport.MakerGroup)reader.GetByte(3),
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    Picture = reader.IsDBNull(6)
                                ? null : BytesToImage(reader.GetFieldValue<byte[]>(6))
                    //Picture = BytesToImage((byte[])reader[6])
                });
            }
            return Cars;
        }

        //情報を一件追加する。Create(INSERT)に相当する
        //戻り値として自動採番されたIdを返す

        //, int price
        public int Add(CarReport carReport) {
            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();

            //DBを開く
            connection.Open();

            //SQLを実行するためのｺﾏﾝﾄﾞオブジェクトを作る
            using var command = connection.CreateCommand();

            command.CommandText =
                """
            INSERT INTO CarReports 
                (Date, Author, Maker, CarName, Report, Picture)
            VALUES 
                ($date, $author, $maker, $carName, $report, $picture);

            SELECT last_insert_rowid();
            """;

            SetComandParameters(carReport, command);

            //一つの値を返すSQLを実行する
            var result = command.ExecuteScalar();

            if (result is null) {
                throw new InvalidOperationException("登録したレポートのIDを取得できませんでした。");
            }

            //SQLiteのINTEGERはlongとして返るため、intへ変換する
            return Convert.ToInt32((long)result);
        }

       

        public void Update(CarReport carreport) {
            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();

            //DBを開く
            connection.Open();

            //SQLを実行するためのｺﾏﾝﾄﾞオブジェクトを作る
            using var command = connection.CreateCommand();

            command.CommandText =
                """
            UPDATE CarReports
            SET 
                Date = $date,
                Author = $author,
                Maker = $maker,
                CarName = $carNme,
                Report = $report,
                Picture = $picture
            WHERE Id = $id;
            """;

            SetComandParameters(carreport, command);

            //command.Parameters.AddWithValue($"date", carreport.Date);
            //command.Parameters.AddWithValue($"author", carreport.Author);
            //command.Parameters.AddWithValue($"maker", carreport.Maker);
            //command.Parameters.AddWithValue($"carname", carreport.CarName);
            //command.Parameters.AddWithValue($"report", carreport.Report);
            //command.Parameters.AddWithValue($"picture", ImageToBytes(carreport.Picture));
            command.Parameters.AddWithValue("$id", carreport.Id);

            //更新件数が0なら対象が存在しない
            if (command.ExecuteNonQuery() == 0) {
                throw new InvalidOperationException("修正対象のレポートがみつかりませんでした。");
            }
        }

        private static void SetComandParameters(CarReport carReport, SqliteCommand command) {
            command.Parameters.AddWithValue("$date", carReport.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("$author", carReport.Author);
            command.Parameters.AddWithValue("$maker", carReport.Maker);
            command.Parameters.AddWithValue("$carName", carReport.CarName);
            command.Parameters.AddWithValue("$report", carReport.Report);
            //command.Parameters.AddWithValue("$picture", carReport.Picture);

            //Image型の画像をSQLiteへ保存できるbyte配列に変換する
            Byte[]? pictureData = ImageToBytes(carReport.Picture);

            //$picture パラメータをBLOG型として追加する
            var pictureParameter = command.Parameters.Add("$picture", SqliteType.Blob);
            if (pictureData is not null) {
                pictureParameter.Value = pictureData;
            } else {
                pictureParameter.Value = DBNull.Value;
            }
        }

        public void Delete(int id) {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
            DELETE FROM CarReports
            WHERE Id = $id;
            """;

            command.Parameters.AddWithValue("$id", id);
           
            command.ExecuteNonQuery();
        }

        // ImageをSQLiteへ保存できるbyte[]へ変換する
        private static byte[]? ImageToBytes(Image? image) {
            if (image is null) return null;

            using var stream = new MemoryStream();
            // DBへはPNG形式で保存
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        } 

        // SQLiteのBLOB（byte[]）をImageへ変換する
        private static Image BytesToImage(byte[] data) {
            using var stream = new MemoryStream(data);
            using var image = Image.FromStream(stream);
            // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
            return new Bitmap(image);
        }
    }
}