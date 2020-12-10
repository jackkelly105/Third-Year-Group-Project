﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;

namespace BloomFeildHotel
{
    public partial class formViewMonthlyReports : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewMonthlyReports(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formViewMonthlyReports_Load(object sender, EventArgs e)
        {
            
            dateTimePicker1.MaxDate = DateTime.Today;
            Model.GetAllMonthlyReports();
            foreach(IMonthlyReport report in Model.MonthlyReportsList)
            {
                String str = report.ReportID.ToString() + "\t";
                str += report.Date.ToString();
                lbReports.Items.Add(str);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lbReports.Items.Clear();
            tbReportID.Text = "";
            tbDate.Text = "";
            tbNumReservations.Text = "";
            tbReservationIncome.Text = "";
            tbNumSales.Text = "";
            tbRestaurantIncome.Text = "";
            tbOrders.Text = "";
            tbExpenses.Text = "";
            Model.GetAllMonthlyReports();
            foreach (IMonthlyReport report in Model.MonthlyReportsList)
            {
                String str = report.ReportID.ToString() + "\t";
                str += report.Date.ToString("dd/MM/yyyy");
                lbReports.Items.Add(str);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbReports.Items.Clear();
            tbReportID.Text = "";
            tbDate.Text = "";
            tbNumReservations.Text = "";
            tbReservationIncome.Text = "";
            tbNumSales.Text = "";
            tbRestaurantIncome.Text = "";
            tbOrders.Text = "";
            tbExpenses.Text = "";
            Model.GetAllMonthlyReports();
            foreach (IMonthlyReport report in Model.MonthlyReportsList)
            {
                if(report.Date == dateTimePicker1.Value.Date)
                {
                    String str = report.ReportID.ToString() + "\t";
                    str += report.Date.ToString("dd/MM/yyyy");
                    lbReports.Items.Add(str);
                }
            }
        }

        private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.GetAllMonthlyReports();
            string report = lbReports.SelectedItem.ToString();
            string sep = "\t";
            string[] splitContent = report.Split(sep.ToCharArray());
            tbReportID.Text = "";
            tbDate.Text = "";
            tbNumReservations.Text = "";
            tbReservationIncome.Text = "";
            tbNumSales.Text = "";
            tbRestaurantIncome.Text = "";
            tbOrders.Text = "";
            tbExpenses.Text = "";
            foreach (IMonthlyReport r in Model.MonthlyReportsList)
            {
                if (splitContent[0] == r.ReportID.ToString())
                {
                    tbReportID.Text = r.ReportID.ToString();
                    tbDate.Text = r.Date.ToString("dd/MM/yyyy");
                    tbNumReservations.Text = r.Reservations.ToString();
                    tbReservationIncome.Text = "€" + r.ReservationIncome.ToString();
                    tbNumSales.Text = r.Sales.ToString();
                    tbRestaurantIncome.Text = "€" + r.SalesIncome.ToString();
                    tbOrders.Text = r.StockOrders.ToString();
                    tbExpenses.Text = "€" + r.StockExpenses.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
