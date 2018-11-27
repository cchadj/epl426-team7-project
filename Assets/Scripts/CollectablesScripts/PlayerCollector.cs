using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Collectable c = other.GetComponent<Collectable>();
        if (c != null)
            c.Collect();
    }
}
