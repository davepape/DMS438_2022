using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollide : MonoBehaviour
{
    public AudioSource audiosource=null;
    public string otherTag="";

    void Start()
    {
        if (!audiosource)
        {
            audiosource = GetComponent<AudioSource>();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if ((otherTag == "") || (other.tag == otherTag))
            audiosource.Play();
    }
}
