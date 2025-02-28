using System;
using System.Data.SqlTypes;

namespace SteevesLab3;

public partial class AddProductForm : Form
{
    //Class-level variable for the product type that was selected in the MainForm's combobox
    private string productType;
    private MainForm mainForm;

    public AddProductForm(string type, MainForm parentForm)
    {
        InitializeComponent();
        //Stores selected productType from MainForm
        productType = type;
        
        //Stores MainForm reference
        mainForm = parentForm;
    }

    //Event for form load
    private void AddProductForm_Load(object sender, EventArgs e)
    {

        // Dummy Data for Processors
        string[] processors = { "Intel Core i7", "Intel Core i5", "AMD Ryzen 7", "Apple M2",
            "Qualcomm Snapdragon" };

        // Dummy Data for Operating Systems
        string[] operatingSystems = { "Android 13", "iOS 17", "Windows 11 Mobile (Legacy)",
            "Other" };

        // Dummy Data for Accessory Types
        string[] accessoryTypes = { "Charger", "Case", "Headphones", "Screen Protector",
            "Keyboard", "Mouse" };

        //Runs if product type Laptop is selected in the combobox from MainForm
        if (productType == "Laptop")
        {
            //Sets form name to specific product
            this.Text = "Add New Laptop";

            //Data for Processor
            lblFirstOption.Text = "Processor:";
            cboFirstOption.Items.AddRange(processors);
            cboFirstOption.SelectedIndex = 0;

            //Data for Ram
            lblSecondOption.Text = "Ram:";
        }

        //Runs if product type Smartphone is selected in the combobox from MainForm
        else if (productType == "Smartphone")
        {
            //Sets form name to specific product
            this.Text = "Add New Smartphone";

            //Data for Operating System
            lblFirstOption.Text = "Operating System:";
            cboFirstOption.Items.AddRange(operatingSystems);
            cboFirstOption.SelectedIndex = 0;

            //Data for Storage
            lblSecondOption.Text = "Storage:";
        }

        //Runs if product type Accessory is selected in the combobox from MainForm
        else if (productType == "Accessory")
        {
            //Sets form name to specific product
            this.Text = "Add New Accessory";

            //Data for Accessory Type
            lblFirstOption.Text = "Accessory Type:";
            cboFirstOption.Items.AddRange(accessoryTypes);
            cboFirstOption.SelectedIndex = 0;

            //Hides the second option controls
            lblSecondOption.Visible = false;
            nudSecondOption.Visible = false;
        }
    }

    //Button event for saving a product to listbox
    private void btnSaveProduct_Click(object sender, EventArgs e)
    {
        //Get data from form controls
        int productID = Convert.ToInt32(nudProductID.Value);
        string name = txtName.Text;
        decimal price = Convert.ToDecimal(nudPrice.Value);
        int quantity = Convert.ToInt32(nudQuantity.Value);

        //Instantiate new product
        Product newProduct = null;

        //If-else-if chain for data from product-specific controls
        if (productType == "Laptop")
        {
            //Get data from form controls
            string processor = cboFirstOption.SelectedItem.ToString();
            int ram = Convert.ToInt32(nudSecondOption.Value);

            newProduct = new Laptop(productID, name, price, quantity, processor, ram);
        }

        //Runs if product type Smartphone is selected in the combobox from MainForm
        else if (productType == "Smartphone")
        {
            //Get data from form controls
            string operatingSystem = cboFirstOption.SelectedItem.ToString();
            int storage = Convert.ToInt32(nudSecondOption.Value);

            newProduct = new Smartphone(productID, name, price, quantity, operatingSystem, storage);
        }

        //Runs if product type Accessory is selected in the combobox from MainForm
        else if (productType == "Accessory")
        {
            //Get data from form controls
            string accessoryType = cboFirstOption.SelectedItem.ToString();

            newProduct = new Accessory(productID, name, price, quantity, accessoryType);
        }

        //Error message for empty name
        if (name == "")
        {
            MessageBox.Show("Please type a name for the product.", "Invalid Name");
            txtName.Focus();
            return;
        }

        //Error message for productID less than 1 or greater than 100
        if (productID  < 1 || productID > 100)
        {
            MessageBox.Show("Please choose a ProductID between 1 and 100.", "Invalid ProductID");
            nudProductID.Focus();
            return;
        }

        //Confirmation message for price equal to 0
        if (price == 0)
        {
            DialogResult priceResult = MessageBox.Show("Are you sure you want price to be set to $0.00?", "Price Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (priceResult == DialogResult.No)
            {
                nudPrice.Focus();
                return;
            }
        }

        //Confirmation message for quantity equal to 0
        if (quantity == 0)
        {
            DialogResult quantityResult = MessageBox.Show("Are you sure you want quantity to be set to 0?", "Quantity Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quantityResult == DialogResult.No)
            {
                nudQuantity.Focus();
                return;
            }
        }

        //Adds newProduct to the listbox on main form if it isnt null
        if (newProduct != null)
        {
            mainForm.AddProductToList(newProduct);
        }

        //Close();
        Close();
    }
}