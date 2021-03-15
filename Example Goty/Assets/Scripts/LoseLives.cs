using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseLives : MonoBehaviour
{
    public static int lives = 20;
    public Text livesText;
    public Text gameOver;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = lives.ToString();
    }

    void Update()
    {
        livesText.text = lives.ToString();

        if (lives <= 0)
        {
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

   
}
