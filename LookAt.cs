using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target=null;

    void Start()
    {    
    }

    void Update()
    {
        if (target)
            {
            transform.LookAt(target);   
            }
    }
}
