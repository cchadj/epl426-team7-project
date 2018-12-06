using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColliderDetection : MonoBehaviour {


    public List<Collider> ignoredColliders;
    private Collider _collider;
    public Vector3 collisionDirection;

    void Start()
    {
        _collider = GetComponent<Collider>();
        foreach (Collider c in ignoredColliders)
        {
            Physics.IgnoreCollision(_collider, c.GetComponent<Collider>());
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Floor collider of player triggered with "+ other.name);
        if (other.CompareTag("FallingFloor"))
        {
            Debug.Log("Falling Floor");

        }
    }

}
