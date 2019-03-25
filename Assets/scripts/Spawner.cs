using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float startTimeBwSpawn;
    public float timeBwSpawn;
    public GameObject[] enemies;
    private void Update()
    {
        if (timeBwSpawn <= 0)
        {
            int rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], transform.position, Quaternion.identity);
            timeBwSpawn = startTimeBwSpawn;
        }
        else
        {
            timeBwSpawn -= Time.deltaTime;
        }
    }
}
