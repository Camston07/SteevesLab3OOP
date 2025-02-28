namespace SteevesLab3
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            nudProductID = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            grpSpecifics = new GroupBox();
            nudSecondOption = new NumericUpDown();
            cboFirstOption = new ComboBox();
            lblSecondOption = new Label();
            lblFirstOption = new Label();
            btnSaveProduct = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            grpSpecifics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSecondOption).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 201);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity: (Max 200)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 140);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Price: (Max $10,000.00)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 79);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 5;
            label6.Text = "Product ID: (Max 1000)";
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(29, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 27);
            txtName.TabIndex = 0;
            // 
            // nudProductID
            // 
            nudProductID.Cursor = Cursors.Hand;
            nudProductID.Location = new Point(29, 106);
            nudProductID.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudProductID.Name = "nudProductID";
            nudProductID.Size = new Size(162, 27);
            nudProductID.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Cursor = Cursors.Hand;
            nudQuantity.Location = new Point(29, 228);
            nudQuantity.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(162, 27);
            nudQuantity.TabIndex = 3;
            // 
            // nudPrice
            // 
            nudPrice.Cursor = Cursors.Hand;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(29, 167);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(162, 27);
            nudPrice.TabIndex = 2;
            // 
            // grpSpecifics
            // 
            grpSpecifics.Controls.Add(nudSecondOption);
            grpSpecifics.Controls.Add(cboFirstOption);
            grpSpecifics.Controls.Add(lblSecondOption);
            grpSpecifics.Controls.Add(lblFirstOption);
            grpSpecifics.Location = new Point(206, 12);
            grpSpecifics.Name = "grpSpecifics";
            grpSpecifics.Size = new Size(257, 157);
            grpSpecifics.TabIndex = 4;
            grpSpecifics.TabStop = false;
            // 
            // nudSecondOption
            // 
            nudSecondOption.Cursor = Cursors.Hand;
            nudSecondOption.Location = new Point(6, 115);
            nudSecondOption.Name = "nudSecondOption";
            nudSecondOption.Size = new Size(245, 27);
            nudSecondOption.TabIndex = 1;
            // 
            // cboFirstOption
            // 
            cboFirstOption.Cursor = Cursors.Hand;
            cboFirstOption.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFirstOption.FormattingEnabled = true;
            cboFirstOption.Location = new Point(6, 51);
            cboFirstOption.Name = "cboFirstOption";
            cboFirstOption.Size = new Size(245, 28);
            cboFirstOption.TabIndex = 0;
            // 
            // lblSecondOption
            // 
            lblSecondOption.AutoSize = true;
            lblSecondOption.Location = new Point(6, 87);
            lblSecondOption.Name = "lblSecondOption";
            lblSecondOption.Size = new Size(190, 20);
            lblSecondOption.TabIndex = 1;
            lblSecondOption.Text = "Second Option Placeholder";
            // 
            // lblFirstOption
            // 
            lblFirstOption.AutoSize = true;
            lblFirstOption.Location = new Point(6, 23);
            lblFirstOption.Name = "lblFirstOption";
            lblFirstOption.Size = new Size(171, 20);
            lblFirstOption.TabIndex = 0;
            lblFirstOption.Text = "First Option Placeholder:";
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Cursor = Cursors.Hand;
            btnSaveProduct.Location = new Point(60, 282);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(163, 98);
            btnSaveProduct.TabIndex = 5;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(252, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 98);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AcceptButton = btnSaveProduct;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(475, 401);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProduct);
            Controls.Add(grpSpecifics);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(nudProductID);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            grpSpecifics.ResumeLayout(false);
            grpSpecifics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSecondOption).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private NumericUpDown nudProductID;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
        private GroupBox grpSpecifics;
        private NumericUpDown nudSecondOption;
        private ComboBox cboFirstOption;
        private Label lblSecondOption;
        private Label lblFirstOption;
        private Button btnSaveProduct;
        private Button btnCancel;
    }
}