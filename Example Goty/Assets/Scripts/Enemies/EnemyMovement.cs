using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    public SpriteRenderer spriteRenderer;

    public float moveSpeed = 0.5f;

    private Transform target;

    private int wavePointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized*moveSpeed * Time.deltaTime,Space.World);

        if(Vector2.Distance(transform.position,target.position)<= 0.4f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if(wavePointIndex>=Waypoints.points.Length-1 )
        {
            Destroy(gameObject);
            LoseLives.lives--;
            return;
        }
        wavePointIndex++;
        target = Waypoints.points[wavePointIndex];
    }
}