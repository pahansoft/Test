using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BarcodeGenarator
{
    public partial class frmBaseBlue : Form
    {
        protected string FormName = "Base";
        protected ComboBox FocusComboBox = null;
        protected MaskedTextBox FocusMaskedTextBox = null;
        protected TextBox FocusNormalTextBox = null;

        public frmBaseBlue()
        {
            InitializeComponent();
        }
        private void lblCaption_Paint(object sender, PaintEventArgs e)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(2.0F, 6.0F);

            using (LinearGradientBrush brush =
                   new LinearGradientBrush(e.Graphics.ClipBounds, Color.AliceBlue,
                   Color.SkyBlue, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, e.Graphics.ClipBounds);
            }
            e.Graphics.DrawString(lblCaption.Text, drawFont, drawBrush, drawPoint);
            if (FocusComboBox != null)
                FocusComboBox.Focus();
            else if (FocusMaskedTextBox != null)
                FocusMaskedTextBox.Focus();
            else if (FocusNormalTextBox != null)
                FocusNormalTextBox.Focus();
            
        }
        private void frmBaseBlue_Load(object sender, EventArgs e)
        {
            this.lblCaption.Text = FormName;
        }
    }
}
