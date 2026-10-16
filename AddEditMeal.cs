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

namespace HealthApp
{
    public partial class AddEditMeal : Form
    {
        string formAction = null;
        int indexEdit = 0;
        User user = new User();
        bool darkTheme = false;

        public AddEditMeal(string action, int index)
        {
            InitializeComponent();
            formAction = action.ToLower();
            indexEdit = index;
        }

        private void AddEditMeal_Load(object sender, EventArgs e)
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

            dateTimePicker.Format = DateTimePickerFormat.Short;

            if (File.Exists("mealsdata.json") && new FileInfo("mealsdata.json").Length > 2)
            {
                string jsonStringMealsData = File.ReadAllText("mealsdata.json");
                List<Meal> mealsData = JsonSerializer.Deserialize<List<Meal>>(jsonStringMealsData) ?? new List<Meal>();

                mealComboBox.DataSource = null;
                mealComboBox.DataSource = mealsData;
                mealComboBox.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show("Відсутній файл зі стравами.\nВи можете вводити дані вручну.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mealComboBox.Items.Add("Своя страва");
            }

            mealComboBox.SelectedIndex = 0;

            string jsonStringUserDeserialize = File.ReadAllText("user.json");
            user = JsonSerializer.Deserialize<User>(jsonStringUserDeserialize);

            if (File.Exists("meals.json") && new FileInfo("meals.json").Length > 2)
            {
                string jsonStringMealsDeserialize = File.ReadAllText("meals.json");
                user.meals = JsonSerializer.Deserialize<List<Meal>>(jsonStringMealsDeserialize) ?? new List<Meal>();
            }
            else
            {
                if (!File.Exists("meals.json"))
                    File.Create("meals.json");

                user.meals = new List<Meal>();
            }
        }

        private void ThemeChange()
        {
            if (darkTheme)
            {
                this.BackColor = Color.DimGray;
                this.ForeColor = SystemColors.Control;

                accept.BackColor = Color.Gray;
                cancel.BackColor = Color.Gray;

                nameTextBox.BackColor = Color.LightGray;
                portionTextBox.BackColor = Color.LightGray;
                kcalTextBox.BackColor = Color.LightGray;
                fatTextBox.BackColor = Color.LightGray;
                carbohydratesTextBox.BackColor = Color.LightGray;
                sugarTextBox.BackColor = Color.LightGray;
                proteinTextBox.BackColor = Color.LightGray;
                saltTextBox.BackColor = Color.LightGray;
                dateTimePicker.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                accept.BackColor = Color.LightGray;
                cancel.BackColor = Color.LightGray;

                nameTextBox.BackColor = SystemColors.Window;
                portionTextBox.BackColor = SystemColors.Window;
                kcalTextBox.BackColor = SystemColors.Window;
                fatTextBox.BackColor = SystemColors.Window;
                carbohydratesTextBox.BackColor = SystemColors.Window;
                sugarTextBox.BackColor = SystemColors.Window;
                proteinTextBox.BackColor = SystemColors.Window;
                saltTextBox.BackColor = SystemColors.Window;
                dateTimePicker.BackColor = SystemColors.Window;
            }
        }

        private void mealComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealComboBox.SelectedIndex != 0)
                foreach (var tb in this.Controls.OfType<TextBox>())
                    tb.Enabled = false;
            else
                foreach (var tb in this.Controls.OfType<TextBox>())
                    tb.Enabled = true;

            if (mealComboBox.SelectedItem is Meal meal)
            {
                if (mealComboBox.SelectedIndex.Equals(0))
                {
                    nameTextBox.Text = null;
                    portionTextBox.Text = null;
                    kcalTextBox.Text = null;
                    fatTextBox.Text = null;
                    carbohydratesTextBox.Text = null;
                    sugarTextBox.Text = null;
                    proteinTextBox.Text = null;
                    saltTextBox.Text = null;
                }
                else
                {
                    nameTextBox.Text = meal.getName();
                    portionTextBox.Text = meal.getPortion().ToString();
                    kcalTextBox.Text = meal.getKcal().ToString();
                    fatTextBox.Text = meal.getFat().ToString();
                    carbohydratesTextBox.Text = meal.getCarbohydrates().ToString();
                    sugarTextBox.Text = meal.getSugar().ToString();
                    proteinTextBox.Text = meal.getProtein().ToString();
                    saltTextBox.Text = meal.getSalt().ToString();
                }
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            bool allFilled = this.Controls.OfType<TextBox>()
                             .All(tb => !string.IsNullOrWhiteSpace(tb.Text));

            if (!allFilled)
                MessageBox.Show("Всі поля повинні бути заповнені.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = nameTextBox.Text;
                float portion;
                float kcal;
                float fat;
                float carbohydrates;
                float sugar;
                float protein;
                float salt;

                if (float.TryParse(portionTextBox.Text, out portion) && portion > 0)
                {
                    if (float.TryParse(kcalTextBox.Text, out kcal) && kcal > 0)
                    {
                        if (float.TryParse(fatTextBox.Text, out fat) && fat > 0)
                        {
                            if (float.TryParse(carbohydratesTextBox.Text, out carbohydrates) && carbohydrates > 0)
                            {
                                if (float.TryParse(sugarTextBox.Text, out sugar) && sugar > 0)
                                {
                                    if (float.TryParse(proteinTextBox.Text, out protein) && protein > 0)
                                    {
                                        if (float.TryParse(saltTextBox.Text, out salt) && salt > 0)
                                        {
                                            if (formAction.Equals("edit latest"))
                                            {
                                                int indexLatest = user.getMealsLength() - 1;
                                                user.editMeals(indexLatest, name, portion, kcal, fat, carbohydrates, sugar, protein, salt, dateTimePicker.Value.Date);
                                            }
                                            else if (formAction.Equals("edit"))
                                                user.editMeals(indexEdit, name, portion, kcal, fat, carbohydrates, sugar, protein, salt, dateTimePicker.Value.Date);
                                            else if (formAction.Equals("add"))
                                                user.addMeals(name, portion, kcal, fat, carbohydrates, sugar, protein, salt, dateTimePicker.Value.Date);

                                            var options = new JsonSerializerOptions
                                            {
                                                WriteIndented = true
                                            };

                                            string jsonStringMealsSerialize = JsonSerializer.Serialize(user.meals, options);
                                            File.WriteAllText("meals.json", jsonStringMealsSerialize);

                                            this.Close();
                                        }
                                        else
                                            MessageBox.Show("Значення солі повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        MessageBox.Show("Значення білка повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("Значення цукру повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Значення вуглеводів повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Значення жирів повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Значення калорій повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Значення порції повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
