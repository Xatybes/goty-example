using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public float radio=1f;
    public float cdAttack = 1.5f;
    public float currectCdAttack = 0;
    public float distance = 1f;
    
    void Start()
    {
        currectCdAttack = 0;
    }

    void Update()
    {
        currectCdAttack -= Time.deltaTime;
    }

    private void FixedUpdate()
    {
        RaycastHit2D raycast = Physics2D.CircleCast(transform.position, radio, Vector2.one, distance);

        if (raycast.collider != null)
        {
            if (raycast.collider.CompareTag("Enemy") && currectCdAttack<0)
            {
                currectCdAttack = cdAttack;
            }
        }
    }
}
