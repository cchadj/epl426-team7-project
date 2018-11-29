using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnWoodenBridge : MonoBehaviour {

    private Vector3 _initialPosition;
    private Quaternion _initialRotation;

    private void Start()
    {
        _initialPosition = transform.position;
        _initialRotation = transform.rotation;
    }

    public void Respawn()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if(rb)
        {
            GameObject.Destroy(rb);
            transform.position = _initialPosition;
            transform.rotation = _initialRotation;
        }
    }

}
