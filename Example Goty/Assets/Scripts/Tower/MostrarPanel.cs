using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPanel : MonoBehaviour
{
    public GameObject panel;
   

    void OnMouseDown()
    {
        if (panel.activeSelf == true)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }

            

   
    }

}
