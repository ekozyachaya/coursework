namespace kozyachaya_coursework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultComboBox = new System.Windows.Forms.ComboBox();
            this.countButton = new System.Windows.Forms.Button();
            this.caloriesNormTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.waterNormTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calorieTrackingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вес(кг):";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.Location = new System.Drawing.Point(71, 71);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(99, 21);
            this.weightTextBox.TabIndex = 1;
            
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightTextBox.Location = new System.Drawing.Point(318, 71);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(110, 21);
            this.heightTextBox.TabIndex = 3;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(315, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите рост(см):";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageTextBox.Location = new System.Drawing.Point(558, 71);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(107, 21);
            this.ageTextBox.TabIndex = 5;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(555, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите возраст:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской ",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(185, 148);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 23);
            this.genderComboBox.TabIndex = 6;
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderComboBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(182, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(434, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите желаемый результат";
            // 
            // resultComboBox
            // 
            this.resultComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultComboBox.FormattingEnabled = true;
            this.resultComboBox.Items.AddRange(new object[] {
            "Снижение веса",
            "Поддержание веса",
            "Набор веса"});
            this.resultComboBox.Location = new System.Drawing.Point(437, 148);
            this.resultComboBox.Name = "resultComboBox";
            this.resultComboBox.Size = new System.Drawing.Size(191, 23);
            this.resultComboBox.TabIndex = 8;
            this.resultComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultComboBox_KeyPress);
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.Location = new System.Drawing.Point(287, 325);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(160, 38);
            this.countButton.TabIndex = 10;
            this.countButton.Text = "Рассчитать";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // caloriesNormTextBox
            // 
            this.caloriesNormTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesNormTextBox.Location = new System.Drawing.Point(262, 244);
            this.caloriesNormTextBox.Name = "caloriesNormTextBox";
            this.caloriesNormTextBox.ReadOnly = true;
            this.caloriesNormTextBox.Size = new System.Drawing.Size(221, 22);
            this.caloriesNormTextBox.TabIndex = 12;
            this.caloriesNormTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(259, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Норма потребления калорий в сутки:";
            // 
            // waterNormTextBox
            // 
            this.waterNormTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterNormTextBox.Location = new System.Drawing.Point(262, 296);
            this.waterNormTextBox.Name = "waterNormTextBox";
            this.waterNormTextBox.ReadOnly = true;
            this.waterNormTextBox.Size = new System.Drawing.Size(227, 22);
            this.waterNormTextBox.TabIndex = 14;
            this.waterNormTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(259, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Норма потребления воды в сутки(мл):";
            // 
            // calorieTrackingButton
            // 
            this.calorieTrackingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calorieTrackingButton.Location = new System.Drawing.Point(287, 369);
            this.calorieTrackingButton.Name = "calorieTrackingButton";
            this.calorieTrackingButton.Size = new System.Drawing.Size(160, 38);
            this.calorieTrackingButton.TabIndex = 15;
            this.calorieTrackingButton.Text = "Учет калорий";
            this.calorieTrackingButton.UseVisualStyleBackColor = true;
            this.calorieTrackingButton.Visible = false;
            this.calorieTrackingButton.Click += new System.EventHandler(this.calorieTrackingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calorieTrackingButton);
            this.Controls.Add(this.waterNormTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.caloriesNormTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Счетчик калорий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox resultComboBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox caloriesNormTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox waterNormTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calorieTrackingButton;
    }
}

