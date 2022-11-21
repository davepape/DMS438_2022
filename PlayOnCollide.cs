using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollide : MonoBehaviour
{
    public AudioSource audiosource = null;
    public ParticleSystem particles = null;
    public string otherTag = "";

    void Start()
    {
        if (!audiosource)
        {
            audiosource = GetComponent<AudioSource>();
        }
        if (!particles)
        {
            particles = GetComponent<ParticleSystem>();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if ((otherTag == "") || (other.tag == otherTag))
        {
            if (audiosource)
                audiosource.Play();
            if (particles)
                particles.Play();
        }
    }
}
