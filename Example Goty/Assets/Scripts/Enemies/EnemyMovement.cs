using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Unity References")]
    public Rigidbody2D rb2D;

    public SpriteRenderer spriteRenderer;

    public Transform shotArea;

    [Header("Atributtes")]
    public float moveSpeed = 0.5f;


    private Transform target;
    private Vector2 dir;
    private int wavePointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        dir = target.position - transform.position;
        rb2D.velocity = dir.normalized * moveSpeed;

        Vector3 v = rb2D.velocity;

        shotArea.position = transform.position + v;

        if (Vector2.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wavePointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            LoseLives.lives -= GetComponent<EnemyStats>().lifeCost;
            return;
        }
        wavePointIndex++;
        target = Waypoints.points[wavePointIndex];
    }

    public float CalculateArrivalDistance()
    {
        //Calculo la magnitud de la ruta que va recorriendo desde su posicion actual hasta el waypoint al que se dirige
        float distance = 0;

        distance += Vector3.Distance(transform.position, target.position);

        //Le sumo la magnitud de la distancia entre los waypoints que le falta recorrer
        for (int i = wavePointIndex; i < Waypoints.points.Length - 1; i++)
        {
            distance += Vector3.Distance(Waypoints.points[i].position, Waypoints.points[i+1].position);
        }

        return distance;
    }
}