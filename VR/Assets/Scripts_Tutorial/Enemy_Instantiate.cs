using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



public class Enemy_Instantiate : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    public float xPos;
    public float yPos;
    public float zPos;

    public int enemyCount;
    Vector3 temp;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(2f, 7f);
            yPos = Random.Range(1f, -1f);
            zPos = Random.Range(1f, -0.8f);

            GameObject enemyInst = Instantiate(enemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);

            yield return new WaitForSeconds(1f);
            enemyCount += 1;

        }
       

    }


}
