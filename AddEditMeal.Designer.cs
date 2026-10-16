namespace HealthApp
{
    partial class AddEditMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMeal));
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portionTextBox = new System.Windows.Forms.TextBox();
            this.kcalTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.carbohydratesTextBox = new System.Windows.Forms.TextBox();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.sugarTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.LightGray;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Location = new System.Drawing.Point(368, 260);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(109, 33);
            this.accept.TabIndex = 11;
            this.accept.Text = "OK";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightGray;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(504, 260);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 33);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Відмінити";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // mealComboBox
            // 
            this.mealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Location = new System.Drawing.Point(215, 29);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(398, 24);
            this.mealComboBox.TabIndex = 1;
            this.mealComboBox.SelectedIndexChanged += new System.EventHandler(this.mealComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Порція, г";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ккал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Жири";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Вуглеводи";
            // 
            // portionTextBox
            // 
            this.portionTextBox.Location = new System.Drawing.Point(125, 124);
            this.portionTextBox.Multiline = true;
            this.portionTextBox.Name = "portionTextBox";
            this.portionTextBox.Size = new System.Drawing.Size(174, 24);
            this.portionTextBox.TabIndex = 3;
            // 
            // kcalTextBox
            // 
            this.kcalTextBox.Location = new System.Drawing.Point(125, 168);
            this.kcalTextBox.Multiline = true;
            this.kcalTextBox.Name = "kcalTextBox";
            this.kcalTextBox.Size = new System.Drawing.Size(174, 24);
            this.kcalTextBox.TabIndex = 4;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(125, 212);
            this.fatTextBox.Multiline = true;
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(174, 24);
            this.fatTextBox.TabIndex = 5;
            // 
            // carbohydratesTextBox
            // 
            this.carbohydratesTextBox.Location = new System.Drawing.Point(439, 77);
            this.carbohydratesTextBox.Multiline = true;
            this.carbohydratesTextBox.Name = "carbohydratesTextBox";
            this.carbohydratesTextBox.Size = new System.Drawing.Size(174, 24);
            this.carbohydratesTextBox.TabIndex = 7;
            // 
            // saltTextBox
            // 
            this.saltTextBox.Location = new System.Drawing.Point(439, 212);
            this.saltTextBox.Multiline = true;
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(174, 24);
            this.saltTextBox.TabIndex = 10;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(439, 168);
            this.proteinTextBox.Multiline = true;
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(174, 24);
            this.proteinTextBox.TabIndex = 9;
            // 
            // sugarTextBox
            // 
            this.sugarTextBox.Location = new System.Drawing.Point(439, 124);
            this.sugarTextBox.Multiline = true;
            this.sugarTextBox.Name = "sugarTextBox";
            this.sugarTextBox.Size = new System.Drawing.Size(174, 24);
            this.sugarTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Сіль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Білки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Цукор";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Оберіть страву зі списку";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Назва";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 77);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 24);
            this.nameTextBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Location = new System.Drawing.Point(125, 258);
            this.dateTimePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // AddEditMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 313);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 360);
            this.Name = "AddEditMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нова страва / редагування страви";
            this.Load += new System.EventHandler(this.AddEditMeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portionTextBox;
        private System.Windows.Forms.TextBox kcalTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox carbohydratesTextBox;
        private System.Windows.Forms.TextBox saltTextBox;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.TextBox sugarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}