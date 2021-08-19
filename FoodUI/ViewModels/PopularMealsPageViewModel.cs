using System;
using System.Collections.ObjectModel;
using FoodUI.Models;

namespace FoodUI.ViewModels
{
    //implements properties and commands for views to bind data
    public class PopularMealsPageViewModel
    {
        //observablecollection used for notifications when tems are added or refreshed
        public ObservableCollection<Recommended> recommended { get; set; }
        public ObservableCollection<PopularMeals> popularMeals { get; set; }
        public PopularMealsPageViewModel()
        {
            //observable collection for popular meals 
            popularMeals = new ObservableCollection<PopularMeals>
                {
                   new PopularMeals { Name="Vegan", Rating="9/10", Picture="veganm.jpg" },
                   new PopularMeals { Name="High Protein, Low Carb", Rating="8/10", Picture="ketom.jpg" },
                   new PopularMeals { Name="Balanced", Rating="9/10", Picture="balancedm.jpg" }
                   
                };
            //observable collection for recommended meal plans
            recommended = new ObservableCollection<Recommended>
            {
                new Recommended { Name="Balanced", Description="No restrictions", Picture="balancedm.jpg" },
                new Recommended { Name="Pescaterian", Description="No read meat", Picture="pesc.jpg" }
            };
        }
    }
}
