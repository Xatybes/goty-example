using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPanelOptions : MonoBehaviour
{
    public GameObject panelOptions;

    public void PanelOptions()
    {
        Time.timeScale = 0;
        panelOptions.SetActive(true);
    }

    public void Return()
    {
        Time.timeScale = 1;
        panelOptions.SetActive(false);
    }
}
