namespace HealthApp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.activityGroupBox = new System.Windows.Forms.GroupBox();
            this.editLatestActivity = new System.Windows.Forms.Button();
            this.removeLatestActivity = new System.Windows.Forms.Button();
            this.latestAddedActivityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lookAtAllActivity = new System.Windows.Forms.Button();
            this.addActivity = new System.Windows.Forms.Button();
            this.analyzeData = new System.Windows.Forms.Button();
            this.removeLatestMeal = new System.Windows.Forms.Button();
            this.addMeal = new System.Windows.Forms.Button();
            this.lookAtAllMeals = new System.Windows.Forms.Button();
            this.latestAddedMealTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.харчуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиХарчуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиСтравуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиОстаннюСтравуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиОстаннюСтравуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиАктивностіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиАктивністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиОстаннюАктивністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиОстаннюАктивністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізуватиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.користувачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.editLatestMeal = new System.Windows.Forms.Button();
            this.activityGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.foodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityGroupBox
            // 
            this.activityGroupBox.Controls.Add(this.editLatestActivity);
            this.activityGroupBox.Controls.Add(this.removeLatestActivity);
            this.activityGroupBox.Controls.Add(this.latestAddedActivityTextBox);
            this.activityGroupBox.Controls.Add(this.label2);
            this.activityGroupBox.Controls.Add(this.lookAtAllActivity);
            this.activityGroupBox.Controls.Add(this.addActivity);
            this.activityGroupBox.Location = new System.Drawing.Point(423, 50);
            this.activityGroupBox.Name = "activityGroupBox";
            this.activityGroupBox.Size = new System.Drawing.Size(363, 363);
            this.activityGroupBox.TabIndex = 6;
            this.activityGroupBox.TabStop = false;
            this.activityGroupBox.Text = "Активність";
            // 
            // editLatestActivity
            // 
            this.editLatestActivity.BackColor = System.Drawing.Color.LightGray;
            this.editLatestActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLatestActivity.Location = new System.Drawing.Point(25, 260);
            this.editLatestActivity.Name = "editLatestActivity";
            this.editLatestActivity.Size = new System.Drawing.Size(312, 33);
            this.editLatestActivity.TabIndex = 9;
            this.editLatestActivity.Text = "Редагувати останню активність";
            this.editLatestActivity.UseVisualStyleBackColor = false;
            this.editLatestActivity.Click += new System.EventHandler(this.editLatestActivity_Click);
            // 
            // removeLatestActivity
            // 
            this.removeLatestActivity.BackColor = System.Drawing.Color.LightGray;
            this.removeLatestActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLatestActivity.Location = new System.Drawing.Point(25, 313);
            this.removeLatestActivity.Name = "removeLatestActivity";
            this.removeLatestActivity.Size = new System.Drawing.Size(312, 33);
            this.removeLatestActivity.TabIndex = 10;
            this.removeLatestActivity.Text = "Видалити останню активність";
            this.removeLatestActivity.UseVisualStyleBackColor = false;
            this.removeLatestActivity.Click += new System.EventHandler(this.removeLatestActivity_Click);
            // 
            // latestAddedActivityTextBox
            // 
            this.latestAddedActivityTextBox.Enabled = false;
            this.latestAddedActivityTextBox.Location = new System.Drawing.Point(25, 67);
            this.latestAddedActivityTextBox.Multiline = true;
            this.latestAddedActivityTextBox.Name = "latestAddedActivityTextBox";
            this.latestAddedActivityTextBox.ReadOnly = true;
            this.latestAddedActivityTextBox.Size = new System.Drawing.Size(312, 64);
            this.latestAddedActivityTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Остання додана активність";
            // 
            // lookAtAllActivity
            // 
            this.lookAtAllActivity.BackColor = System.Drawing.Color.LightGray;
            this.lookAtAllActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookAtAllActivity.Location = new System.Drawing.Point(25, 153);
            this.lookAtAllActivity.Name = "lookAtAllActivity";
            this.lookAtAllActivity.Size = new System.Drawing.Size(312, 35);
            this.lookAtAllActivity.TabIndex = 7;
            this.lookAtAllActivity.Text = "Переглянути повний список";
            this.lookAtAllActivity.UseVisualStyleBackColor = false;
            this.lookAtAllActivity.Click += new System.EventHandler(this.lookAtAllActivity_Click);
            // 
            // addActivity
            // 
            this.addActivity.BackColor = System.Drawing.Color.LightGray;
            this.addActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActivity.Location = new System.Drawing.Point(25, 207);
            this.addActivity.Name = "addActivity";
            this.addActivity.Size = new System.Drawing.Size(312, 33);
            this.addActivity.TabIndex = 8;
            this.addActivity.Text = "Додати активність";
            this.addActivity.UseVisualStyleBackColor = false;
            this.addActivity.Click += new System.EventHandler(this.addActivity_Click);
            // 
            // analyzeData
            // 
            this.analyzeData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.analyzeData.BackColor = System.Drawing.Color.LightGray;
            this.analyzeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeData.Location = new System.Drawing.Point(251, 432);
            this.analyzeData.Name = "analyzeData";
            this.analyzeData.Size = new System.Drawing.Size(312, 33);
            this.analyzeData.TabIndex = 11;
            this.analyzeData.Text = "Аналізувати дані";
            this.analyzeData.UseVisualStyleBackColor = false;
            this.analyzeData.Click += new System.EventHandler(this.analyzeData_Click);
            // 
            // removeLatestMeal
            // 
            this.removeLatestMeal.BackColor = System.Drawing.Color.LightGray;
            this.removeLatestMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLatestMeal.Location = new System.Drawing.Point(24, 313);
            this.removeLatestMeal.Name = "removeLatestMeal";
            this.removeLatestMeal.Size = new System.Drawing.Size(312, 33);
            this.removeLatestMeal.TabIndex = 5;
            this.removeLatestMeal.Text = "Видалити останню страву";
            this.removeLatestMeal.UseVisualStyleBackColor = false;
            this.removeLatestMeal.Click += new System.EventHandler(this.removeLatestMeal_Click);
            // 
            // addMeal
            // 
            this.addMeal.BackColor = System.Drawing.Color.LightGray;
            this.addMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMeal.Location = new System.Drawing.Point(24, 207);
            this.addMeal.Name = "addMeal";
            this.addMeal.Size = new System.Drawing.Size(312, 33);
            this.addMeal.TabIndex = 3;
            this.addMeal.Text = "Додати страву";
            this.addMeal.UseVisualStyleBackColor = false;
            this.addMeal.Click += new System.EventHandler(this.addMeal_Click);
            // 
            // lookAtAllMeals
            // 
            this.lookAtAllMeals.BackColor = System.Drawing.Color.LightGray;
            this.lookAtAllMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookAtAllMeals.Location = new System.Drawing.Point(24, 153);
            this.lookAtAllMeals.Name = "lookAtAllMeals";
            this.lookAtAllMeals.Size = new System.Drawing.Size(312, 35);
            this.lookAtAllMeals.TabIndex = 2;
            this.lookAtAllMeals.Text = "Переглянути повний список";
            this.lookAtAllMeals.UseVisualStyleBackColor = false;
            this.lookAtAllMeals.Click += new System.EventHandler(this.lookAtAllMeals_Click);
            // 
            // latestAddedMealTextBox
            // 
            this.latestAddedMealTextBox.Enabled = false;
            this.latestAddedMealTextBox.Location = new System.Drawing.Point(24, 67);
            this.latestAddedMealTextBox.Multiline = true;
            this.latestAddedMealTextBox.Name = "latestAddedMealTextBox";
            this.latestAddedMealTextBox.ReadOnly = true;
            this.latestAddedMealTextBox.Size = new System.Drawing.Size(312, 64);
            this.latestAddedMealTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Остання додана страва";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // темнаТемаToolStripMenuItem
            // 
            this.темнаТемаToolStripMenuItem.Name = "темнаТемаToolStripMenuItem";
            this.темнаТемаToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.темнаТемаToolStripMenuItem.Text = "Темна тема";
            this.темнаТемаToolStripMenuItem.Click += new System.EventHandler(this.темнаТемаToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темнаТемаToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // видалитиДаніToolStripMenuItem
            // 
            this.видалитиДаніToolStripMenuItem.Name = "видалитиДаніToolStripMenuItem";
            this.видалитиДаніToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.видалитиДаніToolStripMenuItem.Text = "Видалити дані";
            this.видалитиДаніToolStripMenuItem.Click += new System.EventHandler(this.видалитиДаніToolStripMenuItem_Click);
            // 
            // редагуватиДаніToolStripMenuItem
            // 
            this.редагуватиДаніToolStripMenuItem.Name = "редагуватиДаніToolStripMenuItem";
            this.редагуватиДаніToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.редагуватиДаніToolStripMenuItem.Text = "Редагувати дані";
            this.редагуватиДаніToolStripMenuItem.Click += new System.EventHandler(this.редагуватиДаніToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.харчуванняToolStripMenuItem,
            this.активністьToolStripMenuItem,
            this.аналізToolStripMenuItem,
            this.користувачToolStripMenuItem,
            this.налаштуванняToolStripMenuItem,
            this.інформаціяToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(815, 28);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // харчуванняToolStripMenuItem
            // 
            this.харчуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглянутиХарчуванняToolStripMenuItem,
            this.додатиСтравуToolStripMenuItem,
            this.редагуватиОстаннюСтравуToolStripMenuItem,
            this.видалитиОстаннюСтравуToolStripMenuItem});
            this.харчуванняToolStripMenuItem.Name = "харчуванняToolStripMenuItem";
            this.харчуванняToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.харчуванняToolStripMenuItem.Text = "Харчування";
            // 
            // переглянутиХарчуванняToolStripMenuItem
            // 
            this.переглянутиХарчуванняToolStripMenuItem.Name = "переглянутиХарчуванняToolStripMenuItem";
            this.переглянутиХарчуванняToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.переглянутиХарчуванняToolStripMenuItem.Text = "Переглянути харчування";
            this.переглянутиХарчуванняToolStripMenuItem.Click += new System.EventHandler(this.переглянутиХарчуванняToolStripMenuItem_Click);
            // 
            // додатиСтравуToolStripMenuItem
            // 
            this.додатиСтравуToolStripMenuItem.Name = "додатиСтравуToolStripMenuItem";
            this.додатиСтравуToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.додатиСтравуToolStripMenuItem.Text = "Додати страву";
            this.додатиСтравуToolStripMenuItem.Click += new System.EventHandler(this.додатиСтравуToolStripMenuItem_Click);
            // 
            // редагуватиОстаннюСтравуToolStripMenuItem
            // 
            this.редагуватиОстаннюСтравуToolStripMenuItem.Name = "редагуватиОстаннюСтравуToolStripMenuItem";
            this.редагуватиОстаннюСтравуToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.редагуватиОстаннюСтравуToolStripMenuItem.Text = "Редагувати останню страву";
            this.редагуватиОстаннюСтравуToolStripMenuItem.Click += new System.EventHandler(this.редагуватиОстаннюСтравуToolStripMenuItem_Click);
            // 
            // видалитиОстаннюСтравуToolStripMenuItem
            // 
            this.видалитиОстаннюСтравуToolStripMenuItem.Name = "видалитиОстаннюСтравуToolStripMenuItem";
            this.видалитиОстаннюСтравуToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.видалитиОстаннюСтравуToolStripMenuItem.Text = "Видалити останню страву";
            this.видалитиОстаннюСтравуToolStripMenuItem.Click += new System.EventHandler(this.видалитиОстаннюСтравуToolStripMenuItem_Click);
            // 
            // активністьToolStripMenuItem
            // 
            this.активністьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглянутиАктивностіToolStripMenuItem,
            this.додатиАктивністьToolStripMenuItem,
            this.редагуватиОстаннюАктивністьToolStripMenuItem,
            this.видалитиОстаннюАктивністьToolStripMenuItem});
            this.активністьToolStripMenuItem.Name = "активністьToolStripMenuItem";
            this.активністьToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.активністьToolStripMenuItem.Text = "Активність";
            // 
            // переглянутиАктивностіToolStripMenuItem
            // 
            this.переглянутиАктивностіToolStripMenuItem.Name = "переглянутиАктивностіToolStripMenuItem";
            this.переглянутиАктивностіToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.переглянутиАктивностіToolStripMenuItem.Text = "Переглянути активності";
            this.переглянутиАктивностіToolStripMenuItem.Click += new System.EventHandler(this.переглянутиАктивностіToolStripMenuItem_Click);
            // 
            // додатиАктивністьToolStripMenuItem
            // 
            this.додатиАктивністьToolStripMenuItem.Name = "додатиАктивністьToolStripMenuItem";
            this.додатиАктивністьToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.додатиАктивністьToolStripMenuItem.Text = "Додати активність";
            this.додатиАктивністьToolStripMenuItem.Click += new System.EventHandler(this.додатиАктивністьToolStripMenuItem_Click);
            // 
            // редагуватиОстаннюАктивністьToolStripMenuItem
            // 
            this.редагуватиОстаннюАктивністьToolStripMenuItem.Name = "редагуватиОстаннюАктивністьToolStripMenuItem";
            this.редагуватиОстаннюАктивністьToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.редагуватиОстаннюАктивністьToolStripMenuItem.Text = "Редагувати останню активність";
            this.редагуватиОстаннюАктивністьToolStripMenuItem.Click += new System.EventHandler(this.редагуватиОстаннюАктивністьToolStripMenuItem_Click);
            // 
            // видалитиОстаннюАктивністьToolStripMenuItem
            // 
            this.видалитиОстаннюАктивністьToolStripMenuItem.Name = "видалитиОстаннюАктивністьToolStripMenuItem";
            this.видалитиОстаннюАктивністьToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.видалитиОстаннюАктивністьToolStripMenuItem.Text = "Видалити останню активність";
            this.видалитиОстаннюАктивністьToolStripMenuItem.Click += new System.EventHandler(this.видалитиОстаннюАктивністьToolStripMenuItem_Click);
            // 
            // аналізToolStripMenuItem
            // 
            this.аналізToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аналізуватиДаніToolStripMenuItem});
            this.аналізToolStripMenuItem.Name = "аналізToolStripMenuItem";
            this.аналізToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.аналізToolStripMenuItem.Text = "Аналіз";
            // 
            // аналізуватиДаніToolStripMenuItem
            // 
            this.аналізуватиДаніToolStripMenuItem.Name = "аналізуватиДаніToolStripMenuItem";
            this.аналізуватиДаніToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.аналізуватиДаніToolStripMenuItem.Text = "Аналізувати дані";
            // 
            // користувачToolStripMenuItem
            // 
            this.користувачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглянутиДаніToolStripMenuItem,
            this.редагуватиДаніToolStripMenuItem,
            this.видалитиДаніToolStripMenuItem});
            this.користувачToolStripMenuItem.Name = "користувачToolStripMenuItem";
            this.користувачToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.користувачToolStripMenuItem.Text = "Користувач";
            // 
            // переглянутиДаніToolStripMenuItem
            // 
            this.переглянутиДаніToolStripMenuItem.Name = "переглянутиДаніToolStripMenuItem";
            this.переглянутиДаніToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.переглянутиДаніToolStripMenuItem.Text = "Переглянути дані";
            this.переглянутиДаніToolStripMenuItem.Click += new System.EventHandler(this.переглянутиДаніToolStripMenuItem_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідкаToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            this.довідкаToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Controls.Add(this.editLatestMeal);
            this.foodGroupBox.Controls.Add(this.removeLatestMeal);
            this.foodGroupBox.Controls.Add(this.latestAddedMealTextBox);
            this.foodGroupBox.Controls.Add(this.label1);
            this.foodGroupBox.Controls.Add(this.lookAtAllMeals);
            this.foodGroupBox.Controls.Add(this.addMeal);
            this.foodGroupBox.Location = new System.Drawing.Point(27, 50);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(363, 363);
            this.foodGroupBox.TabIndex = 1;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "Харчування";
            // 
            // editLatestMeal
            // 
            this.editLatestMeal.BackColor = System.Drawing.Color.LightGray;
            this.editLatestMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLatestMeal.Location = new System.Drawing.Point(24, 260);
            this.editLatestMeal.Name = "editLatestMeal";
            this.editLatestMeal.Size = new System.Drawing.Size(312, 33);
            this.editLatestMeal.TabIndex = 4;
            this.editLatestMeal.Text = "Редагувати останню страву";
            this.editLatestMeal.UseVisualStyleBackColor = false;
            this.editLatestMeal.Click += new System.EventHandler(this.editLatestMeal_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 483);
            this.Controls.Add(this.activityGroupBox);
            this.Controls.Add(this.analyzeData);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.foodGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(833, 530);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню: Додаток для контролю здоров\'я";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.activityGroupBox.ResumeLayout(false);
            this.activityGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.foodGroupBox.ResumeLayout(false);
            this.foodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox activityGroupBox;
        private System.Windows.Forms.Button removeLatestActivity;
        private System.Windows.Forms.TextBox latestAddedActivityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lookAtAllActivity;
        private System.Windows.Forms.Button addActivity;
        private System.Windows.Forms.Button analyzeData;
        private System.Windows.Forms.Button removeLatestMeal;
        private System.Windows.Forms.Button addMeal;
        private System.Windows.Forms.Button lookAtAllMeals;
        private System.Windows.Forms.TextBox latestAddedMealTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаТемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиДаніToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem харчуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглянутиХарчуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиСтравуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиОстаннюСтравуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглянутиАктивностіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиАктивністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиОстаннюАктивністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналізToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналізуватиДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem користувачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглянутиДаніToolStripMenuItem;
        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиОстаннюСтравуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиОстаннюАктивністьToolStripMenuItem;
        private System.Windows.Forms.Button editLatestMeal;
        private System.Windows.Forms.Button editLatestActivity;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
    }
}

