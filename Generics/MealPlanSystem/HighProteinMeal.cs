using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    // High-protein meal plan
class HighProteinMeal : IMealPlan
{
    public void DisplayMeal()
    {
        Console.WriteLine("High-Protein Meal: Grilled chicken, beans");
    }
}
}