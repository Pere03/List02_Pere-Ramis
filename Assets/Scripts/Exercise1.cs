using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public GameObject SpherePrefab;
    private int enemiesForWave = 0;
    public int enemiesLeft;
    private Vector3 positionOffset = new Vector3(0, 0, 0);

    void Start()
    {
       SpawnEnemyWave(enemiesForWave);
    }

    
    void Update()
    {
        enemiesLeft = FindObjectsOfType<Exercise1_Sphere>().Length;

        if (enemiesLeft <= 0)
        {
            enemiesForWave++;

            SpawnEnemyWave(enemiesForWave);
        }
    }

    private Vector3 RandomSpawnPosition()
    {
        positionOffset.x = Random.Range(-11, 11);
        positionOffset.y = Random.Range(-5, 6);
        positionOffset.z = Random.Range(-0,0);

        return positionOffset;
    }
    private void SpawnSphere()
    {
        Instantiate(SpherePrefab, RandomSpawnPosition(), transform.rotation);
    }

    private void SpawnEnemyWave(int totalEnemies)
    {
        for (int i = 0; i < totalEnemies; i++)
        {
            SpawnSphere();
        }
    }
}
