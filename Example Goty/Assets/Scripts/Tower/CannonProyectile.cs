using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonProyectile : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public float time = 1f;
    private int proyectileDmg;
    public int minDmg = 2;
    public int maxDmg = 4;
    public float SplashRange = 2f;
    public CircleCollider2D colider;
    private int checkEnemyArmor;
  
    private GameObject target;

    private void Start()
    {
        Transform shootArea = target.transform.GetChild(1).transform;

        Vector3 Vo = CalculateVelocity(shootArea.position, transform.position, time);
        colider.radius = SplashRange;
        bulletPrefab.velocity = Vo;
    }

    private void Update()
    {
        proyectileDmg = Random.Range(minDmg, maxDmg+1);
        Vector2 v = bulletPrefab.velocity;
        float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        time -= Time.deltaTime;

        if (time <= 0)
        {                   
                if (SplashRange > 0)
                {
                    var coliders = Physics2D.OverlapCircleAll(transform.position, SplashRange);
                    foreach (var hitColiders in coliders)
                    {
                        var enemy = hitColiders.GetComponent<EnemyStats>();                    
                        if (enemy)
                        {
                            checkEnemyArmor = enemy.armor;
                            var closestPoint = hitColiders.ClosestPoint(transform.position);
                            var distance = Vector3.Distance(closestPoint, transform.position);
                            var damagePercent = Mathf.InverseLerp(SplashRange, 0f, distance);
                            enemy.lifes -= ((damagePercent * proyectileDmg) - checkEnemyArmor);
                        }
                    }
                Destroy(gameObject);
            }          
            
        }
    }

   

    public void TowerTarget(GameObject _target)
    {
        target = _target;
    }

    Vector3 CalculateVelocity(Vector3 target, Vector3 origin, float time)
    {
        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0f;

        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;

        float Vxz = Sxz / time;
        float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;

        Vector3 result = distanceXZ.normalized;

        result *= Vxz;
        result.y = Vy;

        return result;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, SplashRange);
    }
}
