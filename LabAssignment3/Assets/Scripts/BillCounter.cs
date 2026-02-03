using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BillCounter : MonoBehaviour
{
    public int total;

    public List<Denominations> denominationsList;

    private void Start()
    {
        if (total < 1)
        {
            total = 1;
            Debug.Log("Invalid entry, setting total to the default of 1...");
        }
        CounterLoop(total);
    }

    void CounterLoop(int total)
    {
        for (int i = 0; i < denominationsList.Count; i++)
        {
            total = PrintAndRemoveMod(total, denominationsList[i].denomination, denominationsList[i].denominationString);
        }
    }

    int PrintAndRemoveMod (int total, int divisor, string denomination)
    {
        int newTotal;
        int x;

        x = (int)(total / divisor);
        newTotal = total % divisor;

        if (x > 0)
        {
            Debug.Log(x + " " + denomination);
        }
        return newTotal;
    }
}
