using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private GameObject target;
    public float t;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(2f, 5f);
        target = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.transform.position;
        transform.position = Vector3.MoveTowards(a, b, speed * Time.deltaTime);
    }
}
