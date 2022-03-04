using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFX, audioSource;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            //Destroy asteroid
            Destroy(collision.gameObject);

           // Instantiate(explosion1, collision.transform.position, collision.transform.rotation);
            //Instantiate(explosion2, collision.transform.position, collision.transform.rotation);
            //Instantiate(explosion3, collision.transform.position, collision.transform.rotation);
            Instantiate(audioSource, collision.transform.position, collision.transform.rotation);

            //send notification to game manager that we hit an asteroid
            GameManager.AsteroidHit();

            //Destroy laser
            Destroy(gameObject, 3f);


        }
    
            
}
}
