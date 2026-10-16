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
    public partial class ActivityList : Form
    {
        User user = new User();
        bool darkTheme = false;

        public ActivityList()
        {
            InitializeComponent();
        }

        private void ActivityList_Load(object sender, EventArgs e)
        {
            LoadData();

            foreach (var tb in this.Controls.OfType<TextBox>())
                tb.Enabled = false;

            if (File.Exists("activity.json") && new FileInfo("activity.json").Length > 2)
                activityListBox.SelectedIndex = 0;
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

            if (File.Exists("activity.json") && new FileInfo("activity.json").Length > 2)
            {
                string jsonStringActivityDeserialize = File.ReadAllText("activity.json");
                user.activity = JsonSerializer.Deserialize<List<Activity>>(jsonStringActivityDeserialize) ?? new List<Activity>();

                activityListBox.DataSource = null;
                activityListBox.DataSource = user.activity;
                activityListBox.DisplayMember = "name";

                activityListBox.Enabled = true;

                editActivity.Enabled = true;
                removeActivity.Enabled = true;

                редагуватиАктивністьToolStripMenuItem.Enabled = true;
                видалитиАктивністьToolStripMenuItem.Enabled = true;

                dateTimePicker.Enabled = true;
                search.Enabled = true;
            }
            else
            {
                if (!File.Exists("activity.json"))
                    File.Create("activity.json");

                activityListBox.DataSource = null;
                activityListBox.Items.Add("Дані відсутні");
                activityListBox.Enabled = false;

                editActivity.Enabled = false;
                removeActivity.Enabled = false;

                редагуватиАктивністьToolStripMenuItem.Enabled = false;
                видалитиАктивністьToolStripMenuItem.Enabled = false;

                dateTimePicker.Enabled = false;
                search.Enabled = false;

                user.activity = new List<Activity>();
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

                addActivity.BackColor = Color.Gray;
                editActivity.BackColor = Color.Gray;
                removeActivity.BackColor = Color.Gray;
                analyzeData.BackColor = Color.Gray;

                typeTextBox.BackColor = Color.LightGray;
                valueTextBox.BackColor = Color.LightGray;
                caloriesPerUnitTextBox.BackColor = Color.LightGray;
                caloriesBurnedTextBox.BackColor = Color.LightGray;
                dateTextBox.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                this.menuStrip.BackColor = SystemColors.ControlLightLight;
                this.menuStrip.ForeColor = SystemColors.ControlText;

                addActivity.BackColor = Color.LightGray;
                editActivity.BackColor = Color.LightGray;
                removeActivity.BackColor = Color.LightGray;
                analyzeData.BackColor = Color.LightGray;

                typeTextBox.BackColor = SystemColors.Window;
                valueTextBox.BackColor = SystemColors.Window;
                caloriesPerUnitTextBox.BackColor = SystemColors.Window;
                caloriesBurnedTextBox.BackColor = SystemColors.Window;
                dateTextBox.BackColor = SystemColors.Window;
            }
        }

        private void analyze()
        {
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

            if (user.getMealsLength().Equals(0))
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

        private void AddNew()
        {
            AddEditActivity addactivity = new AddEditActivity("add", 0);
            addactivity.Text = "Нова активність: Додаток для контролю здоров'я";
            addactivity.ShowDialog();
            addactivity.Close();
            LoadData();

            if (File.Exists("meals.json") && new FileInfo("meals.json").Length > 2)
            {
                int index = activityListBox.Items.Count;
                activityListBox.SelectedIndex = index - 1;
            }
        }

        private void Edit()
        {
            int index = activityListBox.SelectedIndex;

            AddEditActivity editactivity = new AddEditActivity("edit", index);
            editactivity.Text = "Редагування активності: Додаток для контролю здоров'я";
            editactivity.ShowDialog();
            editactivity.Close();
            LoadData();

            activityListBox.SelectedIndex = index;
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("Запис обраної активності буде видалено!\nПродовжити?", "Попередження!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                int index = activityListBox.SelectedIndex;

                user.removeActivity(index);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonStringActivitySerialize = JsonSerializer.Serialize(user.activity, options);
                File.WriteAllText("activity.json", jsonStringActivitySerialize);

                LoadData();

                if (activityListBox.Items.Count > 0)
                    activityListBox.SelectedIndex = index - 1;
            }
        }

        private void addActivity_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void додатиАктивністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void editActivity_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void редагуватиАктивністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void removeActivity_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void видалитиАктивністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void activityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = activityListBox.SelectedIndex;

            if (index >= 0 && activityListBox.SelectedItem is Activity activity)
            {
                typeTextBox.Text = activity.getTypeString();
                valueTextBox.Text = activity.getValue().ToString();
                caloriesPerUnitTextBox.Text = activity.getCaloriesPerUnit().ToString();
                caloriesBurnedTextBox.Text = activity.getCaloriesBurned().ToString();
                dateTextBox.Text = activity.getDate().ToString("dd.MM.yyyy");
            }
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

            int index = user.findActivityByDate(findDate);

            if (index.Equals(-1))
                MessageBox.Show("Немає запису з такою датою.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                activityListBox.SelectedIndex = index;
        }

        private void аналізуватиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analyze();
        }
    }
}
