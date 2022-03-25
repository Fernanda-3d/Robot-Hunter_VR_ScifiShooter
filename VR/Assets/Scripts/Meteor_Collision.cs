using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Collision : MonoBehaviour
{
    public float speed; //speed of the asteroid falling
    public GameObject impactPrefab; //mesh that is going to be instantiated when the asteroid hits the ground
    public List<GameObject> trails; //smoke trails effect

       Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = Random.Range(2f, 7f); //get a random speed on asteroids falling
    }

    private void FixedUpdate()
    {
        if(speed != 0 && rb != null)
        {
            rb.position += transform.forward * (speed * Time.deltaTime); //make it fall forwards
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            speed = 0; //when then asteroid hits the floor stop the speed

            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;

            if (impactPrefab != null)
            {
                var impactVFX = Instantiate(impactPrefab, pos, rot) as GameObject;
                Destroy(impactVFX, 5f);
            }

            if (trails.Count > 0) //make the trails not desappear instantly when the asteroid is destroyed, but wait until the particles finish playing
            {
                for (int i = 0; i < trails.Count; i++)
                {
                    trails[i].transform.parent = null;
                    var ps = trails[i].GetComponent<ParticleSystem>();
                    if (ps != null)
                    {
                        ps.Stop();
                        Destroy(ps.gameObject, ps.main.duration + ps.main.startLifetime.constantMax);
                    }
                }
            }

            Destroy(gameObject);

        }

        
    }


}
