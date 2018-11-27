using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SphereController : MonoBehaviour {

    private Rigidbody _rb;
    public float speedMagnitude = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private float _initialSpeed = 0f;
    private Vector3 _direction = Vector3.left;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController _characterControler;
    // Use this for initialization
	void Start () {
        _characterControler = GetComponent<CharacterController>();
        // let the gameObject fall down
        gameObject.transform.position = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    private void Update()
    {

        if (_characterControler.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            Debug.Log(moveDirection.magnitude);
            moveDirection = moveDirection * speedMagnitude;
            Debug.Log(moveDirection);
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        Debug.Log(moveDirection);
        // Move the controller
        _characterControler.Move(moveDirection * Time.deltaTime);

    }
}
