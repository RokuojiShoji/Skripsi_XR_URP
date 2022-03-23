using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource sfx;
    
    void OnCollisionEnter(Collision collision) {
        sfx.volume = collision.relativeVelocity.magnitude;
        sfx.Play();
        Debug.Log("audio played");
    }
}
