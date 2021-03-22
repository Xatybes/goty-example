using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float lifes;
    public float maxLife = 5;
    public int armor = 2;

    public Health healthBar;

    void Start()
    {
        lifes = maxLife;
        
    }
    void Update()
    {
        healthBar.SetHealt(lifes, maxLife);
    }

    public void checkLife()
    {
        lifes-=Proyectile.proyectileDmg-armor;
        
        if (lifes <= 0)
        {
            Destroy(gameObject,0.1f);
            GoldAmount.currentGoldAmount += 10;
        }
    }
}
