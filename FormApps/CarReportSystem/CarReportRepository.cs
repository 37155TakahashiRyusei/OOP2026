using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    internal class CarReportRepository {
        public List<CarReport> GetAll() {
            var products = new List<CarReport>();

            using var connection = Database.GetConnection();
            connection.Open();

            //SQLを実行するためのｺﾏﾝﾄﾞオブジェクトを作る
            using var command = connection.CreateCommand();

            //Productsテーブルを作るSQL
            command.CommandText =
                """
            SELECT Id, Name, Price
            FROM Settings
            ORDER BY Id;
            """;
        }
    }
}
