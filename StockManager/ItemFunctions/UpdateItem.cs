using MySql.Data.MySqlClient;

namespace StockManager.ItemFunctions
{
    internal class updateItem
    {
        static MySqlConnection SqlConnection;

        public static void UpdateItem(int id, int quantity)
        {
            try
            {
                string data_source = "//";
                SqlConnection = new MySqlConnection(data_source);
                string slq = "update item set quantity = " + quantity + " where id = " + id;

                MySqlCommand SqlCommand = new MySqlCommand(slq, SqlConnection);
                SqlConnection.Open();

                SqlCommand.ExecuteReader();

                MessageBox.Show("Item updated!");
            }catch (Exception)
            {
                MessageBox.Show("Failed to update");
            }finally
            {
                SqlConnection.Close();
            }
        }
    }
}
