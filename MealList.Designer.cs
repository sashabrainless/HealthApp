namespace HealthApp
{
    partial class MealList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealList));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.додатиСтравуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиСтравуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиСтравуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізуватиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealListBox = new System.Windows.Forms.ListBox();
            this.addMeal = new System.Windows.Forms.Button();
            this.editMeal = new System.Windows.Forms.Button();
            this.removeMeal = new System.Windows.Forms.Button();
            this.analyzeData = new System.Windows.Forms.Button();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.sugarTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carbohydratesTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.kcalTextBox = new System.Windows.Forms.TextBox();
            this.portionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.search = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиСтравуToolStripMenuItem,
            this.редагуватиСтравуToolStripMenuItem,
            this.видалитиСтравуToolStripMenuItem,
            this.аналізуватиДаніToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(734, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // додатиСтравуToolStripMenuItem
            // 
            this.додатиСтравуToolStripMenuItem.Name = "додатиСтравуToolStripMenuItem";
            this.додатиСтравуToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.додатиСтравуToolStripMenuItem.Text = "Додати страву";
            this.додатиСтравуToolStripMenuItem.Click += new System.EventHandler(this.додатиСтравуToolStripMenuItem_Click);
            // 
            // редагуватиСтравуToolStripMenuItem
            // 
            this.редагуватиСтравуToolStripMenuItem.Name = "редагуватиСтравуToolStripMenuItem";
            this.редагуватиСтравуToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.редагуватиСтравуToolStripMenuItem.Text = "Редагувати страву";
            this.редагуватиСтравуToolStripMenuItem.Click += new System.EventHandler(this.редагуватиСтравуToolStripMenuItem_Click);
            // 
            // видалитиСтравуToolStripMenuItem
            // 
            this.видалитиСтравуToolStripMenuItem.Name = "видалитиСтравуToolStripMenuItem";
            this.видалитиСтравуToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.видалитиСтравуToolStripMenuItem.Text = "Видалити страву";
            this.видалитиСтравуToolStripMenuItem.Click += new System.EventHandler(this.видалитиСтравуToolStripMenuItem_Click);
            // 
            // аналізуватиДаніToolStripMenuItem
            // 
            this.аналізуватиДаніToolStripMenuItem.Name = "аналізуватиДаніToolStripMenuItem";
            this.аналізуватиДаніToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.аналізуватиДаніToolStripMenuItem.Text = "Аналізувати дані";
            this.аналізуватиДаніToolStripMenuItem.Click += new System.EventHandler(this.аналізуватиДаніToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // mealListBox
            // 
            this.mealListBox.FormattingEnabled = true;
            this.mealListBox.ItemHeight = 16;
            this.mealListBox.Location = new System.Drawing.Point(26, 54);
            this.mealListBox.Name = "mealListBox";
            this.mealListBox.Size = new System.Drawing.Size(412, 212);
            this.mealListBox.TabIndex = 1;
            this.mealListBox.SelectedIndexChanged += new System.EventHandler(this.mealListBox_SelectedIndexChanged);
            // 
            // addMeal
            // 
            this.addMeal.BackColor = System.Drawing.Color.LightGray;
            this.addMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMeal.Location = new System.Drawing.Point(462, 54);
            this.addMeal.Name = "addMeal";
            this.addMeal.Size = new System.Drawing.Size(246, 33);
            this.addMeal.TabIndex = 2;
            this.addMeal.Text = "Додати страву";
            this.addMeal.UseVisualStyleBackColor = false;
            this.addMeal.Click += new System.EventHandler(this.addMeal_Click);
            // 
            // editMeal
            // 
            this.editMeal.BackColor = System.Drawing.Color.LightGray;
            this.editMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMeal.Location = new System.Drawing.Point(462, 116);
            this.editMeal.Name = "editMeal";
            this.editMeal.Size = new System.Drawing.Size(246, 33);
            this.editMeal.TabIndex = 3;
            this.editMeal.Text = "Редагувати страву";
            this.editMeal.UseVisualStyleBackColor = false;
            this.editMeal.Click += new System.EventHandler(this.editMeal_Click);
            // 
            // removeMeal
            // 
            this.removeMeal.BackColor = System.Drawing.Color.LightGray;
            this.removeMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMeal.Location = new System.Drawing.Point(462, 175);
            this.removeMeal.Name = "removeMeal";
            this.removeMeal.Size = new System.Drawing.Size(246, 33);
            this.removeMeal.TabIndex = 4;
            this.removeMeal.Text = "Видалити страву";
            this.removeMeal.UseVisualStyleBackColor = false;
            this.removeMeal.Click += new System.EventHandler(this.removeMeal_Click);
            // 
            // analyzeData
            // 
            this.analyzeData.BackColor = System.Drawing.Color.LightGray;
            this.analyzeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeData.Location = new System.Drawing.Point(462, 233);
            this.analyzeData.Name = "analyzeData";
            this.analyzeData.Size = new System.Drawing.Size(246, 33);
            this.analyzeData.TabIndex = 5;
            this.analyzeData.Text = "Аналізувати дані";
            this.analyzeData.UseVisualStyleBackColor = false;
            this.analyzeData.Click += new System.EventHandler(this.analyzeData_Click);
            // 
            // saltTextBox
            // 
            this.saltTextBox.Location = new System.Drawing.Point(122, 375);
            this.saltTextBox.Multiline = true;
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(130, 24);
            this.saltTextBox.TabIndex = 52;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(578, 331);
            this.proteinTextBox.Multiline = true;
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(130, 24);
            this.proteinTextBox.TabIndex = 51;
            // 
            // sugarTextBox
            // 
            this.sugarTextBox.Location = new System.Drawing.Point(349, 331);
            this.sugarTextBox.Multiline = true;
            this.sugarTextBox.Name = "sugarTextBox";
            this.sugarTextBox.Size = new System.Drawing.Size(130, 24);
            this.sugarTextBox.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Сіль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Білки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Цукор";
            // 
            // carbohydratesTextBox
            // 
            this.carbohydratesTextBox.Location = new System.Drawing.Point(122, 331);
            this.carbohydratesTextBox.Multiline = true;
            this.carbohydratesTextBox.Name = "carbohydratesTextBox";
            this.carbohydratesTextBox.Size = new System.Drawing.Size(130, 24);
            this.carbohydratesTextBox.TabIndex = 46;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(578, 287);
            this.fatTextBox.Multiline = true;
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(130, 24);
            this.fatTextBox.TabIndex = 45;
            // 
            // kcalTextBox
            // 
            this.kcalTextBox.Location = new System.Drawing.Point(349, 287);
            this.kcalTextBox.Multiline = true;
            this.kcalTextBox.Name = "kcalTextBox";
            this.kcalTextBox.Size = new System.Drawing.Size(130, 24);
            this.kcalTextBox.TabIndex = 44;
            // 
            // portionTextBox
            // 
            this.portionTextBox.Location = new System.Drawing.Point(122, 287);
            this.portionTextBox.Multiline = true;
            this.portionTextBox.Name = "portionTextBox";
            this.portionTextBox.Size = new System.Drawing.Size(130, 24);
            this.portionTextBox.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Вуглеводи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Жири";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ккал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Порція, г";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Дата";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(349, 375);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(130, 24);
            this.dateTextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Пошук за датою";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(152, 425);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 63;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(390, 424);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 24);
            this.search.TabIndex = 65;
            this.search.Text = "Знайти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // MealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 473);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saltTextBox);
            this.Controls.Add(this.proteinTextBox);
            this.Controls.Add(this.sugarTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.carbohydratesTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.kcalTextBox);
            this.Controls.Add(this.portionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.analyzeData);
            this.Controls.Add(this.removeMeal);
            this.Controls.Add(this.editMeal);
            this.Controls.Add(this.addMeal);
            this.Controls.Add(this.mealListBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(752, 520);
            this.Name = "MealList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд харчування: Додаток для контролю здоров\'я";
            this.Load += new System.EventHandler(this.MealList_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem додатиСтравуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиСтравуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиСтравуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ListBox mealListBox;
        private System.Windows.Forms.Button addMeal;
        private System.Windows.Forms.Button editMeal;
        private System.Windows.Forms.Button removeMeal;
        private System.Windows.Forms.Button analyzeData;
        private System.Windows.Forms.TextBox saltTextBox;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.TextBox sugarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox carbohydratesTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox kcalTextBox;
        private System.Windows.Forms.TextBox portionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.ToolStripMenuItem аналізуватиДаніToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button search;
    }
}