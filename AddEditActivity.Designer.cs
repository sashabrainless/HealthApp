namespace HealthApp
{
    partial class AddEditActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditActivity));
            this.label9 = new System.Windows.Forms.Label();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.caloriesPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caloriesBurnedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Оберіть активність зі списку";
            // 
            // activityComboBox
            // 
            this.activityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Location = new System.Drawing.Point(237, 23);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(372, 24);
            this.activityComboBox.TabIndex = 1;
            this.activityComboBox.SelectedIndexChanged += new System.EventHandler(this.activityComboBox_SelectedIndexChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(500, 214);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 33);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Відмінити";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(362, 214);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(109, 33);
            this.accept.TabIndex = 8;
            this.accept.Text = "OK";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Тип";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(97, 118);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(174, 24);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(97, 167);
            this.dateTimePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // caloriesPerUnitTextBox
            // 
            this.caloriesPerUnitTextBox.Location = new System.Drawing.Point(435, 118);
            this.caloriesPerUnitTextBox.Multiline = true;
            this.caloriesPerUnitTextBox.Name = "caloriesPerUnitTextBox";
            this.caloriesPerUnitTextBox.Size = new System.Drawing.Size(174, 24);
            this.caloriesPerUnitTextBox.TabIndex = 6;
            this.caloriesPerUnitTextBox.TextChanged += new System.EventHandler(this.caloriesPerUnitTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Калорій за р./хв";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Кількість р./хв";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(435, 72);
            this.valueTextBox.Multiline = true;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(174, 24);
            this.valueTextBox.TabIndex = 5;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 72);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 24);
            this.nameTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Назва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Спалено калорій";
            // 
            // caloriesBurnedTextBox
            // 
            this.caloriesBurnedTextBox.Location = new System.Drawing.Point(435, 165);
            this.caloriesBurnedTextBox.Multiline = true;
            this.caloriesBurnedTextBox.Name = "caloriesBurnedTextBox";
            this.caloriesBurnedTextBox.Size = new System.Drawing.Size(174, 24);
            this.caloriesBurnedTextBox.TabIndex = 7;
            // 
            // AddEditActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 268);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caloriesBurnedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caloriesPerUnitTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.activityComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(655, 315);
            this.Name = "AddEditActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нова активність / редагування активність";
            this.Load += new System.EventHandler(this.AddEditActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox caloriesPerUnitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caloriesBurnedTextBox;
    }
}