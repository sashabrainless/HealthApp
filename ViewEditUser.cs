using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace HealthApp
{
    public partial class ViewEditUser : Form
    {
        string formAction = null;
        bool darkTheme = false;

        public ViewEditUser(string action)
        {
            InitializeComponent();
            formAction = action.ToLower();
        }

        private void ViewEditUser_Load(object sender, EventArgs e)
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

            genderComboBox.Items.Clear();
            genderComboBox.Items.Add("Чоловік");
            genderComboBox.Items.Add("Жінка");
            genderComboBox.SelectedIndex = 0;

            if (!formAction.Equals("create"))
            {
                if (formAction.Equals("view"))
                {
                    foreach (var tb in this.Controls.OfType<TextBox>())
                        tb.Enabled = false;

                    accept.Visible = false;
                    genderComboBox.Enabled = false;
                }
                else
                {
                    foreach (var tb in this.Controls.OfType<TextBox>())
                        tb.Enabled = true;

                    accept.Visible = true;
                    genderComboBox.Enabled = true;
                }

                string jsonStringUserDeserialize = File.ReadAllText("user.json");
                User user = new User();
                user = JsonSerializer.Deserialize<User>(jsonStringUserDeserialize);

                nameTextBox.Text = user.getName();
                ageTextBox.Text = user.getAge().ToString();
                heightTextBox.Text = user.getHeight().ToString();
                weightTextBox.Text = user.getWeight().ToString();

                if (user.getGender().Equals("Чоловік"))
                    genderComboBox.SelectedIndex = 0;
                else
                    genderComboBox.SelectedIndex = 1;
            }
            else
                genderComboBox.Enabled = true;
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
                ageTextBox.BackColor = Color.LightGray;
                heightTextBox.BackColor = Color.LightGray;
                weightTextBox.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                accept.BackColor = Color.LightGray;
                cancel.BackColor = Color.LightGray;

                nameTextBox.BackColor = SystemColors.Window;
                ageTextBox.BackColor = SystemColors.Window;
                heightTextBox.BackColor = SystemColors.Window;
                weightTextBox.BackColor = SystemColors.Window;
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (!formAction.Equals("view"))
            {
                bool allFilled = this.Controls.OfType<TextBox>()
                             .All(tb => !string.IsNullOrWhiteSpace(tb.Text));

                User user = new User();

                if (!allFilled)
                    MessageBox.Show("Всі поля повинні бути заповнені.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string name = nameTextBox.Text;
                    int age;
                    float height;
                    float weight;

                    if (int.TryParse(ageTextBox.Text, out age) && age > 0)
                    {
                        if (float.TryParse(heightTextBox.Text, out height) && height > 0)
                        {
                            if (float.TryParse(weightTextBox.Text, out weight) && weight > 0)
                            {
                                user.setName(name);
                                user.setAge(age);
                                user.setHeight(height);
                                user.setWeight(weight);

                                if (genderComboBox.SelectedIndex.Equals(0))
                                    user.setGender("Чоловік");
                                else
                                    user.setGender("Жінка");

                                var options = new JsonSerializerOptions
                                {
                                    WriteIndented = true
                                };

                                string jsonStringUserSerialize = JsonSerializer.Serialize(new { user.name, user.age, user.height, user.weight, user.gender }, options);
                                File.WriteAllText("user.json", jsonStringUserSerialize);

                                this.Close();
                            }
                            else
                                MessageBox.Show("Значення ваги повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Значення зрісту повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Значення віку повинне бути числом та більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
