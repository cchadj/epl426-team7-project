using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplinePathFollower : MonoBehaviour
{
    private Transform _transform;
    private float _horizontalInput = 0f;

    private float _speed = 0f;
    private float _t = 0f;
    
    public Spline spline;
    public float discountFactor = 1f;
    private float _targetY = 0f;

    public Transform childTransform;
    void Awake()
    {
        _transform = GetComponent<Transform>();
        Vector3 position = spline.GetTangentAlongSplineAtDistance(_t);
        
        transform.localPosition = position;
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
    private void FixedUpdate()
    {
        GetInput();
        
        _t += Time.deltaTime * _horizontalInput * discountFactor;
        _t = Mathf.Clamp(_t, 0f, spline.Length);
        Vector3 curTransformPosition = _transform.position;
        Vector3 splinePointPosition = spline.GetLocationAlongSplineAtDistance(_t);

        Vector3 desiredDirection = spline.GetTangentAlongSplineAtDistance(_t);

        _targetY = Mathf.Clamp(_targetY, 0f, Mathf.Infinity);
        //Vector3 desiredPosition = new Vector3(splinePointPosition.x, _targetY, splinePointPosition.z);
        Vector3 desiredPosition = splinePointPosition;
        //transform.localPosition = desiredPosition;
        
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
