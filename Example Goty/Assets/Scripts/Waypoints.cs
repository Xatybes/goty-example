using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;

    public static float routMagnitud;

    void Awake()
    {
        points = new Transform[transform.childCount];
        for(int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }

        for (int i = 0; i < points.Length - 1; i++)
        {
            routMagnitud += Vector3.Distance(points[i].transform.position, points[i+1].transform.position);

        }
    }
}
