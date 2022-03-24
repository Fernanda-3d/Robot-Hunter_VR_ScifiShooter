using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



public class Enemy_Instantiate : MonoBehaviour
{
    [Header("Size of the spawn area")]
    public Vector3 size;

    [Header("Rate of instantiation")]
    public float spawnRate = 1f;
    float timeDelay = 1f;

    [Header("Enemy models")]
    public GameObject[] enemies;

    
    public int enemyCount;
    Vector3 temp;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, size);
    }

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    private void Update()
    {
        spawnRate += Time.deltaTime;
    }

    IEnumerator EnemySpawn()
    {
        while (enemyCount < 20)
        {
            //get a random position for the enemy
            Vector3 spawnPoint = transform.position + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                                                                  Random.Range(-size.y / 2, size.y / 2),
                                                                  Random.Range(-size.z / 2, size.z / 2));

            GameObject enemyInst = Instantiate(enemies[UnityEngine.Random.Range(0,3)], spawnPoint, Quaternion.Euler(90,180,0));

          
            yield return new WaitForSeconds(1f);
            enemyCount += 1;

        }
       

    }


}

