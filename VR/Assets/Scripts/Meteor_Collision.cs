using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Collision : MonoBehaviour
{
    public float speed;
    public GameObject impactPrefab;
    public List<GameObject> trails;

       Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = Random.Range(2f, 7f);
    }

    private void FixedUpdate()
    {
        if(speed != 0 && rb != null)
        {
            rb.position += transform.forward * (speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            speed = 0;

            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;

            if (impactPrefab != null)
            {
                var impactVFX = Instantiate(impactPrefab, pos, rot) as GameObject;
                Destroy(impactVFX, 5f);
            }

            if (trails.Count > 0)
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
