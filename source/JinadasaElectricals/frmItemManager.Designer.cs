namespace  BarcodeGenarator
{
    partial class frmItemManager
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
            this.tabitemmanager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackDate = new System.Windows.Forms.TextBox();
            this.buttonSearchItem = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.textBoxBillName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbItemCategry = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Item_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_ItemList = new System.Windows.Forms.DataGridView();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.txtShowDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbShowItemCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabitemmanager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxItem.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabitemmanager
            // 
            this.tabitemmanager.Controls.Add(this.tabPage1);
            this.tabitemmanager.Controls.Add(this.tabPage2);
            this.tabitemmanager.Location = new System.Drawing.Point(-3, 0);
            this.tabitemmanager.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tabitemmanager.Name = "tabitemmanager";
            this.tabitemmanager.SelectedIndex = 0;
            this.tabitemmanager.Size = new System.Drawing.Size(849, 386);
            this.tabitemmanager.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.groupBoxItem);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tabPage1.Size = new System.Drawing.Size(841, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Item";
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Controls.Add(this.label3);
            this.groupBoxItem.Controls.Add(this.txtPackDate);
            this.groupBoxItem.Controls.Add(this.buttonSearchItem);
            this.groupBoxItem.Controls.Add(this.btnNew);
            this.groupBoxItem.Controls.Add(this.textBoxBillName);
            this.groupBoxItem.Controls.Add(this.txtDescription);
            this.groupBoxItem.Controls.Add(this.groupBox4);
            this.groupBoxItem.Controls.Add(this.cmbItemCategry);
            this.groupBoxItem.Controls.Add(this.label10);
            this.groupBoxItem.Controls.Add(this.label6);
            this.groupBoxItem.Controls.Add(this.label2);
            this.groupBoxItem.Controls.Add(this.txt_Item_Code);
            this.groupBoxItem.Controls.Add(this.label1);
            this.groupBoxItem.Location = new System.Drawing.Point(12, 4);
            this.groupBoxItem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxItem.Size = new System.Drawing.Size(824, 345);
            this.groupBoxItem.TabIndex = 17;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "New Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Pack Date";
            // 
            // txtPackDate
            // 
            this.txtPackDate.Location = new System.Drawing.Point(199, 194);
            this.txtPackDate.Name = "txtPackDate";
            this.txtPackDate.Size = new System.Drawing.Size(123, 23);
            this.txtPackDate.TabIndex = 35;
            this.txtPackDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPackDate_KeyDown);
            // 
            // buttonSearchItem
            // 
            this.buttonSearchItem.Location = new System.Drawing.Point(685, 21);
            this.buttonSearchItem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSearchItem.Name = "buttonSearchItem";
            this.buttonSearchItem.Size = new System.Drawing.Size(114, 28);
            this.buttonSearchItem.TabIndex = 2;
            this.buttonSearchItem.Text = "Search Items";
            this.buttonSearchItem.UseVisualStyleBackColor = true;
            this.buttonSearchItem.Click += new System.EventHandler(this.buttonSearchItem_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(570, 21);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 28);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Item";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textBoxBillName
            // 
            this.textBoxBillName.Location = new System.Drawing.Point(199, 109);
            this.textBoxBillName.Name = "textBoxBillName";
            this.textBoxBillName.Size = new System.Drawing.Size(484, 23);
            this.textBoxBillName.TabIndex = 4;
            this.textBoxBillName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBillName_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(199, 69);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(484, 23);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(10, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(803, 68);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(676, 24);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(551, 24);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(426, 24);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbItemCategry
            // 
            this.cmbItemCategry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemCategry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemCategry.FormattingEnabled = true;
            this.cmbItemCategry.Location = new System.Drawing.Point(199, 152);
            this.cmbItemCategry.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbItemCategry.Name = "cmbItemCategry";
            this.cmbItemCategry.Size = new System.Drawing.Size(354, 24);
            this.cmbItemCategry.TabIndex = 4;
            this.cmbItemCategry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItemCategry_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Part No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description";
            // 
            // txt_Item_Code
            // 
            this.txt_Item_Code.Location = new System.Drawing.Point(199, 23);
            this.txt_Item_Code.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_Item_Code.Name = "txt_Item_Code";
            this.txt_Item_Code.Size = new System.Drawing.Size(123, 23);
            this.txt_Item_Code.TabIndex = 0;
            this.txt_Item_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_Code_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Item Code";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.dgv_ItemList);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tabPage2.Size = new System.Drawing.Size(841, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Items";
            // 
            // dgv_ItemList
            // 
            this.dgv_ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemCode,
            this.colItemDescription,
            this.colCostPrice,
            this.colItemID});
            this.dgv_ItemList.Location = new System.Drawing.Point(9, 112);
            this.dgv_ItemList.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dgv_ItemList.Name = "dgv_ItemList";
            this.dgv_ItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ItemList.Size = new System.Drawing.Size(817, 231);
            this.dgv_ItemList.TabIndex = 4;
            this.dgv_ItemList.DoubleClick += new System.EventHandler(this.dgv_ItemList_DoubleClick);
            this.dgv_ItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_ItemList_KeyDown);
            // 
            // colItemCode
            // 
            this.colItemCode.HeaderText = "Item Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Width = 120;
            // 
            // colItemDescription
            // 
            this.colItemDescription.HeaderText = "Item Description";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Width = 420;
            // 
            // colCostPrice
            // 
            this.colCostPrice.HeaderText = "Part No";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.Width = 200;
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonClearSearch);
            this.groupBox3.Controls.Add(this.txtShowDescription);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.cmbShowItemCategory);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox3.Size = new System.Drawing.Size(820, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Items";
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Location = new System.Drawing.Point(636, 60);
            this.buttonClearSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(120, 28);
            this.buttonClearSearch.TabIndex = 3;
            this.buttonClearSearch.Text = "Clear";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // txtShowDescription
            // 
            this.txtShowDescription.Location = new System.Drawing.Point(192, 63);
            this.txtShowDescription.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtShowDescription.Name = "txtShowDescription";
            this.txtShowDescription.Size = new System.Drawing.Size(310, 23);
            this.txtShowDescription.TabIndex = 1;
            this.txtShowDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShowDescription_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Description";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbShowItemCategory
            // 
            this.cmbShowItemCategory.FormattingEnabled = true;
            this.cmbShowItemCategory.Location = new System.Drawing.Point(192, 30);
            this.cmbShowItemCategory.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbShowItemCategory.Name = "cmbShowItemCategory";
            this.cmbShowItemCategory.Size = new System.Drawing.Size(310, 24);
            this.cmbShowItemCategory.TabIndex = 0;
            this.cmbShowItemCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbShowItemCategory_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Item Category";
            // 
            // frmItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(845, 382);
            this.Controls.Add(this.tabitemmanager);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "frmItemManager";
            this.Text = "Item Manager";
            this.Load += new System.EventHandler(this.frmItemManager_Load);
            this.tabitemmanager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabitemmanager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbShowItemCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Item_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_ItemList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button buttonSearchItem;
        private System.Windows.Forms.ComboBox cmbItemCategry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShowDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.TextBox textBoxBillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackDate;
    }
}