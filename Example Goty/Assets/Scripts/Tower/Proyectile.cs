using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public GameObject target;
    public float time = 1f;
    public static int proyectileDmg;

    private void Start()
    {
        Transform shootArea = target.transform.GetChild(1).transform;

        Vector3 Vo = CalculateVelocity(shootArea.position, transform.position, time);

        bulletPrefab.velocity = Vo;
    }

    private void Update()
    {
        proyectileDmg = Random.Range(4, 9);
        Vector2 v = bulletPrefab.velocity;
        float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        time -= Time.deltaTime;

        if (time <= 0)
        {
            if (target != null)
            {
                target.transform.GetComponent<EnemyStats>().checkLife();
            }
            Destroy(gameObject);
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
}
