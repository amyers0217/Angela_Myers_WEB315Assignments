using System.Collections.Generic;

public class GroceryIsle
{
    public List<FoodItem> listOfFoodItem { get; set; }
    public string IsleName { get; set; }
    public int IsleNumber { get; set; }

    public GroceryIsle()
    {
        listOfFoodItem = new List<FoodItem>();
    }

    public void NewFood(FoodItem newFoodItems)
    {
        listOfFoodItem.Add(newFoodItems);
    }
}