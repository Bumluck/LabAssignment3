using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Bookstore : MonoBehaviour
{
    public float coverPrice;
    public int copiesToBuy;
    public float wholesaleCost;
    public float totalProfit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wholesaleCost = CalculateWholesale(coverPrice, copiesToBuy);
        Debug.Log("Wholesale Price: " + wholesaleCost);
        totalProfit = ProfitBeforeShipping(coverPrice, copiesToBuy, wholesaleCost);
        totalProfit -= CalculateShipping(copiesToBuy);
        Debug.Log("Profit: " + totalProfit);
    }

    float CalculateWholesale(float price, int copies)
    {
        float wholesale = 0;
        price = price * 0.6f;
        wholesale = price * copies;
        return wholesale;
    }

    float ProfitBeforeShipping(float price, int copies, float wholesale)
    {
        float profit = 0;
        profit = copies * price;
        profit -= wholesale;
        return profit;
    }

    //Subtract one from the copies to buy if the copies to buy is above 0 multiply the remaining amount by .75
    float CalculateShipping(int copies)
    {
        float shippingCost = 0;
        if (copies > 0)
        {
            shippingCost += 3;
            copies -= 1;
            if (copies > 0)
            {
                shippingCost += (copies * 0.75f);
            }
        }

        return shippingCost;
    }
}
