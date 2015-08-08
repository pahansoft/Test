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
    public partial class frmBarcodePrint : Form
    {
        dcInventoryDataContext dc = new dcInventoryDataContext();
        List<Item> itemList = null;
        Item _item = null;
        List<Item> _foundItems = null;
        public frmBarcodePrint()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _item = (from c in dc.Items where c.IsDeleted == false && c.ItemCode == txtCode.Text.Trim() select c).SingleOrDefault<Item>();

                if (_item != null)
                {
                    labelDescription.Text = _item.ItemDescription;

                    textBoxNoOfLabels.Focus();
                    textBoxNoOfLabels.SelectAll();

                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                panelsearchItem.Visible = true;
                textBoxFindItemDescription.Focus();
                ClearSearchedItem();
                LoadFoundItems();
                //DisableControlsForNew();
            }
        }
        private void ClearSearchedItem()
        {
            textBoxFindItemDescription.Text = string.Empty;
            dgvFindItem.Rows.Clear();
        }
        private void frmBarcodePrint_Load(object sender, EventArgs e)
        {
            txtCode.Focus();
            itemList = new List<Item>();
          
        }

        private void textBoxNoOfLabels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNoOfLabels.Text != string.Empty)
            {
                //Item _item = new Item();
                int noOfLabels=0;
                //if ((int.Parse(textBoxNoOfLabels.Text) % 1) != 0)
                //{
                //    int modAmount = int.Parse(textBoxNoOfLabels.Text) % 1;
                //    noOfLabels= int.Parse(textBoxNoOfLabels.Text) + (1 - modAmount);
                //}
                //else
                //{
                //    noOfLabels = int.Parse(textBoxNoOfLabels.Text);
                //}

                noOfLabels = int.Parse(textBoxNoOfLabels.Text);

                _item.ItemCode = _item.ItemCode;
                _item.ItemDescription = _item.ItemDescription;

                ////item.Index = itemList.Count + 1;
                _item.PartNo = _item.PartNo;
             
                _item.ItemDescription = _item.ItemDescription;
               
                _item.DateCreated = DateTime.Now;

                itemList.Add(_item);

                dgvList.Rows.Add(_item.ItemCode, _item.ItemDescription,_item.PartNo, noOfLabels.ToString());

                txtCode.Text = string.Empty;
                txtCode.Focus();
                textBoxNoOfLabels.Text = string.Empty;
                labelDescription.Text = string.Empty;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = string.Empty;
            labelDescription.Text = string.Empty;
            textBoxNoOfLabels.Text = string.Empty;
            dgvList.Rows.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BarCodeDs ds = new BarCodeDs();
            if (itemList.Count > 0)
            {
                foreach (DataGridViewRow  dgvRow in dgvList.Rows)
                {
                    if (dgvRow.Cells["colLabelCount"].Value != null)
                    {
                        int labelCount = 0;
                        labelCount = int.Parse(dgvRow.Cells["colLabelCount"].Value.ToString());

                        for (int i = 0; i < labelCount; i++)
                        {
                            DataRow row = ds.Tables[0].NewRow();
                            row["ItemCode"] = dgvRow.Cells["colCode"].Value.ToString();
                            row["PartNo"] = dgvRow.Cells["colPartNo"].Value.ToString();
                            row["Description"] = dgvRow.Cells["colDescription"].Value.ToString();
                          
                            ds.Tables[0].Rows.Add(row);
                        }
                       
                    }
                }

                frmReportViewer frm = new frmReportViewer();
                frm.LoadBarcodeReport(ds);
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                
            }
        }

        private void textBoxFindItemDescription_TextChanged(object sender, EventArgs e)
        {
            LoadFoundItems();
        }

        private void LoadFoundItems()
        {
            _foundItems = (from c in dc.Items where c.IsDeleted == false select c).ToList<Item>();

            if (textBoxFindItemDescription.Text.Trim() != string.Empty)
            {
                _foundItems = _foundItems.Where(c => c.ItemDescription.ToUpper().StartsWith(textBoxFindItemDescription.Text.Trim().ToUpper())).ToList<Item>();

            }

            dgvFindItem.Rows.Clear();
            foreach (Item item in _foundItems)
            {
                dgvFindItem.Rows.Add(item.ItemCode, item.ItemDescription, item.PartNo, "");
            }

        }

        private void dgvFindItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvFindItem.SelectedRows.Count > 0)
                {
                    //EnableControlsToNewEntry();
                    txtCode.Text = dgvFindItem.Rows[dgvFindItem.SelectedRows[0].Index].Cells["colFindItemCode"].Value.ToString();
                    txtCode_KeyDown(sender, e);
                    _foundItems = null;
                    panelsearchItem.Visible = false;
                }
            }
        }

        private void textBoxFindItemDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //EnableControlsToNewEntry();
                panelsearchItem.Visible = false;
                ClearSearchedItem();
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (_foundItems.Count > 1)
                {
                    if (dgvFindItem.SelectedRows[0].Index > 0)
                    {
                        dgvFindItem.Rows[dgvFindItem.SelectedRows[0].Index - 1].Selected = true;
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (_foundItems.Count > 1)
                {
                    if (dgvFindItem.SelectedRows[0].Index < _foundItems.Count - 1)
                    {
                        dgvFindItem.Rows[dgvFindItem.SelectedRows[0].Index + 1].Selected = true;
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //EnableControlsToNewEntry();
                txtCode.Text = dgvFindItem.Rows[dgvFindItem.SelectedRows[0].Index].Cells["colFindItemCode"].Value.ToString();
                txtCode_KeyDown(sender, e);
                _foundItems = null;
                panelsearchItem.Visible = false;
            }
        }
    }
}
