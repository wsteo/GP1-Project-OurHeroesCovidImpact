using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Stats : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int DamageAmount)
    {
        health -= DamageAmount;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        //Destroy(gameObject);
    }
}
