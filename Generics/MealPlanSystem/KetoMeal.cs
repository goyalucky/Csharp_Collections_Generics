using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    // Keto meal plan
class KetoMeal : IMealPlan
{
    public void DisplayMeal()
    {
        Console.WriteLine("Keto Meal: Eggs, cheese, avocado");
    }
}
}