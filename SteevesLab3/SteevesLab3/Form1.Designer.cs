namespace SteevesLab3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpProductStats = new GroupBox();
            lblTotalQuantity = new Label();
            lblHighestPrice = new Label();
            label1 = new Label();
            cboProductType = new ComboBox();
            btnAddNewProduct = new Button();
            btnExit = new Button();
            lstDisplay = new ListBox();
            grpProductStats.SuspendLayout();
            SuspendLayout();
            // 
            // grpProductStats
            // 
            grpProductStats.Controls.Add(lblTotalQuantity);
            grpProductStats.Controls.Add(lblHighestPrice);
            grpProductStats.Location = new Point(12, 12);
            grpProductStats.Name = "grpProductStats";
            grpProductStats.Size = new Size(194, 143);
            grpProductStats.TabIndex = 0;
            grpProductStats.TabStop = false;
            grpProductStats.Text = "Product Stats: ";
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(6, 88);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(105, 20);
            lblTotalQuantity.TabIndex = 2;
            lblTotalQuantity.Text = "Total Quantity:";
            // 
            // lblHighestPrice
            // 
            lblHighestPrice.AutoSize = true;
            lblHighestPrice.Location = new Point(6, 35);
            lblHighestPrice.Name = "lblHighestPrice";
            lblHighestPrice.Size = new Size(99, 20);
            lblHighestPrice.TabIndex = 1;
            lblHighestPrice.Text = "Highest Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 169);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 1;
            label1.Text = "Select a Product Type:";
            // 
            // cboProductType
            // 
            cboProductType.Cursor = Cursors.Hand;
            cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductType.FormattingEnabled = true;
            cboProductType.Items.AddRange(new object[] { "Laptop", "Smartphone", "Accessory" });
            cboProductType.Location = new Point(12, 203);
            cboProductType.Name = "cboProductType";
            cboProductType.Size = new Size(194, 28);
            cboProductType.TabIndex = 0;
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Cursor = Cursors.Hand;
            btnAddNewProduct.Location = new Point(12, 254);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(94, 62);
            btnAddNewProduct.TabIndex = 1;
            btnAddNewProduct.Text = "&Add New Product";
            btnAddNewProduct.UseVisualStyleBackColor = true;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(112, 254);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 62);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.Location = new Point(212, 12);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(815, 304);
            lstDisplay.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 335);
            Controls.Add(lstDisplay);
            Controls.Add(btnExit);
            Controls.Add(btnAddNewProduct);
            Controls.Add(cboProductType);
            Controls.Add(label1);
            Controls.Add(grpProductStats);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab by Cameron Steeves";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            grpProductStats.ResumeLayout(false);
            grpProductStats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpProductStats;
        private Label lblTotalQuantity;
        private Label lblHighestPrice;
        private Label label1;
        private ComboBox cboProductType;
        private Button btnAddNewProduct;
        private Button btnExit;
        private ListBox lstDisplay;
    }
}
