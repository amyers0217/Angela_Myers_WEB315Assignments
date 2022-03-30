using System;

public class FoodItem
{
    public int ID { get; set; }
    public int Quantity { get; set; }
    public string FoodName { get; set;}
    public string FoodType { get; set; }
    public string OrganicOption { get; set; } 

    public void QuantityIncrease()
    {
        if (Quantity < 20)
        Quantity++;
    }              

    public void QuantityDecrease()
    {
        if (Quantity > 0)
        Quantity--;
    }                                                                                                                                          
}                 