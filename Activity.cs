using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp
{
    public enum ActivityType
    {
        TIME,
        REPETITIONS
    }

    public class Activity
    {
        public string name { get; set; }

        public ActivityType type { get; set; }

        public float value { get; set; }

        public float caloriesPerUnit { get; set; }

        public float caloriesBurned { get; set; }

        public DateTime date { get; set; }

        public Activity() 
        {
            this.name = "?";
            this.type = ActivityType.TIME;
            this.value = 0;
            this.caloriesPerUnit = 0;
            this.caloriesBurned = getValue() * getCaloriesPerUnit();
            this.date = DateTime.Now;
        }

        public Activity(string name, ActivityType type, float value, float calortiesPerUnit, DateTime date)
        {
            this.name = name;
            this.type = type;
            this.value = value;
            this.caloriesPerUnit = calortiesPerUnit;
            this.caloriesBurned = value * caloriesPerUnit;
            this.date = date;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(ActivityType type)
        {
            this.type = type;
        }

        public void setValue(float value)
        {
            this.value = value;
        }

        public void setCaloriesPerUnit(float caloriesPerUnit)
        {
            this.caloriesPerUnit = caloriesPerUnit;
        }

        public void setCaloriesBurned(float value, float caloriesPerUnit)
        {
            this.caloriesBurned = value * caloriesPerUnit;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public string getName()
        {
            return this.name;
        }

        public ActivityType getType()
        {
            return this.type;
        }

        public string getTypeString()
        {
            if (this.type.Equals(ActivityType.TIME))
            {
                return "За часом";
            }
            else
            {
                return "За кількістю";
            }    
        }

        public float getValue()
        {
            return this.value;
        }

        public float getCaloriesPerUnit()
        {
            return this.caloriesPerUnit;
        }

        public float getCaloriesBurned()
        {
            return this.caloriesBurned;
        }

        public DateTime getDate()
        {
            return this.date;
        }
    }
}
