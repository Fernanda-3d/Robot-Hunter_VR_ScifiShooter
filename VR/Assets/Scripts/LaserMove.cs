using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float thrust = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * thrust;

        Destroy(gameObject, 2f);
    }
}
