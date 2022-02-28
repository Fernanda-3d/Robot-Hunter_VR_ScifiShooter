using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float speed = 1000f;
       
    private void Start()
    {
        rb = GetComponent<Rigidbody>();            
    }
    
    void FixedUpdate()
    {
       rb.AddForce(transform.forward * speed);
               
       Destroy(gameObject, 2f);
    }

   
}
