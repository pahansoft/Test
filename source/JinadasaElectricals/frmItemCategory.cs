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

namespace BarcodeGenarator
{
    public partial class frmItemCategory : Form
    {
        dcInventoryDataContext dc = new dcInventoryDataContext();
        ItemCategory _itemCategory = new ItemCategory();

        public frmItemCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemCategory_Load(object sender, EventArgs e)
        {
            txtCode.Focus();

        }

        #region ---- Private Methds----
        private bool IsValidScreen()
        {
            bool isValid = false;

            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("Code can't be empty");
                txtCode.Focus();
                return isValid;
            }

            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Description can't be empty");
                txtDescription.Focus();
                return isValid;
            }

            return true;
        }

        private void AssignProperties()
        {
            _itemCategory.ItemCategoryCode = txtCode.Text.Trim();
            _itemCategory.ItemCategoryDescription = txtDescription.Text.Trim();

            #region Common Properties
            _itemCategory.ModifiedBy = LoggedClientProfile.UserProfileID;
            _itemCategory.DateModified = System.DateTime.Now;
            _itemCategory.PCModified = LoggedClientProfile.UserPCID;
            #endregion
        }

        private void ClearScreen()
        {
            txtCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
            _itemCategory = new ItemCategory();
            txtCode.Focus();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidScreen())
            {
                try
                {
                    Table<ItemCategory> itemCategories = dc.GetTable<ItemCategory>();        
                    AssignProperties();

                    if (_itemCategory.ItemCategoryID == 0)
                    {
                        _itemCategory.CreatedBy = LoggedClientProfile.UserProfileID;
                        _itemCategory.DateCreated = System.DateTime.Now;
                        _itemCategory.PCCreated = LoggedClientProfile.UserPCID;
                        _itemCategory.IsDeleted = false;
                        itemCategories.InsertOnSubmit(_itemCategory);
                    }

                    dc.SubmitChanges();
                    MessageBox.Show("Successfully Saved.");
                    dc = new dcInventoryDataContext();
                    ClearScreen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
                txtDescription.SelectAll();
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            txtSrchDescription.Focus();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Clear();
            var itemCategorySearchList = from c in dc.ItemCategories where c.IsDeleted==false select c;

            if (!string.IsNullOrEmpty(txtSrchDescription.Text.Trim()))
            {
                itemCategorySearchList = itemCategorySearchList.Where(c => c.ItemCategoryCode.StartsWith(txtSrchDescription.Text.Trim()) || c.ItemCategoryDescription.StartsWith(txtSrchDescription.Text.Trim()));
            }

            foreach (ItemCategory obj in itemCategorySearchList)
            {
                dgvList.Rows.Add(obj.ItemCategoryCode, obj.ItemCategoryDescription, obj.ItemCategoryID.ToString());
            }
            dgvList.Rows[0].Selected = true;
            dgvList.Focus();

        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int id = 0;
            if (dgvList.SelectedRows.Count > 0)
            {
               id=int.Parse( dgvList.SelectedRows[0].Cells[2].Value.ToString());

               _itemCategory = (from c in dc.GetTable<ItemCategory>() where c.ItemCategoryID == id select c).SingleOrDefault<ItemCategory>();

               if (_itemCategory != null)
               {
                   txtCode.Text = _itemCategory.ItemCategoryCode;
                   txtDescription.Text = _itemCategory.ItemCategoryDescription;

                   tabControl1.SelectedTab = tabControl1.TabPages[0];
                   txtCode.Focus();
                   txtCode.SelectAll();
               }
            }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int id = 0;
                    if (dgvList.SelectedRows.Count > 0)
                    {
                        id = int.Parse(dgvList.SelectedRows[0].Cells[2].Value.ToString());

                        _itemCategory = (from c in dc.GetTable<ItemCategory>() where c.ItemCategoryID == id select c).SingleOrDefault<ItemCategory>();

                        if (_itemCategory != null)
                        {
                            txtCode.Text = _itemCategory.ItemCategoryCode;
                            txtDescription.Text = _itemCategory.ItemCategoryDescription;

                            tabControl1.SelectedTab = tabControl1.TabPages[0];
                            txtCode.Focus();
                            txtCode.SelectAll();
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

       
    }
}
