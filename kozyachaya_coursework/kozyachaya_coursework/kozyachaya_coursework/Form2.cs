using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kozyachaya_coursework
{
    public partial class Form2 : Form
    {
        private ProductInfo productInfo = new ProductInfo();
        private int remainingCalories = Form1.CaloriesNorm;
        private StringBuilder stringBuilder = new StringBuilder();

        public Form2()
        {
            InitializeComponent();
            remainingCaloriesTextBox.Text = remainingCalories.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String productName = productNameTextBox.Text;
            int productWeight = 0;
            int caloriesOfProduct = 0;

            if (productWeightTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!");
            }
            else
            {
                productWeight = Convert.ToInt32(productWeightTextBox.Text);
            }

            foreach (KeyValuePair<string, int> keyValue in productInfo.ProductsInfoList)
            {
                if (keyValue.Key.Equals(productName))
                {
                    caloriesOfProduct = (keyValue.Value * productWeight) / 100;
                }
            }

            if (caloriesOfProduct == 0)
            {
                MessageBox.Show("Пожалуйста введите продукт из списка", "Ошибка!");
            }

            remainingCalories -= caloriesOfProduct;
            stringBuilder.Append(productName + ", " + caloriesOfProduct + " калорий" + "\r\n");

            eatenProductsTextBox.Text = stringBuilder.ToString();
            remainingCaloriesTextBox.Text = remainingCalories.ToString();
        }

        private void productsInfoButton_Click(object sender, EventArgs e)
        {
            StringBuilder productsStringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, int> keyValue in productInfo.ProductsInfoList)
            {
                productsStringBuilder.Append(keyValue.Key + ", " + keyValue.Value + " калорий" + "\r\n");
            }

            MessageBox.Show(productsStringBuilder.ToString(), "Список доступных продуктов");
        }

        private void productNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void productWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
