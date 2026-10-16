namespace HealthApp
{
    partial class ActivityList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityList));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.додатиАктивністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиАктивністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиАктивністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізуватиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeData = new System.Windows.Forms.Button();
            this.removeActivity = new System.Windows.Forms.Button();
            this.editActivity = new System.Windows.Forms.Button();
            this.addActivity = new System.Windows.Forms.Button();
            this.activityListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.caloriesPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caloriesBurnedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиАктивністьToolStripMenuItem,
            this.редагуватиАктивністьToolStripMenuItem,
            this.видалитиАктивністьToolStripMenuItem,
            this.аналізуватиДаніToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(752, 28);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // додатиАктивністьToolStripMenuItem
            // 
            this.додатиАктивністьToolStripMenuItem.Name = "додатиАктивністьToolStripMenuItem";
            this.додатиАктивністьToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.додатиАктивністьToolStripMenuItem.Text = "Додати активність";
            this.додатиАктивністьToolStripMenuItem.Click += new System.EventHandler(this.додатиАктивністьToolStripMenuItem_Click);
            // 
            // редагуватиАктивністьToolStripMenuItem
            // 
            this.редагуватиАктивністьToolStripMenuItem.Name = "редагуватиАктивністьToolStripMenuItem";
            this.редагуватиАктивністьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.редагуватиАктивністьToolStripMenuItem.Text = "Редагувати активність";
            this.редагуватиАктивністьToolStripMenuItem.Click += new System.EventHandler(this.редагуватиАктивністьToolStripMenuItem_Click);
            // 
            // видалитиАктивністьToolStripMenuItem
            // 
            this.видалитиАктивністьToolStripMenuItem.Name = "видалитиАктивністьToolStripMenuItem";
            this.видалитиАктивністьToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.видалитиАктивністьToolStripMenuItem.Text = "Видалити активність";
            this.видалитиАктивністьToolStripMenuItem.Click += new System.EventHandler(this.видалитиАктивністьToolStripMenuItem_Click);
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
            // analyzeData
            // 
            this.analyzeData.BackColor = System.Drawing.Color.LightGray;
            this.analyzeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeData.Location = new System.Drawing.Point(476, 234);
            this.analyzeData.Name = "analyzeData";
            this.analyzeData.Size = new System.Drawing.Size(246, 33);
            this.analyzeData.TabIndex = 5;
            this.analyzeData.Text = "Аналізувати дані";
            this.analyzeData.UseVisualStyleBackColor = false;
            this.analyzeData.Click += new System.EventHandler(this.analyzeData_Click);
            // 
            // removeActivity
            // 
            this.removeActivity.BackColor = System.Drawing.Color.LightGray;
            this.removeActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeActivity.Location = new System.Drawing.Point(476, 176);
            this.removeActivity.Name = "removeActivity";
            this.removeActivity.Size = new System.Drawing.Size(246, 33);
            this.removeActivity.TabIndex = 4;
            this.removeActivity.Text = "Видалити активність";
            this.removeActivity.UseVisualStyleBackColor = false;
            this.removeActivity.Click += new System.EventHandler(this.removeActivity_Click);
            // 
            // editActivity
            // 
            this.editActivity.BackColor = System.Drawing.Color.LightGray;
            this.editActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editActivity.Location = new System.Drawing.Point(476, 117);
            this.editActivity.Name = "editActivity";
            this.editActivity.Size = new System.Drawing.Size(246, 33);
            this.editActivity.TabIndex = 3;
            this.editActivity.Text = "Редагувати активність";
            this.editActivity.UseVisualStyleBackColor = false;
            this.editActivity.Click += new System.EventHandler(this.editActivity_Click);
            // 
            // addActivity
            // 
            this.addActivity.BackColor = System.Drawing.Color.LightGray;
            this.addActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActivity.Location = new System.Drawing.Point(476, 55);
            this.addActivity.Name = "addActivity";
            this.addActivity.Size = new System.Drawing.Size(246, 33);
            this.addActivity.TabIndex = 2;
            this.addActivity.Text = "Додати активність";
            this.addActivity.UseVisualStyleBackColor = false;
            this.addActivity.Click += new System.EventHandler(this.addActivity_Click);
            // 
            // activityListBox
            // 
            this.activityListBox.FormattingEnabled = true;
            this.activityListBox.ItemHeight = 16;
            this.activityListBox.Location = new System.Drawing.Point(27, 55);
            this.activityListBox.Name = "activityListBox";
            this.activityListBox.Size = new System.Drawing.Size(418, 212);
            this.activityListBox.TabIndex = 1;
            this.activityListBox.SelectedIndexChanged += new System.EventHandler(this.activityListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Калорій за р./хв";
            // 
            // caloriesPerUnitTextBox
            // 
            this.caloriesPerUnitTextBox.Location = new System.Drawing.Point(522, 335);
            this.caloriesPerUnitTextBox.Multiline = true;
            this.caloriesPerUnitTextBox.Name = "caloriesPerUnitTextBox";
            this.caloriesPerUnitTextBox.Size = new System.Drawing.Size(200, 24);
            this.caloriesPerUnitTextBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Спалено калорій";
            // 
            // caloriesBurnedTextBox
            // 
            this.caloriesBurnedTextBox.Location = new System.Drawing.Point(161, 335);
            this.caloriesBurnedTextBox.Multiline = true;
            this.caloriesBurnedTextBox.Name = "caloriesBurnedTextBox";
            this.caloriesBurnedTextBox.Size = new System.Drawing.Size(200, 24);
            this.caloriesBurnedTextBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Тип";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Дата";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(161, 289);
            this.typeTextBox.Multiline = true;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 24);
            this.typeTextBox.TabIndex = 56;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(161, 379);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(200, 24);
            this.dateTextBox.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Кількість р./хв";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(522, 289);
            this.valueTextBox.Multiline = true;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 24);
            this.valueTextBox.TabIndex = 59;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(161, 424);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Пошук за датою";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(394, 423);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 24);
            this.search.TabIndex = 63;
            this.search.Text = "Знайти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ActivityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 468);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caloriesPerUnitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caloriesBurnedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.analyzeData);
            this.Controls.Add(this.removeActivity);
            this.Controls.Add(this.editActivity);
            this.Controls.Add(this.addActivity);
            this.Controls.Add(this.activityListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(770, 515);
            this.Name = "ActivityList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд активності: Додаток для контролю здоров\'я";
            this.Load += new System.EventHandler(this.ActivityList_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem додатиАктивністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиАктивністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиАктивністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналізуватиДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.Button analyzeData;
        private System.Windows.Forms.Button removeActivity;
        private System.Windows.Forms.Button editActivity;
        private System.Windows.Forms.Button addActivity;
        private System.Windows.Forms.ListBox activityListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caloriesPerUnitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caloriesBurnedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
    }
}