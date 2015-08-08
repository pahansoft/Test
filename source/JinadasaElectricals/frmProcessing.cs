using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace  BarcodeGenarator
{
    public partial class frmProcessing : Form
    {
        private int count = 0;
        public frmProcessing()
        {
            InitializeComponent();
        }
        private void DisplayImage()
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point();
            this.Controls.Add(pictureBox1);
            //pictureBox1.Load("Path to a image to display");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                pictureBox1.Image = null;
                count = 0;
            }
           
        }
    }
}
