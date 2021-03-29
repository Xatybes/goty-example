using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTowerAttack : MonoBehaviour
{
    [Header("Unity References")]
    public GameObject bulletPrefab;
    public Transform firePoint;

    [Header("Atributtes")]
    public float range = 3f;
    public float fireRate = 1f;

    private GameObject target;
    private float fireCountdown = 0f;

    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.1f);
    }

    private void UpdateTarget()
    {
        GameObject[] enemies = EnemyPriority.enemyPriority;

        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.GetChild(1).transform.position);
                if (distanceToEnemy <= range)
                {
                    target = enemy;
                    break;
                }
                else
                {
                    target = null;
                }
            }

        }
    }

    private void Update()
    {
        if (target == null)
        {
            return;
        }

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, range);
    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        CannonProyectile bullet = bulletGo.GetComponent<CannonProyectile>();

        if (bullet != null)
        {
            bullet.TowerTarget(target);
        }
    }

}
