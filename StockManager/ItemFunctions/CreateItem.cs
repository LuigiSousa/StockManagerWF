using MySql.Data.MySqlClient;

namespace StockManager.ItemFunctions
{
    public class createItem
    {
        static MySqlConnection SqlConnection;
        public static bool CreateItem(string name, int quantity)
        {
            try
            {

                string data_source = "//";
                SqlConnection = new MySqlConnection(data_source);
                string sql = "insert into item(itemName, quantity)" +
                             "values" +
                             "('" + name + "', '" + quantity + "');";

                MySqlCommand SqlCommand = new MySqlCommand(sql, SqlConnection);

                SqlConnection.Open();

                SqlCommand.ExecuteReader();

                MessageBox.Show("Create item!");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                SqlConnection.Close();
            }
            return true;
        }
    }
}
