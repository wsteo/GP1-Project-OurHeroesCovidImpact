using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Stats : MonoBehaviour
{
    public float startHealth = 100;
    public int damageDeal = 10;

    public int rewardGold = 50;

    private float health;

    [Header("Default Settings")]
    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    public void TakeDamage(int DamageAmount)
    {
        health -= DamageAmount;
        healthBar.fillAmount = health / startHealth;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        WaveSpawner.EnemiesAlive--;
        PlayerStats.Money += this.rewardGold;
        Destroy(gameObject);
    }

}
