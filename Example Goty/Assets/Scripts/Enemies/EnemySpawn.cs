using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int WaveNumber = 1;

    public float timeBetweenWaves = 10f;

    public static float countDown = 5f;

    public GameObject enemy1;

    public GameObject enemy2;

    public GameObject enemy3;

    public GameObject enemy4;

    public GameObject enemy5;

    public Transform spawnPoint;


    void Update()
    {
        if(countDown <= 0f)
        {
            StartCoroutine(NextWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
    }

    IEnumerator NextWave()
    {
        
        for(int i = 0; i<(WaveNumber*2)-1; i++)
        {
            StartWave.isWaveTrue = true;
            SpawnEnemies();
            


            yield return new WaitForSeconds(0.5f);
        }
        
        
        WaveNumber++;
        StartWave.boolButton = true;
        StartWave.isWaveTrue = false;
    }


    void SpawnEnemies()
    {
        GameObject newEnemy;
        newEnemy = Instantiate(enemy4, spawnPoint.position, Quaternion.identity);
        newEnemy.SetActive(true);


    }
}
