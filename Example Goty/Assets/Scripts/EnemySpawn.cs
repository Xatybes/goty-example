using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int WaveNumber = 1;

    public float timeBetweenWaves = 5f;

    public float countDown = 2f;

    public GameObject enemyPrefab;

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
        for(int i = 0; i<WaveNumber+1; i++)
        {
            SpawnEnemies();
            yield return new WaitForSeconds(1f);
        }
        WaveNumber++;
    }


    void SpawnEnemies()
    {
        GameObject newEnemy;
        newEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        newEnemy.SetActive(true);
    }
}
