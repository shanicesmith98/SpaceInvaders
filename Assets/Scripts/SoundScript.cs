using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip [] soundClips;
    // 0 - Shooting
    // 1 - Explosion
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerExplosion();
        }
    }

    void TriggerExplosion()
    {
        audioSource.PlayOneShot(soundClips[1]);
    }

    void FireBullet()
    {
        audioSource.PlayOneShot(soundClips[0]);
    }
}
