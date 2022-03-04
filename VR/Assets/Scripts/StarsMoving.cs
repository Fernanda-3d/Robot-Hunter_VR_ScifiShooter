using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMoving : MonoBehaviour
{
    public float degreesPerSecond = 0f;
    public float amplitude = 0f;
    public float frequency = 0f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position;

        degreesPerSecond = Random.Range(1f, 15f);
        amplitude = Random.Range(0.3f, 1.5f);
        frequency = Random.Range(0.2f, 0.8f);

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
