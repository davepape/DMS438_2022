using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollideReflection : MonoBehaviour
{
    public List<Component> components = null;
    public bool playOnEnter = true;
    public bool stopOnExit = false;
    public string otherTag = "";

    void Start()
    {
    }


    void OnTriggerEnter(Collider other)
    {
        if ((playOnEnter) && ((otherTag == "") || (other.tag == otherTag)))
        {
            foreach (var comp in components)
                {
                    var t = comp.GetType();
                    var m = t.GetMethod("Play", 0, new System.Type[]{});
                    m.Invoke(comp,null);
                }
        }
    }


    void OnTriggerExit(Collider other)
    {
        if ((stopOnExit) && ((otherTag == "") || (other.tag == otherTag)))
        {
            foreach (var comp in components)
                {
                    var t = comp.GetType();
                    var m = t.GetMethod("Stop", 0, new System.Type[]{});
                    m.Invoke(comp,null);
                }
        }
    }
}
