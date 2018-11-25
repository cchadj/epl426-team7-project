using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplinePathFollower : MonoBehaviour
{
    private Transform m_transform;
    private float _horizontalInput = 0f;

    private float _speed = 0f;
    private float _progress = 0f;
    
    public Spline spline;
    public float discountFactor = 1f;
    private float _targetY = 0f;

    public Transform childTransform;
    void Awake()
    {
        m_transform = GetComponent<Transform>();
        Vector3 position = spline.GetLocationAlongSpline(_progress);
        transform.localPosition = position;
    }

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

        _progress += Time.deltaTime * _horizontalInput * discountFactor;
        _progress = Mathf.Clamp01(_progress);
        Vector3 curTransformPosition = m_transform.position;
        Vector3 splinePointPosition = spline.GetLocationAlongSpline(_progress);
        Vector3 desiredDirection = spline.GetLocationAlongSpline(_progress);

        _targetY = Mathf.Clamp(_targetY, splinePointPosition.y, Mathf.Infinity);
        Vector3 desiredPosition = new Vector3(splinePointPosition.x, 0f, splinePointPosition.z);
        transform.position = desiredPosition;

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
