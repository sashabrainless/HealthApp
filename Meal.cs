using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp
{
    public class Meal
    {
        public string name { get; set; }
        public float portion { get; set; }
        public float kcal { get; set; }
        public float fat { get; set; }
        
        public float carbohydrates { get; set; }
        
        public float sugar { get; set; }
        public float protein { get; set; }
        public float salt { get; set; }
        public DateTime date { get; set; }

        public Meal()
        {
            this.name = "?";
            this.portion = 0;
            this.kcal = 0;
            this.fat = 0;
            this.carbohydrates = 0;
            this.sugar = 0;
            this.protein = 0;
            this.salt = 0;
            this.date = DateTime.Now;
        }

        public Meal (string name, float portion, float kcal, float fat, float carbohydrates, float sugar, float protein, float salt, DateTime date)
        {
            this.name = name;
            this.portion = portion;
            this.kcal = kcal;
            this.fat = fat;
            this.carbohydrates = carbohydrates;
            this.sugar = sugar;
            this.protein = protein;
            this.salt = salt;
            this.date = date;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setPortion(float portion)
        {
            this.portion = portion;
        }

        public void setKcal(float kcal)
        { 
            this.kcal = kcal; 
        }

        public void setFat (float fat)
        { 
            this.fat = fat; 
        }

        public void setCarbohydrates(float carbohydrates)
        {
            this.carbohydrates = carbohydrates;
        }

        public void setSugar (float sugar)
        { 
            this.sugar = sugar;
        }

        public void setProtein (float protein)
        {
            this.protein = protein; 
        }

        public void setSalt(float salt)
        {
            this.salt = salt;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public string getName()
        {
            return this.name;
        }

        public float getPortion()
        {
            return this.portion;
        }

        public float getKcal()
        {
            return this.kcal;
        }

        public float getFat() 
        {
            return this.fat;
        }

        public float getCarbohydrates() {
            return this.carbohydrates;
        }

        public float getSugar() 
        {
            return this.sugar;
        }

        public float getProtein()
        {
            return this.protein;
        }

        public float getSalt()
        {
            return this.salt;
        }

        public DateTime getDate()
        {
            return this.date;
        }
    }
}
