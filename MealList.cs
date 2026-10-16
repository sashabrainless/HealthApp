using System;
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
using System.Windows.Forms.VisualStyles;

namespace HealthApp
{
    public partial class MealList : Form
    {
        User user = new User();
        bool darkTheme = false;

        public MealList()
        {
            InitializeComponent();
        }

        private void MealList_Load(object sender, EventArgs e)
        {
            LoadData();

            foreach (var tb in this.Controls.OfType<TextBox>())
                tb.Enabled = false;

            if (File.Exists("meals.json") && new FileInfo("meals.json").Length > 2)
                mealListBox.SelectedIndex = 0;
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

            string jsonStringUserDeserialize = File.ReadAllText("user.json");
            user = JsonSerializer.Deserialize<User>(jsonStringUserDeserialize);

            if (File.Exists("meals.json") && new FileInfo("meals.json").Length > 2)
            {
                string jsonStringMealsDeserialize = File.ReadAllText("meals.json");
                user.meals = JsonSerializer.Deserialize<List<Meal>>(jsonStringMealsDeserialize) ?? new List<Meal>();

                mealListBox.DataSource = null;
                mealListBox.DataSource = user.meals;
                mealListBox.DisplayMember = "name";

                mealListBox.Enabled = true;

                editMeal.Enabled = true;
                removeMeal.Enabled = true;

                редагуватиСтравуToolStripMenuItem.Enabled = true;
                видалитиСтравуToolStripMenuItem.Enabled = true;

                dateTimePicker.Enabled = true;
                search.Enabled = true;
            }
            else
            {
                if (!File.Exists("meals.json"))
                    File.Create("meals.json");

                mealListBox.DataSource = null;

                if (mealListBox.Items.Count < 1)
                    mealListBox.Items.Add("Дані відсутні");

                mealListBox.Enabled = false;

                editMeal.Enabled = false;
                removeMeal.Enabled = false;

                редагуватиСтравуToolStripMenuItem.Enabled = false;
                видалитиСтравуToolStripMenuItem.Enabled = false;

                dateTimePicker.Enabled = false;
                search.Enabled = false;

                user.meals = new List<Meal>();
            }
        }

        private void ThemeChange()
        {
            if (darkTheme)
            {
                this.BackColor = Color.DimGray;
                this.ForeColor = SystemColors.Control;

                this.menuStrip.BackColor = Color.Gray;
                this.menuStrip.ForeColor = SystemColors.Control;

                addMeal.BackColor = Color.Gray;
                editMeal.BackColor = Color.Gray;
                removeMeal.BackColor = Color.Gray;
                analyzeData.BackColor = Color.Gray;

                portionTextBox.BackColor = Color.LightGray;
                kcalTextBox.BackColor = Color.LightGray;
                fatTextBox.BackColor = Color.LightGray;
                carbohydratesTextBox.BackColor = Color.LightGray;
                sugarTextBox.BackColor = Color.LightGray;
                proteinTextBox.BackColor = Color.LightGray;
                saltTextBox.BackColor = Color.LightGray;
                dateTextBox.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                this.menuStrip.BackColor = SystemColors.ControlLightLight;
                this.menuStrip.ForeColor = SystemColors.ControlText;

                addMeal.BackColor = Color.LightGray;
                editMeal.BackColor = Color.LightGray;
                removeMeal.BackColor = Color.LightGray;
                analyzeData.BackColor = Color.LightGray;

                portionTextBox.BackColor = SystemColors.Window;
                kcalTextBox.BackColor = SystemColors.Window;
                fatTextBox.BackColor = SystemColors.Window;
                carbohydratesTextBox.BackColor = SystemColors.Window;
                sugarTextBox.BackColor = SystemColors.Window;
                proteinTextBox.BackColor = SystemColors.Window;
                saltTextBox.BackColor = SystemColors.Window;
                dateTextBox.BackColor = SystemColors.Window;
            }
        }

        private void analyze()
        {
            if (user.getMealsLength().Equals(0))
                MessageBox.Show("Відсутні записи про харчування.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (File.Exists("activity.json") && new FileInfo("activity.json").Length > 2)
                {
                    string jsonStringActivity = File.ReadAllText("activity.json");
                    user.activity = JsonSerializer.Deserialize<List<Activity>>(jsonStringActivity) ?? new List<Activity>();
                }
                else
                {
                    if (!File.Exists("activity.json"))
                        File.Create("activity.json");

                    user.activity = new List<Activity>();
                }

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
        private void AddNew()
        {
            AddEditMeal addmeal = new AddEditMeal("add", 0);
            addmeal.Text = "Нова страва: Додаток для контролю здоров'я";
            addmeal.ShowDialog();
            addmeal.Close();
            LoadData();

            if (File.Exists("meals.json") && new FileInfo("meals.json").Length > 2)
            {
                int index = mealListBox.Items.Count;
                mealListBox.SelectedIndex = index - 1;
            }
        }

        private void Edit()
        {
            int index = mealListBox.SelectedIndex;

            AddEditMeal editmeal = new AddEditMeal("edit", index);
            editmeal.Text = "Редагування страви: Додаток для контролю здоров'я";
            editmeal.ShowDialog();
            editmeal.Close();
            LoadData();

            mealListBox.SelectedIndex = index;
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("Запис обраної страви буде видалено!\nПродовжити?", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                int index = mealListBox.SelectedIndex;

                user.removeMeals(index);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonStringMealSerialize = JsonSerializer.Serialize(user.meals, options);
                File.WriteAllText("meals.json", jsonStringMealSerialize);

                LoadData();

                if (mealListBox.Items.Count > 0)
                    mealListBox.SelectedIndex = index - 1;
            }
        }

        private void addMeal_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void додатиСтравуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void editMeal_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void редагуватиСтравуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void mealListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = mealListBox.SelectedIndex;

            if (index >= 0 && mealListBox.SelectedItem is Meal meal)
            {
                portionTextBox.Text = meal.getPortion().ToString();
                kcalTextBox.Text = meal.getKcal().ToString();
                fatTextBox.Text = meal.getFat().ToString();
                carbohydratesTextBox.Text = meal.getCarbohydrates().ToString();
                sugarTextBox.Text = meal.getSugar().ToString();
                proteinTextBox.Text = meal.getProtein().ToString();
                saltTextBox.Text = meal.getSalt().ToString();
                dateTextBox.Text = meal.getDate().ToString("dd.MM.yyyy");
            }
        }

        private void removeMeal_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void видалитиСтравуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void analyzeData_Click(object sender, EventArgs e)
        {
            analyze();
        }

        private void search_Click(object sender, EventArgs e)
        {
            DateTime findDate = dateTimePicker.Value.Date;

            int index = user.findMealByDate(findDate);

            if (index.Equals(-1))
                MessageBox.Show("Немає запису з такою датою.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                mealListBox.SelectedIndex = index;
        }

        private void аналізуватиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analyze();
        }
    }
}
