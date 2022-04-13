using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioPitches : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = Random.Range(0.5f, 1.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
