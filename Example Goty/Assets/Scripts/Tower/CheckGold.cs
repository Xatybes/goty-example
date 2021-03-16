using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGold : MonoBehaviour
{
    public GameObject ArcherLocked;
    public GameObject BombLocked;
    public GameObject archerTowerIcon;
    public GameObject bombTowerIcon;
    private int currentGold;

    void Update()
    {
        currentGold = GoldAmount.currentGoldAmount;

        if (currentGold >= BuildArcherTower.archerTowerCost)
        {


            archerTowerIcon.SetActive(true);
            ArcherLocked.SetActive(false);
        }
        else
        {

            archerTowerIcon.SetActive(false);
            ArcherLocked.SetActive(true);
        }


        if (currentGold >= BuildBombTower.bombTowerCost)
        {


            bombTowerIcon.SetActive(true);
            BombLocked.SetActive(false);
        }
        else
        {

            bombTowerIcon.SetActive(false);
            BombLocked.SetActive(true);
        }

    }
}
