using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldAmount : MonoBehaviour
{
    public static int currentGoldAmount = 90;
    public Text goldAmount;
    void Start()
    {
        goldAmount.text = currentGoldAmount.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        goldAmount.text = currentGoldAmount.ToString();
    }
}
