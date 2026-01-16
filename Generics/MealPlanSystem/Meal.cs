using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    // Generic meal class restricted to IMealPlan
class Meal<T> where T : IMealPlan, new()
{
    // Generates and validates the meal plan
    public static void GenerateMealPlan<U>() where U : IMealPlan, new()
    {
        // Create meal instance dynamically
        U meal = new U();
        meal.DisplayMeal();
    }
}
}