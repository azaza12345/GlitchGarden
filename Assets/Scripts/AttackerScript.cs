using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerScript : MonoBehaviour
{

    [Range(0f, 5f)] float currentSpeed = 1f;
    GameObject currentTarget;
    
    private void Awake()
    {
        FindObjectOfType<LevelControllerScript>().AttackerSpawned();
    }

    private void OnDestroy()
    {
        LevelControllerScript levelController = FindObjectOfType<LevelControllerScript>();
        if(levelController != null)
        {
            levelController.AttackerKilled();
        }
        
    }

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if(!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(int damage)
    {
        if(!currentTarget) { return; }
        healthScript health = currentTarget.GetComponent<healthScript>();
        if(health)
        {
            health.DealDamage(damage);
        }
    }
}
