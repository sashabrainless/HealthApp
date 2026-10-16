namespace HealthApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.load = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.clearData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.LightGray;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(26, 31);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(230, 33);
            this.load.TabIndex = 1;
            this.load.Text = "Завантажити користувача";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.LightGray;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Location = new System.Drawing.Point(274, 31);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(230, 33);
            this.create.TabIndex = 2;
            this.create.Text = "Створити користувача";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(274, 89);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(230, 33);
            this.exit.TabIndex = 4;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clearData
            // 
            this.clearData.BackColor = System.Drawing.Color.LightGray;
            this.clearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearData.Location = new System.Drawing.Point(26, 89);
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(230, 33);
            this.clearData.TabIndex = 3;
            this.clearData.Text = "Видалити дані користувача";
            this.clearData.UseVisualStyleBackColor = false;
            this.clearData.Click += new System.EventHandler(this.clearData_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 153);
            this.Controls.Add(this.clearData);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.create);
            this.Controls.Add(this.load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 200);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід: Додаток для контролю здоров\'я";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clearData;
    }
}