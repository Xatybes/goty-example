using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{

    public float speed = 2;

    public float lifeTime = 3;


    private void Start()
    {
        Destroy(gameObject, lifeTime);

    }

    private void Update()
    {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("katraski");
        if (collision.transform.CompareTag("Enemy"))
        {
            print("katraskichupapenericolargo");
            Destroy(gameObject);
        }
    }
}
