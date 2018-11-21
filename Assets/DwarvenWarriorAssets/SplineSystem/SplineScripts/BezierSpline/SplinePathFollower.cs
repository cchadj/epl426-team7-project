using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplinePathFollower : MonoBehaviour
{
    private Transform m_transform;
    private float _horizontalInput = 0f;
    private float _speed = 0f;
    private float _progress = 0f;

    public BezierSpline spline;
    public float discountFactor = 1f;
    private float _targetY = 0f;
    void Awake()
    {
        m_transform = GetComponent<Transform>();
        Vector3 position = spline.GetPoint(_progress);
        transform.localPosition = position;
    }

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _horizontalInput = Time.deltaTime * _horizontalInput * discountFactor;
    }
    // Update is called once per frame
    void Update()
    {
        GetInput();
        _progress += _horizontalInput;
        _progress = Mathf.Clamp01(_progress);
        Vector3 curTransformPosition = m_transform.position;
        Vector3 splinePointPosition = spline.GetPoint(_progress);

        _targetY = Mathf.Clamp(_targetY, splinePointPosition.y, Mathf.Infinity);
        Vector3 desiredPosition = new Vector3(splinePointPosition.x, _targetY, splinePointPosition.z);
        transform.position = desiredPosition;

        Debug.Log("progress" + _progress);
        Debug.Log("horizontal input" + _horizontalInput);

    }
}
