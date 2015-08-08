namespace BarcodeGenarator
{
    partial class frmBajajBarcodePrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelsearchItem = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFindItemDescription = new System.Windows.Forms.TextBox();
            this.dgvFindItem = new System.Windows.Forms.DataGridView();
            this.colFindItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFindItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFindSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFindStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoOfLabels = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLabelCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelsearchItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelsearchItem);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(4, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 459);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panelsearchItem
            // 
            this.panelsearchItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelsearchItem.Controls.Add(this.label15);
            this.panelsearchItem.Controls.Add(this.textBoxFindItemDescription);
            this.panelsearchItem.Controls.Add(this.dgvFindItem);
            this.panelsearchItem.Location = new System.Drawing.Point(6, 8);
            this.panelsearchItem.Name = "panelsearchItem";
            this.panelsearchItem.Size = new System.Drawing.Size(719, 380);
            this.panelsearchItem.TabIndex = 78;
            this.panelsearchItem.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(20, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 23);
            this.label15.TabIndex = 69;
            this.label15.Text = "Item Description";
            // 
            // textBoxFindItemDescription
            // 
            this.textBoxFindItemDescription.BackColor = System.Drawing.Color.Black;
            this.textBoxFindItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFindItemDescription.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindItemDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxFindItemDescription.Location = new System.Drawing.Point(168, 18);
            this.textBoxFindItemDescription.Name = "textBoxFindItemDescription";
            this.textBoxFindItemDescription.Size = new System.Drawing.Size(524, 33);
            this.textBoxFindItemDescription.TabIndex = 68;
            this.textBoxFindItemDescription.TabStop = false;
            this.textBoxFindItemDescription.TextChanged += new System.EventHandler(this.textBoxFindItemDescription_TextChanged);
            this.textBoxFindItemDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFindItemDescription_KeyDown);
            // 
            // dgvFindItem
            // 
            this.dgvFindItem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            this.dgvFindItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFindItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFindItem.BackgroundColor = System.Drawing.Color.Black;
            this.dgvFindItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFindItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFindItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFindItemCode,
            this.colFindItemName,
            this.colFindSellingPrice,
            this.colFindStock});
            this.dgvFindItem.GridColor = System.Drawing.Color.Black;
            this.dgvFindItem.Location = new System.Drawing.Point(25, 84);
            this.dgvFindItem.MultiSelect = false;
            this.dgvFindItem.Name = "dgvFindItem";
            this.dgvFindItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            this.dgvFindItem.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFindItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindItem.ShowEditingIcon = false;
            this.dgvFindItem.Size = new System.Drawing.Size(675, 275);
            this.dgvFindItem.TabIndex = 2;
            this.dgvFindItem.TabStop = false;
            this.dgvFindItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFindItem_KeyDown);
            // 
            // colFindItemCode
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.colFindItemCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFindItemCode.HeaderText = "Item Code";
            this.colFindItemCode.Name = "colFindItemCode";
            // 
            // colFindItemName
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Violet;
            this.colFindItemName.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFindItemName.HeaderText = "Item Description";
            this.colFindItemName.Name = "colFindItemName";
            this.colFindItemName.Width = 250;
            // 
            // colFindSellingPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.colFindSellingPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFindSellingPrice.HeaderText = "Part No";
            this.colFindSellingPrice.Name = "colFindSellingPrice";
            this.colFindSellingPrice.Width = 250;
            // 
            // colFindStock
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.HotPink;
            this.colFindStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFindStock.HeaderText = "Stock Available";
            this.colFindStock.Name = "colFindStock";
            this.colFindStock.Visible = false;
            this.colFindStock.Width = 150;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colDescription,
            this.colPartNo,
            this.colPackDate,
            this.colLabelCount});
            this.dgvList.Location = new System.Drawing.Point(7, 97);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(724, 297);
            this.dgvList.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Location = new System.Drawing.Point(7, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(630, 17);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(535, 17);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(439, 17);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 33);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxNoOfLabels);
            this.groupBox3.Controls.Add(this.labelDescription);
            this.groupBox3.Controls.Add(this.txtCode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 82);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(521, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "No Of Labels";
            // 
            // textBoxNoOfLabels
            // 
            this.textBoxNoOfLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoOfLabels.Location = new System.Drawing.Point(642, 31);
            this.textBoxNoOfLabels.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNoOfLabels.Name = "textBoxNoOfLabels";
            this.textBoxNoOfLabels.Size = new System.Drawing.Size(76, 26);
            this.textBoxNoOfLabels.TabIndex = 26;
            this.textBoxNoOfLabels.TabStop = false;
            this.textBoxNoOfLabels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNoOfLabels_KeyDown);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Black;
            this.labelDescription.Location = new System.Drawing.Point(159, 31);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 20);
            this.labelDescription.TabIndex = 25;
            this.labelDescription.Text = "Description";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(61, 28);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(90, 26);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Code";
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 200;
            // 
            // colPartNo
            // 
            this.colPartNo.HeaderText = "PartNo";
            this.colPartNo.Name = "colPartNo";
            // 
            // colPackDate
            // 
            this.colPackDate.HeaderText = "Pack Date";
            this.colPackDate.Name = "colPackDate";
            // 
            // colLabelCount
            // 
            this.colLabelCount.HeaderText = "No Of Labels";
            this.colLabelCount.Name = "colLabelCount";
            // 
            // frmBajajBarcodePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(744, 456);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmBajajBarcodePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAJAJ - Barcode Printing";
            this.Load += new System.EventHandler(this.frmBarcodePrint_Load);
            this.groupBox1.ResumeLayout(false);
            this.panelsearchItem.ResumeLayout(false);
            this.panelsearchItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoOfLabels;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelsearchItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxFindItemDescription;
        private System.Windows.Forms.DataGridView dgvFindItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFindItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFindItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFindSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFindStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLabelCount;
    }
}