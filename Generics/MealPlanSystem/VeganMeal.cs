using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    // Vegan meal plan
class VeganMeal : IMealPlan
{
    public void DisplayMeal()
    {
        Console.WriteLine("Vegan Meal: Tofu, quinoa, vegetables");
    }
}
}