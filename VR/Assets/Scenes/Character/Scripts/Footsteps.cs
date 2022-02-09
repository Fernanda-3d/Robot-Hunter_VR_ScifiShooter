using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController characterController;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(characterController.isGrounded && characterController.velocity.magnitude > 1f && audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
    }
}
