using StockManager.ItemFunctions;

namespace StockManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createList();
        }

        public void createList()
        {
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 255, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity", 155, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create new Item
            int quantity = int.Parse(txtQuantity.Text);
            createItem.CreateItem(txtName.Text, quantity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Search for a item 
            listView1.Items.Clear();
            String ItemName = txtSearch.Text;

            int[] data = searchItem.SearchItem(ItemName);

            if (data[0] != 0)
            {
                String[] listItem =
                {
                    data[0].ToString(),
                    ItemName,
                    data[1].ToString()
                };

                var lineListView = new ListViewItem(listItem);
                listView1.Items.Add(lineListView);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Change a item quantity or delete
            int id = int.Parse(txtId.Text);
            int newQuantity = int.Parse(txtNewQuantity.Text);

            if (newQuantity > 0)
            {
                // Update
                updateItem.UpdateItem(id, newQuantity);
            }else
            {
                // Delete
                deleteItem.DeleteItem(id);
            }
        }
    }
}
