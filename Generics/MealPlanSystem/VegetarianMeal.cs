using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    // Vegetarian meal plan
class VegetarianMeal : IMealPlan
{
    public void DisplayMeal()
    {
        Console.WriteLine("Vegetarian Meal: Veg curry, rice, salad");
    }
}
}