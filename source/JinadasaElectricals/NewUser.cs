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
using System.Security.Cryptography;
namespace  BarcodeGenarator
{
    public partial class NewUser : Form
    {
        dcInventoryDataContext dc = new dcInventoryDataContext();
        UserProfile _userProfile = new UserProfile();
        public NewUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Full Name Can not be empty");
                textBoxFullName.Focus();
                return;
            }
            if (textBoxPassword.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Password Can not be empty");
                textBoxPassword.Focus();
                return;
            }

            if (!textBoxPassword.Text.Trim().Equals(textBoxConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("Password and Confirm Password Not Matching");
                textBoxPassword.Focus();
                return;
            }

            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please Select Type");
                comboBoxType.Focus();
                return;
            }

            string hash = string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = Util.GetMd5Hash(md5Hash, textBoxPassword.Text.Trim());
            }

            _userProfile.userId = textBoxUserName.Text.Trim();
            _userProfile.Password = hash;
            _userProfile.PCCreated = LoggedClientProfile.UserPCID;
            _userProfile.PCModified = LoggedClientProfile.UserPCID;
            _userProfile.ModifiedBy = LoggedClientProfile.UserProfileID;
            _userProfile.CreatedBy = LoggedClientProfile.UserProfileID;
            _userProfile.DateCreated = System.DateTime.Now;
            _userProfile.DateModified = System.DateTime.Now;
            _userProfile.IsDeleted = false;
            _userProfile.FullName = textBoxFullName.Text;
            if (comboBoxType.Text == "User")
            {
                _userProfile.IsManger = false;
            }
            else if (comboBoxType.Text == "Manager")
            {
                _userProfile.IsManger = true;
            }

            if (_userProfile.UserProfileId == 0)
            {
                dc.UserProfiles.InsertOnSubmit(_userProfile);
            }
            else
            {
                if ((MessageBox.Show("Are you sure to reset password?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No))
                {
                    MessageBox.Show("User Updation Canceled.");
                    return;
                }
            }
            dc.SubmitChanges();
            MessageBox.Show("Successfully Updated");
            buttonReset_Click(sender, e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void NewUser_Load(object sender, EventArgs e)
        {
           
        }

     
        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxConfirmPassword.Focus();
                textBoxConfirmPassword.SelectAll();
            }
        }

        private void textBoxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxType.Focus();
                comboBoxType.SelectAll();
            }
        }

        private void comboBoxType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dc = new dcInventoryDataContext();
            _userProfile = new UserProfile();
            textBoxUserName.Enabled = true;
            textBoxUserName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPassword.Text = string.Empty;
            comboBoxType.SelectedIndex = -1;
            textBoxFullName.Text = string.Empty;
            textBoxFullName.Focus();
        }

        private void textBoxFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxUserName.Focus();
            }
        }
    }
}
