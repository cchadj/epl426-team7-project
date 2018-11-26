using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SplinePathFollowerCharacterController : MonoBehaviour {

    public Spline spline;
    public float speedMagnitude = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20f;

    private CharacterController _characterController;
    private Transform _transform;

    private float _horizontalInput = 0f;
    
    
    public float discountFactor = 1f;
    private float _distanceCovered = 0f; // v = Dx/Dt
    private float _targetY = 0f;
    private Vector3 _moveDirection = Vector3.zero;

    void Start()
    {
        _transform = GetComponent<Transform>();
        _characterController = GetComponent<CharacterController>();

        transform.position = spline.GetTangentAlongSplineAtDistance(0f) + Vector3.up * _transform.lossyScale.y;
    }

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Update()
    {
        GetInput();
        Vector3 lastPosition = _transform.position;
        bool movedRight = false;
        Debug.Log("Distance covered " + _distanceCovered);


            _distanceCovered = Mathf.Clamp(_distanceCovered, 0, spline.Length);

            _moveDirection = Vector3.zero;
            if (Input.GetKey(KeyCode.LeftArrow) && !Mathf.Approximately(_distanceCovered, 0f))
            {
                movedRight = false;
                _moveDirection = -spline.GetTangentAlongSplineAtDistance(_distanceCovered);
            }
            else if ((Input.GetKey(KeyCode.RightArrow) && !Mathf.Approximately(_distanceCovered, spline.Length)))
            {
                movedRight = true;
                _moveDirection = spline.GetTangentAlongSplineAtDistance(_distanceCovered);
            }
            //_moveDirection.x = _moveDirection.x;
            _moveDirection.z = _moveDirection.y;
            Debug.Log("Spline tangent" + spline.GetTangentAlongSplineAtDistance(_distanceCovered));
            _moveDirection.y = 0f;
            // We are grounded, so recalculate
            // move direction directly from axes
            _moveDirection = transform.TransformDirection(_moveDirection);
           
           if(_characterController.isGrounded)
            _moveDirection = _moveDirection * speedMagnitude;
            if (Input.GetButton("Jump") && _characterController.isGrounded)
            {
                _moveDirection.y = jumpSpeed;
            }
        

        // Apply gravity
        _moveDirection.y = _moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        _characterController.Move(_moveDirection * Time.deltaTime);

        float distance = Vector3.Distance(_transform.position, lastPosition);
        _distanceCovered += movedRight? distance : -distance;

    }
}
