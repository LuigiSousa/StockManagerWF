using MySql.Data.MySqlClient;

namespace StockManager.ItemFunctions
{
    internal class deleteItem
    {
        static MySqlConnection SqlConnection;
        public static void DeleteItem(int id)
        {
            try
            {
                string data_source = "//";
                SqlConnection = new MySqlConnection(data_source);

                string sql = "delete from item where id = " + id;

                MySqlCommand SqlCommand = new MySqlCommand(sql, SqlConnection);
                SqlConnection.Open();

                SqlCommand.ExecuteReader();

                MessageBox.Show("Item Deleted");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                SqlConnection.Close();
            }
        }
    }
}
