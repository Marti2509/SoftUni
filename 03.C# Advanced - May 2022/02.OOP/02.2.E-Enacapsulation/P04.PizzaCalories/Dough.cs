using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType; // white or wholegrain
        private string bakingTechnique; // crispy or chewy or homemade
        private int grams; // 1 - 200
        private double calories;

        private const double whiteCal = 1.5; // grams
        private const double wholegrainCal = 1.0; // grams
        private const double crispyCal = 0.9; // grams
        private const double chewyCal = 1.1; // grams
        private const double homemadeCal = 1.0; // grams

        public Dough(string flourType, string bakingTechnique, int grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
            Calories = calories;
        }

        public string FlourType
        {
            get { return flourType; }
            private set 
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    flourType = value; 
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set 
            {
                if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public int Grams
        {
            get { return grams; }
            set 
            {
                if (value >= 1 && value <= 200)
                {
                    grams = value; 
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }

        public double Calories
        {
            get { return calories; }
            set 
            {
                value = CalcCal(Grams);
                calories = value;
            }
        }


        private double CalcCal(int grams)
        {
            double calories = 2 * grams;

            if (FlourType.ToLower() == "white")
            {
                calories *= whiteCal;
            }
            else if (FlourType.ToLower() == "wholegrain")
            {
                calories *= wholegrainCal;
            }

            if (BakingTechnique.ToLower() == "crispy")
            {
                calories *= crispyCal;
            }
            else if (BakingTechnique.ToLower() == "chewy")
            {
                calories *= chewyCal;
            }
            else if (BakingTechnique.ToLower() == "homemade")
            {
                calories *= homemadeCal;
            }

            return calories;
        }
    }
}
