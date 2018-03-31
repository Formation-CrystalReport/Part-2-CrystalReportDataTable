using CrystalReportDataTable.CrystalReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReportDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Declare DataTable
            DataTable Product = new DataTable();
            Product.Columns.Add("SINo", typeof(int));
            Product.Columns.Add("Name", typeof(string));
            Product.Columns.Add("Price", typeof(decimal));
            Product.Columns.Add("Count", typeof(long));

            //Insert test rows
            Product.Rows.Add(1, "Pen", 20, 250);
            Product.Rows.Add(2, "Pencil", 10, 150);
            Product.Rows.Add(3, "Note Book", 60, 550);
            Product.Rows.Add(4, "Bag", 700, 750);
            Product.Rows.Add(5, "Umbrella", 50, 500);

            crpProduct crp = new crpProduct();

            crp.Database.Tables["Product"].SetDataSource(Product);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = crp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
