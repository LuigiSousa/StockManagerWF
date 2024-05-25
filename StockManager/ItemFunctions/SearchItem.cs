using MySql.Data.MySqlClient;

namespace StockManager.ItemFunctions
{
    public class searchItem
    {
        static MySqlConnection SqlConnection;

        public static int[] SearchItem(String name)
        {
            try{

                string data_source = "//";
                SqlConnection = new MySqlConnection(data_source);

                string sql = "select * from item where itemName = '" + name + "'";

                SqlConnection.Open();
                MySqlCommand SqlCommand = new MySqlCommand(sql, SqlConnection);

                MySqlDataReader data = SqlCommand.ExecuteReader();

                while (data.Read())
                {
                    int id = data.GetInt32(0);
                    int quant = data.GetInt32(2);

                    int[] resultData = { 
                        id,
                        quant
                    };
                    return resultData;

                }
                MessageBox.Show("Wasn't able to find item");
                return [0];
            }
            catch (Exception)
            {
                MessageBox.Show("Wasn't able to find item");
                return [0];
            }
        }
    }
}
