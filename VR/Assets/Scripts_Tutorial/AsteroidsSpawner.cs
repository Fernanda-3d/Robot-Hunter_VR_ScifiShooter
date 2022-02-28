using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    [Header ("Size of the spawn area")]
    public Vector3 size;

    [Header("Rate of instantiation")]
    public float spawnRate = 1f;

    [Header("Asteroid model")]
    public GameObject asteroidModel;

    [Header("Asteroid Parent")]
    public Transform asteroidParent;

    private float nextSpawn = 0;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.position, size);
    }

    private void Update()
    {
        //Timer to control the spawning (time since the start of the game)
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            //call the function to create an asteroid
            SpawnAsteroid();
        }
    }

    private void SpawnAsteroid()
    {
        //get a random position for the asteroid
        Vector3 spawnPoint = transform.position + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                                                              Random.Range(-size.y / 2, size.y / 2),
                                                              Random.Range(-size.z / 2, size.z / 2));

       //This one below can be used to spawn in different rotation
        // Quaternion asteroidRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

        GameObject asteroid = Instantiate(asteroidModel, spawnPoint, transform.rotation);

        asteroid.transform.SetParent(asteroidParent);
    }
}
