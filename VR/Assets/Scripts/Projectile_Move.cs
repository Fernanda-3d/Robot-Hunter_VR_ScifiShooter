using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Move : MonoBehaviour
{

    public float speed;
    public float fireRate;

    public TrailRenderer trail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed != 0)
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
            Destroy(gameObject, 2f);
            Destroy(trail, 2f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
            Destroy(trail);
        }
          
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Button")
        {
            Destroy(gameObject);
            Destroy(trail);
        }
    }
}
