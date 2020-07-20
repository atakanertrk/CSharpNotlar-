using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
        // Display way 1: 
        private void messageBoxDemoButton_Click(object sender, EventArgs e)
        {
            // this is benefits of deleagetes. we can use ShoppingCartModel with ConsoleUI or WinFormUI.
            decimal total = cart.GenerateTotal(SubTotalAlert, CalculateLevelDiscount, PrintOutDiscountAlert);
            MessageBox.Show($"Total is : {Math.Round(total)}");
        }
        // Display way 2: inline created methods
        // (message) => {  }) this is how to pass that operation. { } is means empty method
        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal((subTotal) => subTotalTextBox.Text = $"{Math.Round(subTotal, 2)}",
                (products,subTotal) => subTotal - (products.Count() * 2),
                (message) => {  });
            totalTextBox.Text = $"{Math.Round(total,2)}";
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }
        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal is {Math.Round(subTotal, 2)}");
        }

        private decimal CalculateLevelDiscount(List<ProductModel> products, decimal subTotal)
        {
            return Math.Round((subTotal - products.Count()), 2);
        }

    }
}
