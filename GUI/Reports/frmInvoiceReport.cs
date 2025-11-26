using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCoffee.GUI.Reports
{
    public partial class frmInvoiceReport : Form
    {
        private int orderID;
        public frmInvoiceReport(int id)
        {
            InitializeComponent();
            orderID = id;
        }

        private void frmInvoiceReport_Load(object sender, EventArgs e)
        {
            invoice.SetParameterValue("pOrderID", orderID);
            rptViewer.ReportSource = invoice;
        }
    }
}
