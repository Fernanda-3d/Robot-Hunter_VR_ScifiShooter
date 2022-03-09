using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{

    [SerializeField] GameObject gunVFX;
    [SerializeField] Transform gunpoint;

    [SerializeField] GameObject impactParticle;
    public Transform trail;

    AudioSource audioSource;
    public AudioClip hitSound;

    public GameManager gameManager;

    // public Transform trailParent;

    RaycastHit hit;
    public LayerMask mask;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Fire()
    {
       
        //instantiate the particles
        GameObject _gunVFX = Instantiate(gunVFX, gunpoint.position, gunpoint.rotation);

        if(Physics.Raycast(gunpoint.position, gunpoint.forward, out hit, 1000, mask))
        {
            Debug.Log(hit.collider.name);
            Transform newTrail = Instantiate(trail, gunpoint.position, Quaternion.identity);
            newTrail.GetComponent<trailShoot>().destination = hit.point;

            if (hit.collider.GetComponent<Rigidbody>() != null)
            {
                Rigidbody rigidbody = hit.collider.attachedRigidbody;
                rigidbody.AddForce(gunpoint.forward * 5);
                audioSource.PlayOneShot(hitSound);               
            }

            if (hit.collider.gameObject.tag == "Asteroid")
            {
                Destroy(hit.collider.gameObject);
            }
            
            if (hit.collider.gameObject.tag == "Button")
            {
                if (hit.collider.name == "StartCollisionDetect")
                {
                    audioSource.PlayOneShot(hitSound);
                    Debug.Log("I'm hitting the Start");
                    gameManager.StartGame();

                }
                if (hit.collider.name == "RestartCollisionDetect")
                {
                    audioSource.PlayOneShot(hitSound);
                    Debug.Log("I'm hitting the Restart");
                    gameManager.RestartGame();
                }
                                  

            }           

            //&& hit.collider.gameObject.tag != "Button"
                      
            Instantiate(impactParticle, hit.point, Quaternion.identity);                  

           if (hit.collider.gameObject.tag != "Button")
            {
                GameManager.AsteroidHit();
            }

            if (hit.collider.gameObject.tag == "ChangeButton")
            {
                Debug.Log("Changing Gun");
            }


        }
              
    }

    private void Update()
    {
        Debug.DrawRay(gunpoint.position, gunpoint.forward * 100, Color.red);
    }



}

