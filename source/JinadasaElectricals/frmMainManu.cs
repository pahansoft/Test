using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeGenarator
{
    public partial class frmMainManu : Form
    {
        public frmMainManu()
        {
            InitializeComponent();
        }

      
        #region Private Methods
        private void OpenChiledForm(Form frm)
        {
            frmProcessing status = new frmProcessing();
            status.Show();


            // frm.MdiParent = this;
            frm.Show();
            status.Close();
        }


        #endregion

      
       
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool IsFormOpen(Type formType)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                {
                    //MessageBox.Show("Form Already Open");
                    isOpen = true;
                    form.Activate();
                    return isOpen;
                }
            //else
            //{
            //    return isOpen;
            //}
            return isOpen;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show(

          "Do you want Close Application?",

          "Barcode Reports Managment System",

           MessageBoxButtons.YesNo,

           MessageBoxIcon.Question,

           MessageBoxDefaultButton.Button2))
            {

                e.Cancel = true;

            }
        }


     

        private void frmMainManu_Load(object sender, EventArgs e)
        {
          
        }        

      

        private void InnerSubMenuItemCategory_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmItemCategory)))
            {
                OpenChiledForm(new frmItemCategory());
            }
        }

        private void InnerSubMenuItemFeeding_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmItemManager)))
            {
                OpenChiledForm(new frmItemManager());
            }
        }

      

        private void InnerSubMenuNewUser_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(NewUser)))
            {
                OpenChiledForm(new NewUser());
            }
        }


        private void InnerSubMenuRegisterPC_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmRegisterPC)))
            {
                OpenChiledForm(new frmRegisterPC());
            }
        }

    

        private void InnerSubMenuItemReport_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.LoadItemReport();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

      

       

        private void InnerSubMenuBarcodePrinting_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmBarcodePrint)))
            {
                OpenChiledForm(new frmBarcodePrint());
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmItemManager)))
            {
                OpenChiledForm(new frmItemManager());
            }
        }

        private void buttonPurchasing_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmBajajBarcodePrint)))
            {
                OpenChiledForm(new frmBajajBarcodePrint());
            }
        }

        private void buttonRecipeOrder_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmHeroBarcodePrint)))
            {
                OpenChiledForm(new frmHeroBarcodePrint());
            }
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmTVSBarcodePrint)))
            {
                OpenChiledForm(new frmTVSBarcodePrint());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.LoadItemReport();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

     
    }
}
