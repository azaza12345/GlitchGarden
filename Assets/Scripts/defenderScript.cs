using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenderScript : MonoBehaviour
{
    [SerializeField] int starCost = 100;

    public void AddStars(int amount)
    {
        FindObjectOfType<starDisplayScript>().AddStars(amount);
    }

    public int GetStarCost()
    {
        return starCost;
    }
}
