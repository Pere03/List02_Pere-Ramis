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

        //This means that each time all the spheres are removed, the total sphere counter will add one more entity, and spawn the total number of spheres at that moment
        if (enemiesLeft <= 0)
        {
            enemiesForWave++;

            SpawnEnemyWave(enemiesForWave);
        }
    }

    //With this we mark the limits per screen, so that the spheres are generated inside the limit and not outside
    private Vector3 RandomSpawnPosition()
    {
        positionOffset.x = Random.Range(-8, 8);
        positionOffset.y = Random.Range(-2, 5);
        positionOffset.z = Random.Range(-0,0);

        return positionOffset;
    }

    //With this, we instantiate the spheres within the set limit.
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
