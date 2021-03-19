using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartWave : MonoBehaviour
{
    public Button button;

    public static bool boolButton = false;

    public static bool isWaveTrue = false;

    public void startWave()
    {
        EnemySpawn.countDown = 0;
        
        
        button.gameObject.SetActive(false);

    }

    void Update()
    {
        if (boolButton)
        {
            button.gameObject.SetActive(true);
        }
        if (isWaveTrue)
        {
            button.gameObject.SetActive(false);
        }
        boolButton = false;
        
    }

}
