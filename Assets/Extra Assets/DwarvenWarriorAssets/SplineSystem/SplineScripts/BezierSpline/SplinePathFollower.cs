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
    public float speed = 1f;
    private float _targetY = 0f;

    public Transform childTransform;
    private CharacterController _childCharacterController;
    public CollisionController childCollisionController;
    void Start()
    {
        _transform = GetComponent<Transform>();
        _childCharacterController = childTransform.gameObject.GetComponent<CharacterController>();
        //childCollisionController = childTransform.gameObject.GetComponent<CollisionController>();
        _transform.position = spline.GetLocationAlongSplineAtDistance(_t) + Vector3.up * _transform.lossyScale.y;
    }

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void Update()
    {
        GetInput();

        if (!childCollisionController.IsTouchingWall)
            _t += Time.deltaTime * _horizontalInput * speed;
        else
            return;

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
            _transform.forward = -desiredDirection;
        }
        else if (_horizontalInput > 0f)
        {
            _transform.forward = desiredDirection;
        }

        _transform.position = desiredPosition;

    }
}
