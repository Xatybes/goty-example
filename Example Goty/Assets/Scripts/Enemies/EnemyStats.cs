using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Unity References")]
    public Health healthBar;

    [Header("Atributtes")]
    public float lifes;
    public float maxLife = 5;
    public int armor = 2;
    public int goldGiven = 10;
    public int lifeCost = 1;
    void Start()
    {
        lifes = maxLife;
        
    }
    void Update()
    {
        healthBar.SetHealt(lifes, maxLife);
        checkLife();
    }

    public void checkLife()
    { 
        if (lifes <= 0)
        {           
            GoldAmount.currentGoldAmount += goldGiven;
            Destroy(gameObject);         
        }
    }
}
