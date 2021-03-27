using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5f;
    [SerializeField] int damage = 20;

    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<healthScript>();
        var attacker = otherCollider.GetComponent<AttackerScript>();

        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }


    }

}
