using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;
    }

    void OnCollisionEnter(Collision hit)
    {
       
        if (hit.relativeVelocity.magnitude > 2)
            
            audioSource.enabled = true;
            audioSource.Play();
    }
}
