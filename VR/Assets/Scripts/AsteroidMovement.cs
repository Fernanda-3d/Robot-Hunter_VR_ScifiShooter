using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public Vector3 movementDirection;
    private float _asteroidSpeed;

    [Header("Control the rotational speed of the asteroid")]
    public float rotationSpeedMin;
    public float rotationSpeedMax;

    private float rotationSpeed;
    private float xAngle, yAngle, zAngle;

    [Header ("Control the speed of the asteroid")]
    public float maxSpeed;
    public float minSpeed;


    void Start()
    {
        //get a random speed for the asteroid 
        _asteroidSpeed = Random.Range(minSpeed, maxSpeed);

        //get a random rotation for the asteroid
        xAngle = Random.Range(0, 360);
        yAngle = Random.Range(0, 360);
        zAngle = Random.Range(0, 360);

        transform.GetChild(0).transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

        rotationSpeed = Random.Range(rotationSpeedMin, rotationSpeedMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime * _asteroidSpeed);
        transform.GetChild(0).transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
