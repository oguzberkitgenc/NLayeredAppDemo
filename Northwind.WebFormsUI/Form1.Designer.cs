namespace Northwind.WebFormsUI
{
    partial class Form1
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
            dgwProduct = new DataGridView();
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxProductName = new GroupBox();
            tbxProductName = new TextBox();
            lblProductName = new Label();
            gbxProductAdd = new GroupBox();
            btnAdd = new Button();
            tbxQuantityPerUnit = new TextBox();
            tbxStock = new TextBox();
            tbxUnitPrice = new TextBox();
            cbxCategory2 = new ComboBox();
            tbxProductName2 = new TextBox();
            lblQuantityPerUnit = new Label();
            lblStock = new Label();
            lblUnitPrice = new Label();
            lblCategoryId = new Label();
            lblProductName2 = new Label();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            tbxUpdateQuantityPerUnit = new TextBox();
            tbxUpdateStock = new TextBox();
            tbxUpdateUnitPrice = new TextBox();
            cbxUpdateCategoryId = new ComboBox();
            tbxUpdateProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            gbxCategory.SuspendLayout();
            gbxProductName.SuspendLayout();
            gbxProductAdd.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(7, 170);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.RowHeadersWidth = 51;
            dgwProduct.Size = new Size(1089, 218);
            dgwProduct.TabIndex = 0;
            dgwProduct.CellClick += dgwProduct_CellClick;
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(1084, 73);
            gbxCategory.TabIndex = 1;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(86, 34);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(373, 28);
            cbxCategory.TabIndex = 3;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(6, 37);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 20);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Kategori :";
            // 
            // gbxProductName
            // 
            gbxProductName.Controls.Add(tbxProductName);
            gbxProductName.Controls.Add(lblProductName);
            gbxProductName.Location = new Point(12, 91);
            gbxProductName.Name = "gbxProductName";
            gbxProductName.Size = new Size(1084, 73);
            gbxProductName.TabIndex = 2;
            gbxProductName.TabStop = false;
            gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(86, 30);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(373, 27);
            tbxProductName.TabIndex = 3;
            tbxProductName.TextChanged += tbxProductName_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 33);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(74, 20);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Ürün Adı :";
            // 
            // gbxProductAdd
            // 
            gbxProductAdd.Controls.Add(btnAdd);
            gbxProductAdd.Controls.Add(tbxQuantityPerUnit);
            gbxProductAdd.Controls.Add(tbxStock);
            gbxProductAdd.Controls.Add(tbxUnitPrice);
            gbxProductAdd.Controls.Add(cbxCategory2);
            gbxProductAdd.Controls.Add(tbxProductName2);
            gbxProductAdd.Controls.Add(lblQuantityPerUnit);
            gbxProductAdd.Controls.Add(lblStock);
            gbxProductAdd.Controls.Add(lblUnitPrice);
            gbxProductAdd.Controls.Add(lblCategoryId);
            gbxProductAdd.Controls.Add(lblProductName2);
            gbxProductAdd.Location = new Point(18, 394);
            gbxProductAdd.Name = "gbxProductAdd";
            gbxProductAdd.Size = new Size(492, 277);
            gbxProductAdd.TabIndex = 3;
            gbxProductAdd.TabStop = false;
            gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(327, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 33);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantityPerUnit
            // 
            tbxQuantityPerUnit.Location = new Point(107, 195);
            tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            tbxQuantityPerUnit.Size = new Size(373, 27);
            tbxQuantityPerUnit.TabIndex = 14;
            // 
            // tbxStock
            // 
            tbxStock.Location = new Point(107, 152);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(373, 27);
            tbxStock.TabIndex = 13;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(107, 109);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(373, 27);
            tbxUnitPrice.TabIndex = 12;
            // 
            // cbxCategory2
            // 
            cbxCategory2.FormattingEnabled = true;
            cbxCategory2.Location = new Point(107, 68);
            cbxCategory2.Name = "cbxCategory2";
            cbxCategory2.Size = new Size(373, 28);
            cbxCategory2.TabIndex = 11;
            // 
            // tbxProductName2
            // 
            tbxProductName2.Location = new Point(107, 29);
            tbxProductName2.Name = "tbxProductName2";
            tbxProductName2.Size = new Size(373, 27);
            tbxProductName2.TabIndex = 10;
            // 
            // lblQuantityPerUnit
            // 
            lblQuantityPerUnit.AutoSize = true;
            lblQuantityPerUnit.Location = new Point(6, 198);
            lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            lblQuantityPerUnit.Size = new Size(95, 20);
            lblQuantityPerUnit.TabIndex = 9;
            lblQuantityPerUnit.Text = "Birim Adedi :";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 155);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(89, 20);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stok Adedi :";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(54, 112);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(47, 20);
            lblUnitPrice.TabIndex = 7;
            lblUnitPrice.Text = "Fiyat :";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(28, 71);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(73, 20);
            lblCategoryId.TabIndex = 6;
            lblCategoryId.Text = "Kategori :";
            // 
            // lblProductName2
            // 
            lblProductName2.AutoSize = true;
            lblProductName2.Location = new Point(27, 32);
            lblProductName2.Name = "lblProductName2";
            lblProductName2.Size = new Size(74, 20);
            lblProductName2.TabIndex = 5;
            lblProductName2.Text = "Ürün Adı :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(tbxUpdateQuantityPerUnit);
            groupBox1.Controls.Add(tbxUpdateStock);
            groupBox1.Controls.Add(tbxUpdateUnitPrice);
            groupBox1.Controls.Add(cbxUpdateCategoryId);
            groupBox1.Controls.Add(tbxUpdateProductName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(604, 394);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 277);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(327, 228);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 33);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            tbxUpdateQuantityPerUnit.Location = new Point(107, 195);
            tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            tbxUpdateQuantityPerUnit.Size = new Size(373, 27);
            tbxUpdateQuantityPerUnit.TabIndex = 14;
            // 
            // tbxUpdateStock
            // 
            tbxUpdateStock.Location = new Point(107, 152);
            tbxUpdateStock.Name = "tbxUpdateStock";
            tbxUpdateStock.Size = new Size(373, 27);
            tbxUpdateStock.TabIndex = 13;
            // 
            // tbxUpdateUnitPrice
            // 
            tbxUpdateUnitPrice.Location = new Point(107, 109);
            tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            tbxUpdateUnitPrice.Size = new Size(373, 27);
            tbxUpdateUnitPrice.TabIndex = 12;
            // 
            // cbxUpdateCategoryId
            // 
            cbxUpdateCategoryId.FormattingEnabled = true;
            cbxUpdateCategoryId.Location = new Point(107, 68);
            cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            cbxUpdateCategoryId.Size = new Size(373, 28);
            cbxUpdateCategoryId.TabIndex = 11;
            // 
            // tbxUpdateProductName
            // 
            tbxUpdateProductName.Location = new Point(107, 29);
            tbxUpdateProductName.Name = "tbxUpdateProductName";
            tbxUpdateProductName.Size = new Size(373, 27);
            tbxUpdateProductName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 198);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 9;
            label1.Text = "Birim Adedi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 8;
            label2.Text = "Stok Adedi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 112);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Fiyat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 71);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Kategori :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 32);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Ürün Adı :";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(516, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 56);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 682);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(gbxProductAdd);
            Controls.Add(gbxProductName);
            Controls.Add(gbxCategory);
            Controls.Add(dgwProduct);
            Name = "Form1";
            Text = "Ürünler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxProductName.ResumeLayout(false);
            gbxProductName.PerformLayout();
            gbxProductAdd.ResumeLayout(false);
            gbxProductAdd.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProduct;
        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxProductName;
        private TextBox tbxProductName;
        private Label lblProductName;
        private GroupBox gbxProductAdd;
        private Label lblQuantityPerUnit;
        private Label lblStock;
        private Label lblUnitPrice;
        private Label lblCategoryId;
        private Label lblProductName2;
        private Button btnAdd;
        private TextBox tbxQuantityPerUnit;
        private TextBox tbxStock;
        private TextBox tbxUnitPrice;
        private ComboBox cbxCategory2;
        private TextBox tbxProductName2;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private TextBox tbxUpdateQuantityPerUnit;
        private TextBox tbxUpdateStock;
        private TextBox tbxUpdateUnitPrice;
        private ComboBox cbxUpdateCategoryId;
        private TextBox tbxUpdateProductName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDelete;
    }
}
