using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBombTower : MonoBehaviour
{
    public GameObject panel;
    public GameObject bombTowerPreFab;
    public Transform position;
    public static int bombTowerCost = 80;



    void OnMouseDown()
    {
        if (GoldAmount.currentGoldAmount >= bombTowerCost)
        {
            GameObject nuevaTorre;
            nuevaTorre = Instantiate(bombTowerPreFab, new Vector3(position.position.x, position.position.y, position.position.z), Quaternion.identity);
            Destroy(position.gameObject);
            nuevaTorre.SetActive(true);
            panel.SetActive(false);
            GoldAmount.currentGoldAmount -= bombTowerCost;
        }
        else
        {
            print("oro insuficiente");
        }

    }
}
