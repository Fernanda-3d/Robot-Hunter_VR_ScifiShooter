using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public BulletProperties_SO myProperties;
    
    private Rigidbody rb;
    [SerializeField] float speed = 1000f;
    public int damage = 1;

    //[SerializeField] GameObject inflated;
    //public Vector3 sizeChange;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.localScale = myProperties.scale;
        speed = myProperties.speed;
        damage = myProperties.damage;
      
    }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed);
               
       // Destroy(gameObject, 2f);
    }

   
}
