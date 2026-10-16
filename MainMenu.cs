using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class MainMenu : Form
    {
        string jsonString = File.ReadAllText("user.json");
        User user = new User();
        bool darkTheme = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
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
            else
                File.WriteAllText("theme.txt", darkTheme.ToString());

            user = JsonSerializer.Deserialize<User>(jsonString);

            if (File.Exists("meals.json") && new FileInfo("meals.json").Length > 2)
            {
                string jsonStringMeals = File.ReadAllText("meals.json");
                user.meals = JsonSerializer.Deserialize<List<Meal>>(jsonStringMeals) ?? new List<Meal>();

                int latestMealIndex = user.getMealsLength() - 1;

                latestAddedMealTextBox.Text = user.meals[latestMealIndex].getName() + ", " + user.meals[latestMealIndex].getPortion() + " г, " + user.meals[latestMealIndex].getDate().Day + "/" + user.meals[latestMealIndex].getDate().Month + "/" + user.meals[latestMealIndex].getDate().Year;

                editLatestMeal.Enabled = true;
                removeLatestMeal.Enabled = true;

                редагуватиОстаннюСтравуToolStripMenuItem.Enabled = true;
                видалитиОстаннюСтравуToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (!File.Exists("meals.json"))
                    File.Create("meals.json");

                latestAddedMealTextBox.Text = "Дані відсутні";

                editLatestMeal.Enabled = false;
                removeLatestMeal.Enabled = false;

                редагуватиОстаннюСтравуToolStripMenuItem.Enabled = false;
                видалитиОстаннюСтравуToolStripMenuItem.Enabled = false;

                user.meals = new List<Meal>();
            }

            if (File.Exists("activity.json") && new FileInfo("activity.json").Length > 2)
            {
                string jsonStringActivity = File.ReadAllText("activity.json");
                user.activity = JsonSerializer.Deserialize<List<Activity>>(jsonStringActivity) ?? new List<Activity>();

                int latestActivityIndex = user.getActivityLength() - 1;

                if (user.activity[latestActivityIndex].getTypeString().Equals("За часом"))
                    latestAddedActivityTextBox.Text = user.activity[latestActivityIndex].getName() + ", " + user.activity[latestActivityIndex].getValue() + " хв, " + user.activity[latestActivityIndex].getDate().Day + "/" + user.activity[latestActivityIndex].getDate().Month + "/" + user.activity[latestActivityIndex].getDate().Year;
                else
                    latestAddedActivityTextBox.Text = user.activity[latestActivityIndex].getName() + ", " + user.activity[latestActivityIndex].getValue() + " р. " + user.activity[latestActivityIndex].getDate().Day + "/" + user.activity[latestActivityIndex].getDate().Month + "/" + user.activity[latestActivityIndex].getDate().Year;

                editLatestActivity.Enabled = true;
                removeLatestActivity.Enabled = true;

                редагуватиОстаннюАктивністьToolStripMenuItem.Enabled = true;
                видалитиОстаннюАктивністьToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (!File.Exists("activity.json"))
                    File.Create("activity.json");

                latestAddedActivityTextBox.Text = "Дані відсутні";

                editLatestActivity.Enabled = false;
                removeLatestActivity.Enabled = false;

                редагуватиОстаннюАктивністьToolStripMenuItem.Enabled = false;
                видалитиОстаннюАктивністьToolStripMenuItem.Enabled = false;

                user.activity = new List<Activity>();
            }
        }

        private void ThemeChange()
        {
            if (darkTheme)
            {
                темнаТемаToolStripMenuItem.Checked = true;

                this.BackColor = Color.DimGray;
                this.ForeColor = SystemColors.Control;

                this.menuStrip.BackColor = Color.Gray;
                this.menuStrip.ForeColor = SystemColors.Control;

                foodGroupBox.ForeColor = SystemColors.Control;
                activityGroupBox.ForeColor = SystemColors.Control;

                lookAtAllMeals.BackColor = Color.Gray;
                addMeal.BackColor = Color.Gray;
                editLatestMeal.BackColor = Color.Gray;
                removeLatestMeal.BackColor = Color.Gray;
                lookAtAllActivity.BackColor = Color.Gray;
                addActivity.BackColor = Color.Gray;
                editLatestActivity.BackColor = Color.Gray;
                removeLatestActivity.BackColor = Color.Gray;
                analyzeData.BackColor = Color.Gray;

                File.WriteAllText("theme.txt", darkTheme.ToString());
            }
            else
            {
                темнаТемаToolStripMenuItem.Checked = false;

                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                this.menuStrip.BackColor = SystemColors.ControlLightLight;
                this.menuStrip.ForeColor = SystemColors.ControlText;

                foodGroupBox.ForeColor = SystemColors.ControlText;
                activityGroupBox.ForeColor = SystemColors.ControlText;

                lookAtAllMeals.BackColor = Color.LightGray;
                addMeal.BackColor = Color.LightGray;
                editLatestMeal.BackColor = Color.LightGray;
                removeLatestMeal.BackColor = Color.LightGray;
                lookAtAllActivity.BackColor = Color.LightGray;
                addActivity.BackColor = Color.LightGray;
                editLatestActivity.BackColor = Color.LightGray;
                removeLatestActivity.BackColor = Color.LightGray;
                analyzeData.BackColor = Color.LightGray;

                File.WriteAllText("theme.txt", darkTheme.ToString());
            }
        }

        private void deleteLatestMeal()
        {
            DialogResult result = MessageBox.Show("Запис останньої страви буде видалено!\nПродовжити?", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                user.removeLastMeal();

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonStringMealSerialize = JsonSerializer.Serialize(user.meals, options);
                File.WriteAllText("meals.json", jsonStringMealSerialize);

                LoadData();
            }
        }

        private void deleteLatestActivity()
        {
            DialogResult result = MessageBox.Show("Запис останньої активності буде видалено!\nПродовжити?", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                user.removeLastActivity();

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonStringActivitySerialize = JsonSerializer.Serialize(user.activity, options);
                File.WriteAllText("activity.json", jsonStringActivitySerialize);

                LoadData();
            }
        }

        private void lookAtAllMeals_Click(object sender, EventArgs e)
        {
            MealList meals = new MealList();
            meals.ShowDialog();
            meals.Close();
            LoadData();
        }

        private void lookAtAllActivity_Click(object sender, EventArgs e)
        {
            ActivityList activity = new ActivityList();
            activity.ShowDialog();
            activity.Close();
            LoadData();
        }

        private void addMeal_Click(object sender, EventArgs e)
        {
            AddEditMeal addmeal = new AddEditMeal("add", 0);
            addmeal.Text = "Нова страва: Додаток для контролю здоров'я";
            addmeal.ShowDialog();
            addmeal.Close();
            LoadData();
        }

        private void addActivity_Click(object sender, EventArgs e)
        {
            AddEditActivity addactivity = new AddEditActivity("add", 0);
            addactivity.Text = "Нова активність: Додаток для контролю здоров'я";
            addactivity.ShowDialog();
            addactivity.Close();
            LoadData();
        }

        private void переглянутиХарчуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealList meals = new MealList();
            meals.ShowDialog();
            meals.Close();
            LoadData();
        }

        private void переглянутиАктивностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityList activity = new ActivityList();
            activity.ShowDialog();
            activity.Close();
            LoadData();
        }

        private void додатиСтравуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditMeal addmeal = new AddEditMeal("add", 0);
            addmeal.Text = "Нова страва: Додаток для контролю здоров'я";
            addmeal.ShowDialog();
            addmeal.Close();
            LoadData();
        }

        private void додатиАктивністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditActivity addactivity = new AddEditActivity("add", 0);
            addactivity.Text = "Нова активність: Додаток для контролю здоров'я";
            addactivity.ShowDialog();
            addactivity.Close();
            LoadData();
        }

        private void переглянутиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditUser viewuser = new ViewEditUser("view");
            viewuser.Text = "Перегляд даних користувача: Додаток для контролю здоров'я";
            viewuser.ShowDialog();
            viewuser.Close();
            LoadData();
        }

        private void редагуватиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditUser edituser = new ViewEditUser("edit");
            edituser.Text = "Редагування даних користувача: Додаток для контролю здоров'я";
            edituser.ShowDialog();
            edituser.Close();
            LoadData();
        }

        private void видалитиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Запис користувача та всі дані буде видалено!\nПродовжити?", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (result.Equals(DialogResult.OK))
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

                this.Close();
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void removeLatestMeal_Click(object sender, EventArgs e)
        {
            deleteLatestMeal();
        }

        private void removeLatestActivity_Click(object sender, EventArgs e)
        {
            deleteLatestActivity();
        }

        private void видалитиОстаннюСтравуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteLatestMeal();
        }

        private void видалитиОстаннюАктивністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteLatestActivity();
        }

        private void editLatestMeal_Click(object sender, EventArgs e)
        {
            AddEditMeal editmeal = new AddEditMeal("edit latest", 0);
            editmeal.Text = "Редагування страви: Додаток для контролю здоров'я";
            editmeal.ShowDialog();
            editmeal.Close();
            LoadData();
        }

        private void editLatestActivity_Click(object sender, EventArgs e)
        {
            AddEditActivity editactivity = new AddEditActivity("edit latest", 0);
            editactivity.Text = "Редагування активності: Додаток для контролю здоров'я";
            editactivity.ShowDialog();
            editactivity.Close();
            LoadData();
        }

        private void редагуватиОстаннюСтравуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditMeal editmeal = new AddEditMeal("edit latest", 0);
            editmeal.Text = "Редагування страви: Додаток для контролю здоров'я";
            editmeal.ShowDialog();
            editmeal.Close();
            LoadData();
        }

        private void редагуватиОстаннюАктивністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditActivity editactivity = new AddEditActivity("edit latest", 0);
            editactivity.Text = "Редагування активності: Додаток для контролю здоров'я";
            editactivity.ShowDialog();
            editactivity.Close();
            LoadData();
        }

        private void темнаТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkTheme)
                darkTheme = false;
            else
                darkTheme = true;

            ThemeChange();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
            help.Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Text = "Про програму: Додаток для контролю здоров'я";
            about.ShowDialog();
            about.Close();
        }

        private void analyzeData_Click(object sender, EventArgs e)
        {
            if (user.getMealsLength().Equals(0) )
                MessageBox.Show("Відсутні записи про харчування.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                HealthReport report = user.analyzeHealth();
                DateTime date = DateTime.Now;

                string message = "Статус: \n" + report.getStatus() + "\n\nДеталі: \n" + report.getNotes() + "\nДата аналізу: " + date.ToString("dd.MM.yyyy HH:mm:ss");
                DialogResult result = MessageBox.Show(message + "\nЗберегти результат у файл?", "Результати аналізу", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK))
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.RestoreDirectory = true;
                    saveFileDialog1.FileName = "Health-Report-" + date.ToString("dd-MM-yyyy");

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                        {
                            writer.WriteLine(message);
                        }
                    }
                }
            }
        }
    }
}
