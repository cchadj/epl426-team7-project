using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplinePathFollower : MonoBehaviour
{
    private Transform _transform;
    private float _horizontalInput = 0f;

    private float _speed = 0f;
    [SerializeField]
    private float _t = 0f;
    public void set_t(float newt)
    {
        _t = newt;
    }


    public List<Spline> splines;
    private ITwoWayEnumerator<Spline> _splineEnumerator;
    private Spline _activeSpline;

    public float speed = 1f;
    private float _targetY = 0f;

    public Transform childTransform;
    private CharacterController _childCharacterController;
    public CollisionController childCollisionController;
    void Start()
    {
         _splineEnumerator = splines.GetTwoWayEnumerator();
         _splineEnumerator.MoveNext();
        _activeSpline = _splineEnumerator.Current;
         _transform = GetComponent<Transform>();
        _childCharacterController = childTransform.gameObject.GetComponent<CharacterController>();
        //childCollisionController = childTransform.gameObject.GetComponent<CollisionController>();
        _transform.position = _activeSpline.GetLocationAlongSplineAtDistance(_t) + Vector3.up * _transform.lossyScale.y;
    }

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void Update()
    {
        GetInput();
        Vector3 desiredDirection = _activeSpline.GetTangentAlongSplineAtDistance(_t);

        if (_horizontalInput < 0f)
        {
            _transform.forward = -desiredDirection;
        }
        else if (_horizontalInput > 0f)
        {
            _transform.forward = desiredDirection;
        }

        if (!childCollisionController.IsTouchingWall)
            _t += Time.deltaTime * _horizontalInput * speed;
        else
        {
            if(Vector3.Dot(childCollisionController.collisionDirection, transform.forward) < 0f)
            {
                _t += Time.deltaTime * _horizontalInput * speed;
            }
            else
             return;
        }

        _t = Mathf.Clamp(_t, 0f, _activeSpline.Length);

        Vector3 curTransformPosition = _transform.position;
        Vector3 splinePointPosition = _activeSpline.GetLocationAlongSplineAtDistance(_t);



        _targetY = Mathf.Clamp(_targetY, 0f, Mathf.Infinity);
        //Vector3 desiredPosition = new Vector3(splinePointPosition.x, _targetY, splinePointPosition.z);
        Vector3 desiredPosition = splinePointPosition;
        //transform.localPosition = desiredPosition;


        _transform.position = desiredPosition;
        if (Mathf.Approximately(_t, _activeSpline.Length))
        {
            if (_splineEnumerator.MoveNext())
            {
                _activeSpline = _splineEnumerator.Current;
                _t = 0f;
            }
        }
        else if (Mathf.Approximately(_t, 0f))
        {
            if (_splineEnumerator.MovePrevious())
            {
                _activeSpline = _splineEnumerator.Current;
                _t = _activeSpline.Length;
            }
        }
    }
}
