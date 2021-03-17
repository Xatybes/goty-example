using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanel : MonoBehaviour
{
    public GameObject panel;
    void OnMouseEnter()
    {
        panel.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
