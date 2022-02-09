using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Enemies : MonoBehaviour
{

    public GameObject enemy;
    
    public int xPos;
    //public int yPos;
    public int zPos;
        
    public int enemyCount;

    Vector3 temp;


    void Start()
    {

        StartCoroutine(EnemyInst());

    }
    IEnumerator EnemyInst()
    {

        while (enemyCount < 20)
        {

            xPos = Random.Range(-20, 20);
            //yPos = Random.Range(10, 40);
            zPos = Random.Range(5, 20);

            GameObject enemyInst = Instantiate(enemy, new Vector3(xPos, 0.67f, zPos), transform.rotation * Quaternion.Euler(0f, 180f, 0f));
            


            yield return new WaitForSeconds(1f);
            enemyCount += 1;


        }



    }

    private void Update()
    {
       
    }



}
