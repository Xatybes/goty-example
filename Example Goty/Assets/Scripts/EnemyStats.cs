using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int lifes = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerDamage"))
        {
            checkLife();
        }
    }

    void checkLife()
    {
        lifes--;

        if (lifes == 0)
        {
            Destroy(gameObject);
        }
    }
}
