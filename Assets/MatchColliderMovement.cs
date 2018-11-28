using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class MatchColliderMovement : MonoBehaviour {

    public Transform tackedTransform;

    private Rigidbody _rb;
    private Collider _col;

	// Use this for initialization
	void Start () {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
        _rb.isKinematic = false;
        _rb.interpolation = RigidbodyInterpolation.Interpolate;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        _rb.MovePosition(tackedTransform.position);
	}
}
