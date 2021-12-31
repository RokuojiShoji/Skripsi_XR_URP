using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource sfx;
    
    void OnCollisionEnter(Collision collision) {
        sfx.volume = collision.relativeVelocity.magnitude;
        sfx.Play();
        Debug.Log("audio played");
    }
}
