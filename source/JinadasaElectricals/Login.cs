using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using BarcodeGenarator.DataAccess;
using System.Net.NetworkInformation;

namespace  BarcodeGenarator
{
    public partial class Login : Form
    {
        PcRegistration _registeredPC = null;
        dcInventoryDataContext dc = new dcInventoryDataContext();

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string hash = string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = Util.GetMd5Hash(md5Hash, textBoxPassword.Text.Trim()); 
            }
           
            UserProfile matchedProfile = (from c in dc.GetTable<UserProfile>()
                                      where c.userId == textBoxUserName.Text.Trim() && c.Password == hash
                                          select c).SingleOrDefault();
            if (matchedProfile != null)
            {
                this.Hide();

                LoggedClientProfile.UserProfileID = matchedProfile.UserProfileId;
                LoggedClientProfile.UserName = matchedProfile.userId;
                LoggedClientProfile.UserFullName = matchedProfile.FullName;
                LoggedClientProfile.IsManager = matchedProfile.IsManger;
                string machingCode = getMacAddress();

                _registeredPC = (from c in dc.PcRegistrations where c.MachineCode == machingCode select c).SingleOrDefault<PcRegistration>();

                if (_registeredPC == null)
                {
                    frmRegisterPC frmPC = new frmRegisterPC();
                    frmPC.Show();
                }
                else
                {
                    LoggedClientProfile.UserPCID = _registeredPC.PcRegistrationID;
                    LoggedClientProfile.UserPCName = _registeredPC.Description;
                    LoggedClientProfile.LoginSuccess = true;
                    frmMainManu frm = new frmMainManu();
                    frm.Show();
                    
                }
    
            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password");
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
                return;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void LoadDefaults()
        {
            string machingCode = getMacAddress();


            _registeredPC = (from c in dc.PcRegistrations where c.MachineCode == machingCode select c).SingleOrDefault<PcRegistration>();

            if (_registeredPC == null)
            {
                _registeredPC = new PcRegistration();
            }
            else
            {

            }

        }

        private string getMacAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
