using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class Login : Form
    {
        bool darkTheme = false;

        public Login()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createUser()
        {
            File.Delete("user.json");

            User user = new User();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonStringMealSerialize = JsonSerializer.Serialize(user.meals, options);
            File.WriteAllText("meals.json", jsonStringMealSerialize);


            string jsonStringActivitySerialize = JsonSerializer.Serialize(user.activity, options);
            File.WriteAllText("activity.json", jsonStringMealSerialize);

            ViewEditUser createUser = new ViewEditUser("create");
            createUser.Text = "Створення користувача: Додаток для контролю здоров'я";
            createUser.ShowDialog();
            createUser.Close();
        }

        private void loadUser()
        {
            User user = new User();

            if (File.Exists("user.json"))
            {
                string jsonString = File.ReadAllText("user.json");
                user = JsonSerializer.Deserialize<User>(jsonString);

                if (!File.Exists("meals.json"))
                {
                    File.Create("meals.json");
                }

                if (!File.Exists("activity.json"))
                {
                    File.Create("activity.json");
                }

                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.ShowDialog();

                try
                {
                    LoadData();
                    this.Show();
                    mainMenu.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка! Закриття програми!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Не існує запису користувача!\nСтворити?", "Інформація", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK))
                {
                    createUser();
                    loadUser();
                }
            }
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            if (File.Exists("user.json"))
            {
                DialogResult result = MessageBox.Show("Запис користувача та всі дані буде видалено!\nПродовжити?", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result.Equals(DialogResult.OK))
                {
                    File.Delete("user.json");
                    File.Delete("meals.json");
                    File.Delete("activity.json");
                }
            }
            else
                MessageBox.Show("Не існує запису користувача!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThemeChange()
        {
            if (darkTheme)
            {
                this.BackColor = Color.DimGray;
                this.ForeColor = SystemColors.Control;

                load.BackColor = Color.Gray;
                load.BackColor = Color.Gray;

                create.BackColor = Color.Gray;
                create.BackColor = Color.Gray;

                clearData.BackColor = Color.Gray;
                clearData.BackColor = Color.Gray;

                exit.BackColor = Color.Gray;
                exit.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                load.BackColor = Color.LightGray;
                load.BackColor = Color.LightGray;

                create.BackColor = Color.LightGray;
                create.BackColor = Color.LightGray;

                clearData.BackColor = Color.LightGray;
                clearData.BackColor = Color.LightGray;

                exit.BackColor = Color.LightGray;
                exit.BackColor = Color.LightGray;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists("theme.txt"))
            {
                try
                {
                    darkTheme = bool.Parse(File.ReadAllText("theme.txt"));
                    ThemeChange();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Відсутній файл налаштування теми, було створено новий.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.WriteAllText("theme.txt", darkTheme.ToString());
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            loadUser();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (File.Exists("user.json"))
            {
                DialogResult result = MessageBox.Show("Запис користувача вже існує!\nСтворити новий та видалити старий?", "Попередження!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                    createUser();
            }
            else
                createUser();
        }
    }
}
