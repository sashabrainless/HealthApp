using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp
{
    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public string gender { get; set; }
        public List<Activity> activity { get; set; } = new List<Activity> ();
        public List<Meal> meals { get; set; } = new List<Meal>();

        protected HealthReport report = new HealthReport();

        public User() 
        {
            this.name = "?";
            this.age = 0;
            this.height = 0;
            this.weight = 0;
            this.gender = "?";
        }

        public User(string name, int age, float height, float weight, string gender) 
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.gender = gender;
        }

        public void setName(string name) 
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setHeight(float height)
        {
            this.height = height; 
        }

        public void setWeight(float weight)
        {
            this.weight = weight;
        }

        public void setGender (string gender)
        {
            this.gender = gender; 
        }

        public void addMeals(string name, float portion, float kcal, float fat, float carbohydrates, float sugar, float protein, float salt, DateTime date)
        {
            meals.Add(new Meal(name, portion, kcal, fat, carbohydrates, sugar, protein, salt, date));

            sortMealsByDate();
        }

        public void editMeals(int index, string name, float portion, float kcal, float fat, float carbohydrates, float sugar, float protein, float salt, DateTime date)
        {
            meals[index].setName(name);
            meals[index].setPortion(portion);
            meals[index].setKcal(kcal);
            meals[index].setFat(fat);
            meals[index].setCarbohydrates(carbohydrates);
            meals[index].setSugar(sugar);
            meals[index].setProtein(protein);
            meals[index].setSalt(salt);
            meals[index].setDate(date);

            sortMealsByDate();
        }

        public void removeMeals(int index)
        {
            meals.RemoveAt(index);
        }

        public void removeLastMeal()
        {
            int index = this.getMealsLength() - 1;
            meals.RemoveAt(index);
        }

        public void addActivity(string name, ActivityType type, float value, float calortiesPerUnit, DateTime date)
        {
            activity.Add(new Activity(name, type, value, calortiesPerUnit, date));

            sortActivityByDate();
        }

        public void editActivity(int index, string name, ActivityType type, float value, float calortiesPerUnit, DateTime date)
        {
            activity[index].setName(name);
            activity[index].setType(type);
            activity[index].setValue(value);
            activity[index].setCaloriesPerUnit(calortiesPerUnit);
            activity[index].setCaloriesBurned(value, calortiesPerUnit);
            activity[index].setDate(date);

            sortActivityByDate();
        }

        public void removeActivity(int index)
        {
            activity.RemoveAt(index);
        }

        public void removeLastActivity()
        {
            int index = this.getActivityLength() - 1;
            activity.RemoveAt(index);
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public float getHeight()
        {
            return this.height;
        }

        public float getWeight()
        {
            return this.weight;
        }

        public string getGender()
        {
            return this.gender;
        }

        public int getMealsLength()
        {
            return this.meals.Count;
        }

        public int getActivityLength()
        {
            return this.activity.Count;
        }

        public HealthReport analyzeHealth()
        {
            DateTime fromDate = DateTime.Today.AddDays(-6);

            report.status = null;
            report.notes.Clear();

            var meals7Days = meals
                .Where(m => m.getDate() >= fromDate)
                .ToList();

            var activity7Days = activity
                .Where(a => a.getDate() >= fromDate)
                .ToList();

            float avgKcalIn = meals7Days.Any()
                ? meals7Days.Sum(m => m.getKcal()) / 7
                : 0;

            float avgActivityCalories = activity7Days.Any()
                ? activity7Days.Sum(a => a.getCaloriesBurned()) / 7
                : 0;

            float BMR;

            if (gender.Equals("Чоловік"))
                BMR = 24 * weight;
            else
                BMR = 22 * weight;

            float avgTotalCaloriesOut = BMR + avgActivityCalories;

            float kcalBalance = avgKcalIn - avgTotalCaloriesOut;

            float avgProtein = meals7Days.Any()
                ? meals7Days.Sum(m => m.getProtein()) / 7
                : 0;

            float avgSugar = meals7Days.Any()
                ? meals7Days.Sum(m => m.getSugar()) / 7
                : 0;

            float avgSalt = meals7Days.Any()
                ? meals7Days.Sum(m => m.getSalt()) / 7
                : 0;

            int activeDays = activity7Days
                .Select(a => a.getDate())
                .Distinct()
                .Count();

            int score = 0;

            if (Math.Abs(kcalBalance) <= 200)
                score++;
            else
                report.setNotes("Калорійний баланс не збалансований");

            if (activity7Days.Any())
            {
                if (activeDays >= 3)
                    score++;
                else
                    report.setNotes("Недостатньо фізичної активності");
            }
            else
            {
                report.setNotes("Фізична активність відсутня");
            }

            if (avgProtein >= 0.8f * weight)
                score++;
            else
                report.setNotes("Низьке споживання білка");

            if (avgSugar <= 50)
                score++;
            else
                report.setNotes("Забагато цукру");

            if (avgSalt <= 5)
                score++;
            else
                report.setNotes("Забагато солі");

            if (score >= 4)
                report.setStatus("Загальний стан добрий");
            else if (score >= 2)
                report.setStatus("Стан задовільний");
            else
                report.setStatus("Потрібно звернути увагу");

            return report;
        }

        private void sortMealsByDate()
        {
            meals = meals
                .OrderBy(m => m.date)
                .ToList();
        }

        private void sortActivityByDate()
        {
            activity = activity
                .OrderBy(a => a.date)
                .ToList();
        }

        public int findMealByDate(DateTime searchDate)
        {
            int index = meals
                .FindIndex(m => m.date.Equals(searchDate));
            return index;
        }

        public int findActivityByDate(DateTime searchDate)
        {
            int index = activity
                .FindIndex(a => a.date.Equals(searchDate));
            return index;
        }
    }
}
