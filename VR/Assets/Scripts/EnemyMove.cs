using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    /* private GameObject target;
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
       
    } */

    public NavMeshAgent agent;
    private GameObject target;
    private Vector3 spawnPoint = new Vector3(0f, 4f, 50f);

   // Transform enemy;

    private void Awake()
    {
        //enemy = GetComponent<Transform>();
        //enemy.transform.Rotate(90.0f, 180.0f, 0.0f, Space.Self);
    }
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera");

        agent = GetComponent<NavMeshAgent>();
        agent.baseOffset = Random.Range(5,10);
        agent.speed = Random.Range(1.0f, 3.2f);

               
    }

    private void Update()
    {       
        agent.SetDestination(target.transform.position);
    }
}
