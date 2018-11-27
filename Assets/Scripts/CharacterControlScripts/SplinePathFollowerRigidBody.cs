using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SplinePathFollowerRigidBody : MonoBehaviour {

    private Transform _transform;
    private Rigidbody _rigidBody;
    private float _horizontalInput = 0f;
    
    private float _speed = 0f;
    private float _t = 0f;

    public Spline spline;
    public float discountFactor = 1f;
    private float _targetY = 0f;

    void Awake()
    {
        _transform = GetComponent<Transform>();
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.interpolation = RigidbodyInterpolation.Interpolate;

        _transform.position = spline.GetLocationAlongSplineAtDistance(_t);
    }

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }


    private void Update()
    {
        GetInput();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        _t += Time.deltaTime * _horizontalInput * discountFactor;
        _t = Mathf.Clamp(_t, 0f, spline.Length);

        Vector3 curTransformPosition = _transform.position;

        Vector3 desiredPosition = spline.GetLocationAlongSplineAtDistance(_t); ;
        Vector3 desiredDirection = spline.GetTangentAlongSplineAtDistance(_t);

        //_targetY = Mathf.Clamp(_targetY, 0f, Mathf.Infinity);
        //Vector3 desiredPosition = new Vector3(splinePointPosition.x, _targetY, splinePointPosition.z);

        _rigidBody.MovePosition(desiredPosition * Time.deltaTime);
        
        if (_horizontalInput < 0f)
        {
            transform.forward = -desiredDirection;
        }
        else if (_horizontalInput > 0f)
        {
            transform.forward = desiredDirection;
        }



    }

}
