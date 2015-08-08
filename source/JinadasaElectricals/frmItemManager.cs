using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BarcodeGenarator.DataAccess;
using System.Data.Linq;

using System.Net;

namespace  BarcodeGenarator
{
    public partial class frmItemManager : Form
    {
        dcInventoryDataContext dc = new dcInventoryDataContext();
        List<DisplayItem> _displayItemList = new List<DisplayItem>();
        Item _item = new Item();

        public frmItemManager()
        {
            InitializeComponent();
        }

        #region ---- Private Methds----
        private bool IsValidScreen()
        {
            bool isValid = false;

            if (string.IsNullOrEmpty(txt_Item_Code.Text.Trim()))
            {
                MessageBox.Show("Item Code can't be empty");
                txt_Item_Code.Focus();
                return isValid;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Description can't be empty");
                txtDescription.Focus();
                return isValid;
            }

            if (string.IsNullOrEmpty(cmbItemCategry.Text.Trim()))
            {
                MessageBox.Show("Itemcategory can't be empty");
                cmbItemCategry.Focus();
                return isValid;
            }

            
           
           
           
            return true;
        }


         private bool IsValidScreenEdit()
        {
            bool isValidedit = false;

           
             
             return true;
        }


        private void AssignProperties()
        {
            _item.ItemCode = txt_Item_Code.Text.Trim();
            _item.ItemDescription = txtDescription.Text.Trim();

            _item.PartNo = textBoxBillName.Text.Trim();
            _item.PackDate = txtPackDate.Text;

            if (cmbItemCategry.SelectedIndex > -1)
            {
                ItemCategory itmCategory = (from c in dc.ItemCategories where c.ItemCategoryID == (cmbItemCategry.SelectedItem as ItemCategory).ItemCategoryID select c).SingleOrDefault<ItemCategory>();
                _item.ItemCategory = itmCategory;
            }
           

          
            #region Common Properties
            _item.ModifiedBy  = LoggedClientProfile.UserProfileID;
            _item.IsDeleted = false;
            _item.DateModified = System.DateTime.Now;
            _item.PCModified = LoggedClientProfile.UserPCID;
            #endregion
        }

        private void ClearScreen()
        {
            groupBoxItem.Text = "New Item";
            txt_Item_Code.Text=string.Empty;
            txt_Item_Code.Enabled = true;
            txtDescription.Text=string.Empty;
            textBoxBillName.Text = string.Empty;
            cmbItemCategry.Text = string.Empty;
            txtPackDate.Text = string.Empty;
            dc = new dcInventoryDataContext();
            _item = new Item();
            GetNextItemCodeNumber();
        }

        private void GetItemInfo(int itemID)
        {
            ClearScreen();

            _item = (from c in dc.GetTable<Item>() where c.ItemID == itemID select c).SingleOrDefault<Item>();
            if (_item != null)
            {
                txt_Item_Code.Text = _item.ItemCode;
                txt_Item_Code.Enabled = false;
                txtDescription.Text = _item.ItemDescription;
                txtPackDate.Text = string.Empty;


                textBoxBillName.Text = _item.PartNo;
           
             

                if (_item.ItemCategory != null)
                {
                    cmbItemCategry.SelectedText = _item.ItemCategory.ItemCategoryDescription;
                }
              
                groupBoxItem.Text = "Edit Item";
                txtDescription.Focus();
            
            }
            else
            {
                return;
            }
        }
        private void GetItemInfoByCode(string itemCode)
        {
            ClearScreen();

            _item = (from c in dc.GetTable<Item>() where c.ItemCode == itemCode select c).SingleOrDefault<Item>();
            if (_item != null)
            {
                txt_Item_Code.Text = _item.ItemCode;
                txt_Item_Code.Enabled = false;
                txtDescription.Text = _item.ItemDescription;
                textBoxBillName.Text = _item.PartNo;
                txtPackDate.Text = _item.PackDate;


                if (_item.ItemCategory != null)
                {
                    cmbItemCategry.SelectedText = _item.ItemCategory.ItemCategoryDescription;
                }
              
                groupBoxItem.Text = "Edit Item";
                txtDescription.Focus();

            }
            else
            {
                _item = new Item();
                return;
            }
        }
        private void LoadCombos()
        {
            cmbItemCategry.Items.Clear();
            cmbShowItemCategory.Items.Clear();

            var itemCatgoryList = (from c in dc.GetTable<ItemCategory>() where c.IsDeleted == false select c).ToList<ItemCategory>();

            foreach (ItemCategory itemCat in itemCatgoryList)
            {
                cmbItemCategry.Items.Add(itemCat);
                cmbItemCategry.DisplayMember = "ItemCategoryDescription";
                cmbItemCategry.ValueMember = "ItemCategoryID";

                cmbShowItemCategory.Items.Add(itemCat);
                cmbShowItemCategory.DisplayMember = "ItemCategoryDescription";
                cmbShowItemCategory.ValueMember = "ItemCategoryID";

            }


            var itemList = (from i in dc.GetTable<Item>() where i.IsDeleted == false select i).ToList<Item>();

            foreach (Item serchitem in itemList)
            {
                DisplayItem displayItem = new DisplayItem();
                displayItem.ItemID = serchitem.ItemID;
                displayItem.Name = serchitem.ItemCode + "-" + serchitem.ItemDescription;
                _displayItemList.Add(displayItem); 
            }

        

        }

        private void GetNextItemCodeNumber()
        {
            int x = 0;
            try
            {

            
           x = (from c in dc.Items where c.IsDeleted == false select Convert.ToInt32(c.ItemCode)).Max()+1;

            }
            catch (Exception)
            {

                x = 1;
            }
            txt_Item_Code.Text = x.ToString();
        }

        #endregion

        private void frmItemManager_Load(object sender, EventArgs e)
        {
            LoadCombos();
            ClearScreen();
            txt_Item_Code.Focus();
            txt_Item_Code.Select();

        }
       
        private void cmbItemcode_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    DisplayItem displayItem = cmbItemcode_Edit.SelectedItem as DisplayItem;

            //    if (displayItem == null) return;
            //    GetItemInfo(displayItem.ItemID); 
            //}
        }

        private void cmbItemcode_Edit_TextChanged(object sender, EventArgs e)
        {
            //DisplayItem displayItem = cmbItemcode_Edit.SelectedItem as DisplayItem;

            //if (displayItem == null) return;
            //GetItemInfo(displayItem.ItemID); 
        }

        private void cmbItemcode_Edit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv_ItemList.Rows.Clear();
            var itemSearchList = from m in dc.Items where m.IsDeleted == false select m;

            if (cmbShowItemCategory.SelectedItem!=null)
            {
                itemSearchList = itemSearchList.Where(m => m.ItemCategory.Equals(cmbShowItemCategory.SelectedItem));
            }

            if (!string.IsNullOrEmpty(txtShowDescription.Text))
            {
                itemSearchList = itemSearchList.Where(m => m.ItemCode.StartsWith(txtShowDescription.Text.Trim()) || m.ItemDescription.StartsWith(txtShowDescription.Text.Trim()));
            }
            foreach (Item obj in itemSearchList)
            {
                dgv_ItemList.Rows.Add(obj.ItemCode, obj.ItemDescription, obj.PartNo, obj.ItemID);
            }
            dgv_ItemList.Rows[0].Selected = true;
            dgv_ItemList.Focus();
        }

        private void dgv_ItemList_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                int id = 0;
                if (dgv_ItemList.SelectedRows.Count > 0)
                {
                    id = int.Parse(dgv_ItemList.SelectedRows[0].Cells["colItemID"].Value.ToString());

                    GetItemInfo(id);
                    tabitemmanager.SelectedTab = tabitemmanager.TabPages[0];
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txt_Item_Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
                txtDescription.SelectAll();
                GetItemInfoByCode(txt_Item_Code.Text.Trim()); 
            }
        }

        private void buttonSearchItem_Click(object sender, EventArgs e)
        {
            tabitemmanager.SelectedTab = tabitemmanager.TabPages[1];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidScreen())
            {
                try
                {

                    Table<Item> iteminsert = dc.GetTable<Item>();

                    bool hasPriceChanged = false;
                    bool isNewItem = true;
                    decimal existingCostPrice = 0;
                    decimal existingSellingPrice = 0;
                    decimal newCostPrice = 0;
                    decimal newSellingPrice = 0;

                    //if (_item.ItemID != 0)
                    //{
                    //    isNewItem = false;
                    //    existingCostPrice = _item.CostPrice.Value;
                    //    existingSellingPrice = _item.SellingPrice.Value;
                    //}
                    AssignProperties();

                    //newCostPrice = _item.CostPrice.Value;
                    //newSellingPrice = _item.SellingPrice.Value;
                    //if (existingCostPrice != newCostPrice || existingSellingPrice != newSellingPrice)
                    //{
                    //    hasPriceChanged = true;
                    //}

                    //if (isNewItem)
                    //{
                    //    _item.CreatedBy =  LoggedClientProfile.UserProfileID;
                    //    _item.DateCreated = System.DateTime.Now;
                    //    _item.PCCreated = LoggedClientProfile.UserPCID;
                    //    iteminsert.InsertOnSubmit(_item);

                    //    //cmbItemcode_Edit.Focus();
                    //    txt_Item_Code.Focus();

                    //}

                    dc.SubmitChanges();

                    System.Collections.Generic.List<string> mailList = null;
                    string receipient = string.Empty;
                    string mailBody = string.Empty;
                    string subject = string.Empty;

                   
                    MessageBox.Show("Successfully Saved.");
                    ClearScreen();
                    LoadCombos();
                    //cmbItemcode_Edit.SelectedItem = null;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearScreen();
            //cmbItemcode_Edit.SelectedItem = null;
            txt_Item_Code.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearScreen();
            _item = new Item();

        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxBillName.Focus();
            }
        }

      

      

      


  

       

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            cmbShowItemCategory.SelectedItem = null;
            txtShowDescription.Text = string.Empty;
            dgv_ItemList.Rows.Clear();
        }

        private void cmbShowItemCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtShowDescription.Focus();
            }
        }

        private void txtShowDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchItem_Click(sender, e);
            }
        }

        private void dgv_ItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int id = 0;
                    if (dgv_ItemList.SelectedRows.Count > 0)
                    {
                        id = int.Parse(dgv_ItemList.SelectedRows[0].Cells["colItemID"].Value.ToString());

                        GetItemInfo(id);
                        tabitemmanager.SelectedTab = tabitemmanager.TabPages[0];

                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void txt_Sell_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
         && !char.IsDigit(e.KeyChar)
         && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_Cost_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
         && !char.IsDigit(e.KeyChar)
         && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtPiece_of_Parent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
         && !char.IsDigit(e.KeyChar)
         && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_Reorder_level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
         && !char.IsDigit(e.KeyChar)
         && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxBillName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbItemCategry.Focus();
            }
        }

      

        private void textBoxMaxDiscPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
      && !char.IsDigit(e.KeyChar)
      && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxMaxDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
      && !char.IsDigit(e.KeyChar)
      && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxMaxDiscountAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

       

      

        private void cmbItemCategry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPackDate.Focus();
            }
        }

        private void txtPackDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }

    public class DisplayItem
    {
        private int itemID;

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
