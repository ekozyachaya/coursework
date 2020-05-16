namespace kozyachaya_coursework
{
    partial class Form2
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productWeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.productsInfoButton = new System.Windows.Forms.Button();
            this.remainingCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eatenProductsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameTextBox.Location = new System.Drawing.Point(99, 59);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(171, 21);
            this.productNameTextBox.TabIndex = 3;
            this.productNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productNameTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название продукта:";
            // 
            // productWeightTextBox
            // 
            this.productWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productWeightTextBox.Location = new System.Drawing.Point(99, 167);
            this.productWeightTextBox.Name = "productWeightTextBox";
            this.productWeightTextBox.Size = new System.Drawing.Size(162, 21);
            this.productWeightTextBox.TabIndex = 5;
            this.productWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productWeightTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите массу продукта(г):\r\n";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(99, 260);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(162, 38);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить продукт";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productsInfoButton
            // 
            this.productsInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsInfoButton.Location = new System.Drawing.Point(99, 304);
            this.productsInfoButton.Name = "productsInfoButton";
            this.productsInfoButton.Size = new System.Drawing.Size(162, 38);
            this.productsInfoButton.TabIndex = 12;
            this.productsInfoButton.Text = "Информация о продуктах";
            this.productsInfoButton.UseVisualStyleBackColor = true;
            this.productsInfoButton.Click += new System.EventHandler(this.productsInfoButton_Click);
            // 
            // remainingCaloriesTextBox
            // 
            this.remainingCaloriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainingCaloriesTextBox.Location = new System.Drawing.Point(544, 417);
            this.remainingCaloriesTextBox.Name = "remainingCaloriesTextBox";
            this.remainingCaloriesTextBox.ReadOnly = true;
            this.remainingCaloriesTextBox.Size = new System.Drawing.Size(221, 21);
            this.remainingCaloriesTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(541, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Осталось употребить калорий:";
            // 
            // eatenProductsTextBox
            // 
            this.eatenProductsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatenProductsTextBox.Location = new System.Drawing.Point(544, 59);
            this.eatenProductsTextBox.Multiline = true;
            this.eatenProductsTextBox.Name = "eatenProductsTextBox";
            this.eatenProductsTextBox.ReadOnly = true;
            this.eatenProductsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eatenProductsTextBox.Size = new System.Drawing.Size(221, 283);
            this.eatenProductsTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(541, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Употребленные продукты за сегодня\r\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eatenProductsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remainingCaloriesTextBox);
            this.Controls.Add(this.productsInfoButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productWeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Учет калорий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productWeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button productsInfoButton;
        private System.Windows.Forms.TextBox remainingCaloriesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eatenProductsTextBox;
        private System.Windows.Forms.Label label4;
    }
}