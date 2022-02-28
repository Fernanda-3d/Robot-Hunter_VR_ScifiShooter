using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    [SerializeField] private GameObject explosion1, explosion2, explosion3;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);

            Instantiate(explosion1, collision.transform.position, collision.transform.rotation);
            Instantiate(explosion2, collision.transform.position, collision.transform.rotation);
            Instantiate(explosion3, collision.transform.position, collision.transform.rotation);

            Destroy(gameObject, 2f);
        }
    }
}
