/* Personalized Meal Plan Generator
o Concepts: Generic Methods, Constraints, Interfaces
o Problem Statement: Design a system where users can choose different meal categories like Vegetarian, Vegan, Keto, or High-Protein.
o Hints:
▪ Define an interface IMealPlan with subtypes (VegetarianMeal, VeganMeal).
▪ Implement a generic class Meal<T> where T : IMealPlan.
▪ Use a generic method to validate and generate meal plans dynamically. */


using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
  public class MealPlanMain
{
    public static void Start()
    {
        Console.WriteLine("Personalized Meal Plans:\n");

        // Generate vegetarian meal
        Meal<IMealPlan>.GenerateMealPlan<VegetarianMeal>();

        // Generate vegan meal
        Meal<IMealPlan>.GenerateMealPlan<VeganMeal>();

        // Generate keto meal
        Meal<IMealPlan>.GenerateMealPlan<KetoMeal>();

        // Generate high-protein meal
        Meal<IMealPlan>.GenerateMealPlan<HighProteinMeal>();
    }
}

}