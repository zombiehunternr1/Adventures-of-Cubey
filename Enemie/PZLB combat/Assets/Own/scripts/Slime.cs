using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour, IEnemy
{
    public int currentHealth, power, toughness;
    public int maxHealth = 20;

    void Start()
    {
        currentHealth = maxHealth;
    }


    public void PreformAttack()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDmg(int Amount)
    {
        currentHealth -= Amount;
        if (currentHealth <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
