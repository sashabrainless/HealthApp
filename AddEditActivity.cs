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
    public partial class AddEditActivity : Form
    {
        string formAction = null;
        int indexEdit = 0;
        User user = new User();
        ActivityType activityType = new ActivityType();
        bool darkTheme = false;
        float value;
        float caloriesPerUnit;

        public AddEditActivity(string action, int index)
        {
            InitializeComponent();
            formAction = action.ToLower();
            indexEdit = index;
        }

        private void AddEditActivity_Load(object sender, EventArgs e)
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
            caloriesBurnedTextBox.Enabled = false;

            if (File.Exists("activitydata.json") && new FileInfo("activitydata.json").Length > 2)
            {
                string jsonStringActivityData = File.ReadAllText("activitydata.json");
                List<Activity> activityData = JsonSerializer.Deserialize<List<Activity>>(jsonStringActivityData) ?? new List<Activity>();

                activityComboBox.DataSource = null;
                activityComboBox.DataSource = activityData;
                activityComboBox.DisplayMember = "name";

                typeComboBox.Items.Add("За часом");
                typeComboBox.Items.Add("За кількістю");

                typeComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Відсутній файл з активностями.\nВи можете вводити дані вручну.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityComboBox.Items.Add("Своя активність");
            }

            activityComboBox.SelectedIndex = 0;

            string jsonStringUserDeserialize = File.ReadAllText("user.json");
            user = JsonSerializer.Deserialize<User>(jsonStringUserDeserialize);

            if (File.Exists("activity.json") && new FileInfo("activity.json").Length > 2)
            {
                string jsonStringActivityDeserialize = File.ReadAllText("activity.json");
                user.activity = JsonSerializer.Deserialize<List<Activity>>(jsonStringActivityDeserialize) ?? new List<Activity>();
            }
            else
            {
                if (!File.Exists("activity.json"))
                    File.Create("activity.json");

                user.activity = new List<Activity>();
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
                valueTextBox.BackColor = Color.LightGray;
                caloriesPerUnitTextBox.BackColor = Color.LightGray;
                caloriesBurnedTextBox.BackColor = Color.LightGray;
                dateTimePicker.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                accept.BackColor = Color.LightGray;
                cancel.BackColor = Color.LightGray;

                nameTextBox.BackColor = SystemColors.Window;
                valueTextBox.BackColor = SystemColors.Window;
                caloriesPerUnitTextBox.BackColor = SystemColors.Window;
                caloriesBurnedTextBox.BackColor = SystemColors.Window;
                dateTimePicker.BackColor = SystemColors.Window;
            }
        }

        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activityComboBox.SelectedIndex != 0)
            {
                nameTextBox.Enabled = false;
                caloriesPerUnitTextBox.Enabled = false;
                typeComboBox.Enabled = false;
            }
            else
            {
                nameTextBox.Enabled = true;
                caloriesPerUnitTextBox.Enabled = true;
                typeComboBox.Enabled = true;
            }

            if (activityComboBox.SelectedItem is Activity activity)
            {
                if (activityComboBox.SelectedIndex.Equals(0))
                {
                    nameTextBox.Text = null;
                    valueTextBox.Text = null;
                    caloriesPerUnitTextBox.Text = null;
                    caloriesBurnedTextBox.Text = null;
                }
                else
                {
                    nameTextBox.Text = activity.getName();
                    caloriesPerUnitTextBox.Text = activity.getCaloriesPerUnit().ToString();
                    float calories = activity.getValue() * activity.getCaloriesPerUnit();
                    caloriesBurnedTextBox.Text = calories.ToString();

                    if (activity.getType().Equals(ActivityType.TIME))
                        typeComboBox.SelectedIndex = 0;
                    else
                        typeComboBox.SelectedIndex = 1;
                }
            }
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(valueTextBox.Text, out value) && value > 0)
            {
                if (float.TryParse(caloriesPerUnitTextBox.Text, out caloriesPerUnit) && caloriesPerUnit > 0)
                {
                    if (!string.IsNullOrWhiteSpace(valueTextBox.Text) && !string.IsNullOrWhiteSpace(caloriesPerUnitTextBox.Text))
                    {
                        float calories = value * caloriesPerUnit;
                        caloriesBurnedTextBox.Text = calories.ToString();
                    }
                    else
                        caloriesBurnedTextBox.Text = null;
                }
                else
                    caloriesBurnedTextBox.Text = null;
            }
            else
                caloriesBurnedTextBox.Text = null;
        }

        private void caloriesPerUnitTextBox_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(valueTextBox.Text, out value) && value > 0)
            {
                if (float.TryParse(caloriesPerUnitTextBox.Text, out caloriesPerUnit) && caloriesPerUnit > 0)
                {
                    if (!string.IsNullOrWhiteSpace(valueTextBox.Text) && !string.IsNullOrWhiteSpace(caloriesPerUnitTextBox.Text))
                    {
                        float calories = value * caloriesPerUnit;
                        caloriesBurnedTextBox.Text = calories.ToString();
                    }
                    else
                        caloriesBurnedTextBox.Text = null;
                }
                else
                    caloriesBurnedTextBox.Text = null;
            }
            else
                caloriesBurnedTextBox.Text = null;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (float.TryParse(valueTextBox.Text, out value) && value > 0)
                {
                    if (float.TryParse(caloriesPerUnitTextBox.Text, out caloriesPerUnit) && caloriesPerUnit > 0)
                    {
                        if (formAction.Equals("edit latest"))
                        {
                            int indexLatest = user.getActivityLength() - 1;

                            user.editActivity(indexLatest, name, activityType, value, caloriesPerUnit, dateTimePicker.Value.Date);
                        }
                        else if (formAction.Equals("edit"))
                            user.editActivity(indexEdit, name, activityType, value, caloriesPerUnit, dateTimePicker.Value.Date);
                        else if (formAction.Equals("add"))
                            user.addActivity(name, activityType, value, caloriesPerUnit, dateTimePicker.Value.Date);

                        var options = new JsonSerializerOptions
                        {
                            WriteIndented = true
                        };

                        string jsonStringActivitySerialize = JsonSerializer.Serialize(user.activity, options);
                        File.WriteAllText("activity.json", jsonStringActivitySerialize);

                        this.Close();
                    }
                }
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (typeComboBox.SelectedIndex.Equals(0))
                activityType = ActivityType.TIME;
            else
                activityType = ActivityType.REPETITIONS;
        }
    }
}
