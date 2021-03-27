using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButtonScript : MonoBehaviour
{
    [SerializeField] defenderScript defenderPrefab;

    private void Start()
    {
        LabelButtonWithScript();
    }

    private void LabelButtonWithScript()
    {
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            Debug.LogError(name + "has no cost text");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButtonScript>();
        foreach (DefenderButtonScript button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(70, 70, 70, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;

        FindObjectOfType<DefenderSpawnerScript>().SetSelectedDefender(defenderPrefab);
    }
}
