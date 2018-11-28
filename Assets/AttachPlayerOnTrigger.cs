using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayerOnTrigger : MonoBehaviour {

    public List<Collider> collidersToAttach;

    private void OnTriggerEnter(Collider other)
    {
        foreach(Collider c in collidersToAttach)
        {
            if(c == other )
            {
                other.transform.parent.parent = transform;
                return;
            }
        }
           
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
