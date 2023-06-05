using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroSlash : MonoBehaviour
{
    public int damageAmount = 30;  // Amount of damage the ElectroSlash does
public void Start()
{
    Destroy(gameObject,10);
}
    private void OnTriggerEnter(Collider other)
    {
        // // Check if the collider belongs to a Monster object
        // Monster monster = other.GetComponent<Monster>();
        // if (monster != null)
        // {
        //     monster.TakeDamage(damageAmount);  // Call the TakeDamage method on the Monster object
        // }

        //  // Destroy the ElectroSlash object after hitting the Monster

        //Destroy(transform.GetComponent<RigidBody>());
        if(other.tag=="Monster")
        {
            other.GetComponent<Monster>().TakeDamage(damageAmount);
        }
    }
}
