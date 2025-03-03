﻿namespace BloomFeildHotel
{
    partial class formManageOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDrinks = new System.Windows.Forms.ListBox();
            this.btnViewAllDrinks = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.txtDrinkSearch = new System.Windows.Forms.TextBox();
            this.btnDrinkSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbOrderItems = new System.Windows.Forms.ListBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.bdAddItem = new System.Windows.Forms.GroupBox();
            this.lbMeals = new System.Windows.Forms.ListBox();
            this.btnViewAllMeals = new System.Windows.Forms.Button();
            this.btnMealSearch = new System.Windows.Forms.Button();
            this.txtMealSearch = new System.Windows.Forms.TextBox();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bdAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 88);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDrinks);
            this.groupBox1.Controls.Add(this.btnViewAllDrinks);
            this.groupBox1.Controls.Add(this.btnAddDrink);
            this.groupBox1.Controls.Add(this.txtDrinkSearch);
            this.groupBox1.Controls.Add(this.btnDrinkSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(759, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 226);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Drink to Order";
            // 
            // lbDrinks
            // 
            this.lbDrinks.FormattingEnabled = true;
            this.lbDrinks.ItemHeight = 16;
            this.lbDrinks.Location = new System.Drawing.Point(10, 52);
            this.lbDrinks.Name = "lbDrinks";
            this.lbDrinks.Size = new System.Drawing.Size(232, 164);
            this.lbDrinks.TabIndex = 42;
            // 
            // btnViewAllDrinks
            // 
            this.btnViewAllDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllDrinks.Location = new System.Drawing.Point(259, 52);
            this.btnViewAllDrinks.Name = "btnViewAllDrinks";
            this.btnViewAllDrinks.Size = new System.Drawing.Size(98, 31);
            this.btnViewAllDrinks.TabIndex = 42;
            this.btnViewAllDrinks.Text = "View All";
            this.btnViewAllDrinks.UseVisualStyleBackColor = true;
            this.btnViewAllDrinks.Click += new System.EventHandler(this.btnViewAllDrinks_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddDrink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrink.ForeColor = System.Drawing.Color.White;
            this.btnAddDrink.Location = new System.Drawing.Point(259, 186);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(98, 33);
            this.btnAddDrink.TabIndex = 31;
            this.btnAddDrink.Text = "Add to Order";
            this.btnAddDrink.UseVisualStyleBackColor = false;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // txtDrinkSearch
            // 
            this.txtDrinkSearch.Location = new System.Drawing.Point(91, 23);
            this.txtDrinkSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrinkSearch.Name = "txtDrinkSearch";
            this.txtDrinkSearch.Size = new System.Drawing.Size(151, 22);
            this.txtDrinkSearch.TabIndex = 32;
            // 
            // btnDrinkSearch
            // 
            this.btnDrinkSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDrinkSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDrinkSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinkSearch.ForeColor = System.Drawing.Color.White;
            this.btnDrinkSearch.Location = new System.Drawing.Point(259, 11);
            this.btnDrinkSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrinkSearch.Name = "btnDrinkSearch";
            this.btnDrinkSearch.Size = new System.Drawing.Size(98, 28);
            this.btnDrinkSearch.TabIndex = 31;
            this.btnDrinkSearch.Text = "Search";
            this.btnDrinkSearch.UseVisualStyleBackColor = false;
            this.btnDrinkSearch.Click += new System.EventHandler(this.btnDrinkSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Drink Name:";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.tbNotes);
            this.gbOrder.Controls.Add(this.label8);
            this.gbOrder.Controls.Add(this.label4);
            this.gbOrder.Controls.Add(this.rbNo);
            this.gbOrder.Controls.Add(this.rbYes);
            this.gbOrder.Controls.Add(this.label3);
            this.gbOrder.Controls.Add(this.btnUpdate);
            this.gbOrder.Controls.Add(this.btnDelete);
            this.gbOrder.Controls.Add(this.pictureBox1);
            this.gbOrder.Controls.Add(this.tbTotal);
            this.gbOrder.Controls.Add(this.btnRemove);
            this.gbOrder.Controls.Add(this.btnClear);
            this.gbOrder.Controls.Add(this.label5);
            this.gbOrder.Controls.Add(this.lbOrderItems);
            this.gbOrder.Controls.Add(this.tbOrderID);
            this.gbOrder.Controls.Add(this.label2);
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.Location = new System.Drawing.Point(127, 107);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(585, 458);
            this.gbOrder.TabIndex = 42;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order Details";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(426, 130);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(137, 96);
            this.tbNotes.TabIndex = 43;
            this.tbNotes.Text = "";
            this.tbNotes.TextChanged += new System.EventHandler(this.tbNotes_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Order Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Order Contents";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(524, 232);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(44, 20);
            this.rbNo.TabIndex = 40;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(449, 230);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(50, 20);
            this.rbYes.TabIndex = 39;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Order Completed:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(489, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 33);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(309, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 33);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloomFeildHotel.Properties.Resources.diet;
            this.pictureBox1.Location = new System.Drawing.Point(362, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 134);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(426, 92);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(137, 22);
            this.tbTotal.TabIndex = 34;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(37, 386);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 29);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(178, 386);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 29);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Order Total:";
            // 
            // lbOrderItems
            // 
            this.lbOrderItems.FormattingEnabled = true;
            this.lbOrderItems.ItemHeight = 16;
            this.lbOrderItems.Location = new System.Drawing.Point(37, 45);
            this.lbOrderItems.Name = "lbOrderItems";
            this.lbOrderItems.Size = new System.Drawing.Size(247, 324);
            this.lbOrderItems.TabIndex = 23;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(426, 37);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(137, 22);
            this.tbOrderID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order ID:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 568);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 33);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // bdAddItem
            // 
            this.bdAddItem.Controls.Add(this.lbMeals);
            this.bdAddItem.Controls.Add(this.btnViewAllMeals);
            this.bdAddItem.Controls.Add(this.btnMealSearch);
            this.bdAddItem.Controls.Add(this.txtMealSearch);
            this.bdAddItem.Controls.Add(this.btnAddMeal);
            this.bdAddItem.Controls.Add(this.label7);
            this.bdAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdAddItem.Location = new System.Drawing.Point(759, 107);
            this.bdAddItem.Name = "bdAddItem";
            this.bdAddItem.Size = new System.Drawing.Size(382, 226);
            this.bdAddItem.TabIndex = 43;
            this.bdAddItem.TabStop = false;
            this.bdAddItem.Text = "Add Food to Order";
            // 
            // lbMeals
            // 
            this.lbMeals.FormattingEnabled = true;
            this.lbMeals.ItemHeight = 16;
            this.lbMeals.Location = new System.Drawing.Point(10, 51);
            this.lbMeals.Name = "lbMeals";
            this.lbMeals.Size = new System.Drawing.Size(232, 164);
            this.lbMeals.TabIndex = 33;
            // 
            // btnViewAllMeals
            // 
            this.btnViewAllMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllMeals.Location = new System.Drawing.Point(259, 56);
            this.btnViewAllMeals.Name = "btnViewAllMeals";
            this.btnViewAllMeals.Size = new System.Drawing.Size(104, 31);
            this.btnViewAllMeals.TabIndex = 41;
            this.btnViewAllMeals.Text = "View All";
            this.btnViewAllMeals.UseVisualStyleBackColor = true;
            this.btnViewAllMeals.Click += new System.EventHandler(this.btnViewAllMeals_Click);
            // 
            // btnMealSearch
            // 
            this.btnMealSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnMealSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnMealSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealSearch.ForeColor = System.Drawing.Color.White;
            this.btnMealSearch.Location = new System.Drawing.Point(259, 20);
            this.btnMealSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnMealSearch.Name = "btnMealSearch";
            this.btnMealSearch.Size = new System.Drawing.Size(103, 27);
            this.btnMealSearch.TabIndex = 32;
            this.btnMealSearch.Text = "Search";
            this.btnMealSearch.UseVisualStyleBackColor = false;
            this.btnMealSearch.Click += new System.EventHandler(this.btnMealSearch_Click);
            // 
            // txtMealSearch
            // 
            this.txtMealSearch.Location = new System.Drawing.Point(91, 22);
            this.txtMealSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtMealSearch.Name = "txtMealSearch";
            this.txtMealSearch.Size = new System.Drawing.Size(151, 22);
            this.txtMealSearch.TabIndex = 27;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddMeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddMeal.Location = new System.Drawing.Point(259, 182);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(103, 33);
            this.btnAddMeal.TabIndex = 30;
            this.btnAddMeal.Text = "Add to Order";
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Dish Name:";
            // 
            // formManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1261, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bdAddItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageOrder";
            this.Text = "formManageOrder";
            this.Load += new System.EventHandler(this.formManageOrder_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bdAddItem.ResumeLayout(false);
            this.bdAddItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDrinks;
        private System.Windows.Forms.Button btnViewAllDrinks;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.TextBox txtDrinkSearch;
        private System.Windows.Forms.Button btnDrinkSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbOrderItems;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox bdAddItem;
        private System.Windows.Forms.ListBox lbMeals;
        private System.Windows.Forms.Button btnViewAllMeals;
        private System.Windows.Forms.Button btnMealSearch;
        private System.Windows.Forms.TextBox txtMealSearch;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbNotes;
        private System.Windows.Forms.Label label8;
    }
}