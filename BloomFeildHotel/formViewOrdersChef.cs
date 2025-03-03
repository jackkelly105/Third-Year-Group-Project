﻿using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloomFeildHotel
{
    public partial class formViewOrdersChef : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewOrdersChef(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formViewOrdersChef_Load(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            Model.GetAllMeals();
            Model.GetAllDrinks();
            Model.GetAllBistroOrders();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach(IBistroOrders orders in Model.BistroOrdersList)
            {
                foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                {
                   if(orders.OrderID == mealorders.OrderID)
                    {
                        foreach (IMeals meal in Model.MealsList)
                        {
                            if(mealorders.DishID == meal.DishID)
                            {
                                listBoxOrders.Items.Add(string.Format("{0} | Order ID: {1} | Dish ID: {2} | Quantity: {3} | Order Time: {4} | Status: {5}", mealorders.OrderID, mealorders.DishID, meal.DishName, mealorders.Quantity, orders.OrderDate, mealorders.Status));
                            }
                        }
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formChef form = new formChef(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            formChef form = new formChef(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnChangeOrderStatus_Click(object sender, EventArgs e)
        {
            if(listBoxOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order!");
            }
            else
            {
                Model.GetAllMeals();
                Model.GetAllBistroOrders();
                Model.GetAllOrderMeals();
                IBistroOrders order = new BistroOrders();
                foreach (IBistroOrders orders in Model.BistroOrdersList)
                {
                    foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                    {
                        if (orders.OrderID == mealorders.OrderID)
                        {
                            foreach (IMeals meal in Model.MealsList)
                            {
                                if (mealorders.DishID == meal.DishID)
                                {
                                    if(listBoxOrders.SelectedItem.ToString() == string.Format("{0} | Order ID: {1} | Dish ID: {2} | Quantity: {3} | Order Time: {4} | Status: {5}", mealorders.OrderID, mealorders.DishID, meal.DishName, mealorders.Quantity, orders.OrderDate, mealorders.Status))
                                    {
                                        order = orders;
                                    }
                                }
                            }
                        }

                    }
                }
                formManageOrder f1 = new formManageOrder(fc, Model, order);
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formChangeOrderStatus form = new formChangeOrderStatus(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
