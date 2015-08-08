namespace BarcodeGenarator
{
    partial class frmMainManu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainManu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSale = new System.Windows.Forms.ToolStripButton();
            this.buttonRecipeOrder = new System.Windows.Forms.ToolStripButton();
            this.buttonPurchasing = new System.Windows.Forms.ToolStripButton();
            this.buttonSales = new System.Windows.Forms.ToolStripButton();
            this.buttonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSale,
            this.toolStripButton1,
            this.buttonRecipeOrder,
            this.buttonPurchasing,
            this.buttonSales,
            this.buttonClose});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1386, 88);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSale
            // 
            this.btnSale.AutoSize = false;
            this.btnSale.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.Black;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSale.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(85, 85);
            this.btnSale.Text = "Item";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // buttonRecipeOrder
            // 
            this.buttonRecipeOrder.AutoSize = false;
            this.buttonRecipeOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecipeOrder.Image")));
            this.buttonRecipeOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRecipeOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRecipeOrder.Name = "buttonRecipeOrder";
            this.buttonRecipeOrder.Size = new System.Drawing.Size(85, 85);
            this.buttonRecipeOrder.Text = "HERO";
            this.buttonRecipeOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRecipeOrder.Click += new System.EventHandler(this.buttonRecipeOrder_Click);
            // 
            // buttonPurchasing
            // 
            this.buttonPurchasing.AutoSize = false;
            this.buttonPurchasing.Image = ((System.Drawing.Image)(resources.GetObject("buttonPurchasing.Image")));
            this.buttonPurchasing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonPurchasing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPurchasing.Name = "buttonPurchasing";
            this.buttonPurchasing.Size = new System.Drawing.Size(85, 85);
            this.buttonPurchasing.Text = "BAJAJ";
            this.buttonPurchasing.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.buttonPurchasing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPurchasing.Click += new System.EventHandler(this.buttonPurchasing_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.AutoSize = false;
            this.buttonSales.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.ForeColor = System.Drawing.Color.Black;
            this.buttonSales.Image = ((System.Drawing.Image)(resources.GetObject("buttonSales.Image")));
            this.buttonSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSales.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(85, 85);
            this.buttonSales.Text = "TVS";
            this.buttonSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = false;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(85, 85);
            this.buttonClose.Text = "Exit";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = global::BarcodeGenarator.Properties.Resources.Deposit;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 85);
            this.toolStripButton1.Text = "Item Report";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmMainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMainManu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMainManu";
            this.Load += new System.EventHandler(this.frmMainManu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSale;
        private System.Windows.Forms.ToolStripButton buttonRecipeOrder;
        private System.Windows.Forms.ToolStripButton buttonPurchasing;
        private System.Windows.Forms.ToolStripButton buttonSales;
        private System.Windows.Forms.ToolStripButton buttonClose;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}