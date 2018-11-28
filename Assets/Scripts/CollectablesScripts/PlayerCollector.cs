using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        ICollectable c = other.GetComponent<ICollectable>();
        if (c != null)
            c.Collect();
    }
}
