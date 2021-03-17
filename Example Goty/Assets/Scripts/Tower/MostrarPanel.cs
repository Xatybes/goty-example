using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject coliders;
   
   

    void OnMouseDown()
    {
        if (panel.activeSelf == true)
        {
            panel.SetActive(false);
            coliders.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
            coliders.SetActive(true);
        }
    }

   

   

}
