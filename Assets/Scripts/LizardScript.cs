using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        
        if(otherObject.GetComponent<defenderScript>())
        {
            GetComponent<AttackerScript>().Attack(otherObject);
        }
    }
}
