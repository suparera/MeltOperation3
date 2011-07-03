using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeltOperation3
{
    public partial class Form1 : Form
    {
        private NICDBEntities nicdbContext;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nicdbContext = new NICDBEntities();
            var metalTypeQuery = from m in nicdbContext.MetalTypes
                                 orderby m.id
                                 select m;
            try
            {
                // Bind the ComboBox control to the query, 
                // which is executed during data binding.
                // To prevent the query from being executed multiple times during binding, 
                // it is recommended to bind controls to the result of the Execute method. 

                metalTypeBindingSource.DataSource = ((ObjectQuery)metalTypeQuery).Execute(MergeOption.AppendOnly);
                metalTypePanel1.bindingSource1.DataSource = ((ObjectQuery)metalTypeQuery).Execute(MergeOption.AppendOnly);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void metalTypeTabPage_Click(object sender, EventArgs e)
        {

        }

    }
}
