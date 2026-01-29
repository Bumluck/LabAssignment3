using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BillCounter : MonoBehaviour
{
    public float total;

    public List<Denominations> denominationsList;

    private void Start()
    {
        CounterLoop(total);
    }

    void CounterLoop(float total)
    {
        for (int i = 0; i < denominationsList.Count; i++)
        {
            total = PrintAndRemoveMod(total, denominationsList[i].denomination, denominationsList[i].denominationString);
        }
    }



    float PrintAndRemoveMod (float total, float divisor, string denomination)
    {
        float newTotal;
        int x;

        x = (int)(total / divisor);
        newTotal = total % divisor;

        float shifted = newTotal * 100;
        float roundShifted = Mathf.Round(shifted);
        newTotal = roundShifted / 100;

        Debug.Log(x + " " + denomination);

        return newTotal;
    }
}
