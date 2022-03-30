using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLaser : MonoBehaviour
{
    public bool isFlickering = false;

    ParticleSystem laser;
    public float timeDelay;

    // [SerializeField] AudioSource audioSource;

    private void Start()
    {
        laser = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }

    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        laser.Play();
        //audioSource.Play();
        timeDelay = Random.Range(0.5f, 0.8f);
        yield return new WaitForSeconds(timeDelay);
        laser.Stop();
        // audioSource.Stop();
        timeDelay = Random.Range(2f, 5f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
