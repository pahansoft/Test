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
using System.Management;
using System.Net;
using System.Net.NetworkInformation;

namespace  BarcodeGenarator
{
    public partial class frmRegisterPC : Form
    {
        dcInventoryDataContext dc = new dcInventoryDataContext();
        PcRegistration _registeredPC = null;


        public frmRegisterPC()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Table<PcRegistration> registeredPCList = dc.GetTable<PcRegistration>();
                AssignProperties();

                if (_registeredPC.PcRegistrationID == 0)
                {
                    _registeredPC.CreatedBy = LoggedClientProfile.UserProfileID;
                    _registeredPC.DateCreated = System.DateTime.Now;
                    registeredPCList.InsertOnSubmit(_registeredPC);
                }

                dc.SubmitChanges();
                MessageBox.Show("Successfully Saved. Please Restart Applicaion");
                Application.Restart();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void AssignProperties()
        {
            _registeredPC.Description = txtPCName.Text;

            #region Common Properties
            _registeredPC.ModifiedBy = LoggedClientProfile.UserProfileID;
            _registeredPC.DateModified = System.DateTime.Now;
            #endregion
        }

        private void frmGreeting_Load(object sender, EventArgs e)
        {
            LoadDefaults();
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
                txtPCName.Text = _registeredPC.Description;
              
            }
            _registeredPC.MachineCode = machingCode;

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

        private bool IsValidScreen()
        {
            bool isValid = false;

            if (string.IsNullOrEmpty(txtPCName.Text.Trim()))
            {
                MessageBox.Show("PC Name can't be empty");
                txtPCName.Focus();
                return isValid;
            }

            

            return true;
        }
    }
}
