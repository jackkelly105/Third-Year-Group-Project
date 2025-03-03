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
    public partial class formSales : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formSales(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formSales_Load(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Model.GetAllMeals();
            Model.GetAllDrinks();
            foreach (IMeals meal in Model.MealsList)
            {
                listBox5.Items.Add(meal.DishName);
            }
            foreach (IDrinks drink in Model.DrinksList)
            {
                listBox4.Items.Add(drink.DrinkName);
            }
            foreach (IDrinks drink in Model.DrinksList)
            {
                if (drink.DrinkName == "Pint of Guinness")
                    listBox1.Items.Add(drink.DrinkName);
                if (drink.DrinkName == "Pint of Heinekin")
                    listBox1.Items.Add(drink.DrinkName);
                if (drink.DrinkName == "Pint of Budweiser")
                    listBox1.Items.Add(drink.DrinkName);
            }
            foreach (IMeals meal in Model.MealsList)
            {
                
                if (meal.DishName == "Fish and Chips")
                    listBox2.Items.Add(meal.DishName);
                if (meal.DishName == "Chicken Curry and Chips")
                    listBox2.Items.Add(meal.DishName);
                if (meal.DishName == "10oz Sirloin Steak")
                    listBox2.Items.Add(meal.DishName);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to add!");
            }
            else
            {
                listBox3.Items.Add(listBox5.SelectedItem);
            }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to add!");
            }
            else
            {
                listBox3.Items.Add(listBox4.SelectedItem);
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
           
            DateTime date = DateTime.Now;
            decimal total = 0.0m;
            int madeBy = Model.CurrentUser.UserID;

            List<String> names = listBox3.Items.Cast<String>().ToList();
            List<IOrder_has_Drinks> orderDrinks = new List<IOrder_has_Drinks>();
            List<IOrder_has_Meals> orderMeals = new List<IOrder_has_Meals>();
            Model.GetAllDrinks();
            Model.GetAllMeals();
            bool drinkFound = false;
            bool mealFound = false;
            foreach (String name in names)
            {
                foreach (IMeals meal in Model.MealsList)
                {
                    if (name.Equals(meal.DishName))
                    {
                        total += Convert.ToDecimal(meal.Price);
                        foreach (IOrder_has_Meals orderMeal in orderMeals)
                        {
                            if (orderMeal.DishID == meal.DishID)
                            {
                                mealFound = true;
                                orderMeal.Quantity = orderMeal.Quantity + 1;
                            }
                        }
                        if (!mealFound)
                        {
                            IOrder_has_Meals newOrderMeal = new Order_has_Meals(0, meal.DishID, 1, "Not Ready");
                            orderMeals.Add(newOrderMeal);
                        }
                        mealFound = false;
                    }
                }
                foreach (IDrinks drink in Model.DrinksList)
                {
                    if (name.Equals(drink.DrinkName))
                    {
                        total += drink.DrinkPrice;
                        foreach (IOrder_has_Drinks orderDrink in orderDrinks)
                        {
                            if (orderDrink.DrinkID == drink.DrinkID)
                            {
                                drinkFound = true;
                                orderDrink.Quantity = orderDrink.Quantity + 1;
                            }
                        }
                        if (!drinkFound)
                        {
                            IOrder_has_Drinks newOrderDrink = new Order_has_Drinks(0, drink.DrinkID, 1, "Not Ready");
                            orderDrinks.Add(newOrderDrink);
                        }
                        drinkFound = false;
                    }
                }
            }
            Model.GetAllBistroOrders();
            List<IBistroOrders> oldOrders = Model.BistroOrdersList;
            if (Model.createBistroOrder(date, total, madeBy, "", false))
            {
                Model.GetAllBistroOrders();
                foreach (IBistroOrders order in Model.BistroOrdersList)
                {
                    if (!oldOrders.Contains(order))
                    {
                        foreach (IOrder_has_Drinks orderDrink in orderDrinks)
                        {
                            orderDrink.OrderID = order.OrderID;
                            Model.createOrderDrink(orderDrink.OrderID, orderDrink.DrinkID, orderDrink.Quantity, orderDrink.Status);
                        }
                        foreach (IOrder_has_Meals orderMeal in orderMeals)
                        {
                            orderMeal.OrderID = order.OrderID;
                            Model.createOrderMeal(orderMeal.OrderID, orderMeal.DishID, orderMeal.Quantity, orderMeal.Status);
                        }
                    }
                }
                MessageBox.Show("The sale has been made");
            }
            else
            {
                MessageBox.Show("Sale was unsuccessful");
            }
           
        }

        private void viewOrdersBTN_Click(object sender, EventArgs e)
        {
            ViewOrdersBarStaff form = new ViewOrdersBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnCFood_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to add!");
            }
            else
            {
                listBox3.Items.Add(listBox2.SelectedItem);
            }
        }

        private void btnCDrink_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to add!");
            }
            else
            {
                listBox3.Items.Add(listBox1.SelectedItem);
            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            formViewReceipt form = new formViewReceipt(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
