using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeltOperation3
{
    public partial class MetalTypePanel : UserControl
    {
        
        public MetalTypePanel()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void cTarLowMtb_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cTarLowMtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                //this.ActiveControl.SelectNextControl(this.ActiveControl, true, true, true, true);
                SendKeys.Send("{TAB}");
            }
        }

    }
}
