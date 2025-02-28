namespace SteevesLab3
{
    public partial class MainForm : Form
    {
        //Class-level list to keep track of all products
        private List<Product> inventory = new List<Product>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set labels to default and clear listbox
            lblHighestPrice.Text = "Highest Price:\n" + 0.ToString("C");
            lblTotalQuantity.Text = "Total Quantity:\n0";
            lstDisplay.Items.Clear();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            //Ensures a product type is selected before opening second form
            if (cboProductType.Text == "")
            {
                MessageBox.Show("Please select a product type.", "Unspecified Product Type");
            }
            else
            {
                //Opens second form and sends product type and form name to second form
                string selectedType = cboProductType.SelectedItem.ToString();
                AddProductForm addForm = new AddProductForm(selectedType, this);
                addForm.ShowDialog();
            }
        }

        //Loops and adds each product
        public void AddProductToList(Product product)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].ProductID == product.ProductID)
                {
                    MessageBox.Show("A product with this Product ID already exists. Both products will be added together.", "Duplicate ProductID");
                    inventory[i] = inventory[i] + product;
                    RefreshProductList();
                    return;

                }
            }

            inventory.Add(product);
            RefreshProductList();
        }

        //Clears and adds new products to the listbox
        private void RefreshProductList()
        {
            lstDisplay.Items.Clear();
            foreach (Product product in inventory)
            {
                lstDisplay.Items.Add(product.ToString());
            }
            
            //Updates labels
            lblHighestPrice.Text = "Highest Price:\n" + Product.GetHighestPriceEver().ToString("C");
            lblTotalQuantity.Text = "Total Quantity:\n" + GetTotalQuantity().ToString();
        }

        private int GetTotalQuantity()
        {
            int total = 0;
            foreach (Product product in inventory)
            {
                total += product.Quantity;
            }

            return total;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Closing Form", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
