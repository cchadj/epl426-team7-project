using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovingPlatform : MonoBehaviour {

    public float downwardDisplacement;

    private Rigidbody _rb;

    private bool _moveDownwards = false;
	// RigidBody must use interpolation and be kinematic
	void Start () {
        _rb = GetComponent<Rigidbody>();
        _rb.interpolation = RigidbodyInterpolation.Interpolate;
        _rb.isKinematic = true;
	}

    private void Update()
    {
        if(_moveDownwards)
        {
            _rb.MovePosition(_rb.position + Vector3.down * downwardDisplacement * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _moveDownwards = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _moveDownwards = false;
    }
}
