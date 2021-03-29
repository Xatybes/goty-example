using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPriority : MonoBehaviour
{
    public static GameObject[] enemyPriority;
    void Update()
    {
        enemyPriority = PriorityList();
    }

    public GameObject[] PriorityList()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < enemies.Length - 1; i++)
        {
            for (int j = 0; j < enemies.Length - 1; j++)
            {
                float distance1 = enemies[i].GetComponent<EnemyMovement>().CalculateArrivalDistance();
                float distance2 = enemies[j].GetComponent<EnemyMovement>().CalculateArrivalDistance();

                if (distance1 < distance2)
                {
                    GameObject aux = enemies[i];
                    enemies[i] = enemies[j];
                    enemies[j] = aux;
                }
            }
        }

        return enemies;
    }
}
