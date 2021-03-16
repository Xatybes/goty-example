using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellTower : MonoBehaviour
{
    public GameObject panel;
    public GameObject towerSpawnPreFab;
    public Transform posicion;



    void OnMouseDown()
    {
        if (posicion.gameObject.CompareTag("BombTower") == true)
        {
            sellTower();
            GoldAmount.currentGoldAmount += BuildBombTower.bombTowerCost / 2;
        }

        if (posicion.gameObject.CompareTag("ArcherTower") == true)
        {
            sellTower();
            GoldAmount.currentGoldAmount += BuildArcherTower.archerTowerCost / 2;
        }

    }


    private void sellTower()
    {
        GameObject nuevaTorre;
        nuevaTorre = Instantiate(towerSpawnPreFab, new Vector3(posicion.position.x, posicion.position.y, posicion.position.z), Quaternion.identity);
        Destroy(posicion.gameObject);
        nuevaTorre.SetActive(true);
        panel.SetActive(false);
    }

}
