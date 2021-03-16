using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildArcherTower : MonoBehaviour
{
    public GameObject panel;
    public GameObject archerTowerPreFab;
    public Transform position;
    public static int archerTowerCost = 50;
   
    public GameObject statsPanel;
   

   
    

  



    void OnMouseDown()
    {
        
        if (GoldAmount.currentGoldAmount >= archerTowerCost)
        {
            GameObject nuevaTorre;
            nuevaTorre = Instantiate(archerTowerPreFab, new Vector3(position.position.x, position.position.y, position.position.z), Quaternion.identity);
            Destroy(position.gameObject);
            nuevaTorre.SetActive(true);
            panel.SetActive(false);
            GoldAmount.currentGoldAmount -= archerTowerCost;
        }
        else
        {
            print("oro insuficiente");
        }
       
    }

    void OnMouseEnter()
    {
        statsPanel.SetActive(true);
    }

    void OnMouseExit()
    {
        statsPanel.SetActive(false);
    }
}
