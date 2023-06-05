using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
   public float attackRange = 1.0f; // distance at which the enemy attacks
    public float attackCooldown = 7.0f; // time between attacks

    private float lastAttackTime = 0.0f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Check if player is within attack range
        if (Vector3.Distance(transform.position, playerTransform.position) < attackRange)
        {
            if (Time.time - lastAttackTime > attackCooldown)
            {
                // Ready to attack, deal damage to player
                playerTransform.GetComponent<PlayerHealthBar>().TakeDamage(10);
                lastAttackTime = Time.time;
            }
        }
    }
}
