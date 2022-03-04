using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FernandaShot : MonoBehaviour
{
    public Transform gunpoint;
    public GameObject impactParticle;
    public Transform trail;

    RaycastHit hit;
    public LayerMask mask;
    
    public void OnShoot()
    {
        if (Physics.Raycast(gunpoint.position, gunpoint.forward, out hit, 1000, mask))
        {
            Debug.Log(hit.collider.name);
            if (hit.collider.GetComponent<Rigidbody>() != null)
            {
                Rigidbody rigidbody = hit.collider.attachedRigidbody;
                rigidbody.AddForce(gunpoint.forward * 2000);

            }
            Transform newTrail = Instantiate(trail, gunpoint.position, Quaternion.identity);
            newTrail.GetComponent<trailShoot>().destination = hit.point;
            Instantiate(impactParticle, hit.point, Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(gunpoint.position, gunpoint.forward *100, Color.red);
    }
}
