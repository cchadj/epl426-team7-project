using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class JumpCharacterController : MonoBehaviour {

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private int _maxJumpCount = 2;
    private int _jumpCount = 0;
    void Update()
    {
        if (_characterController.isGrounded)
        {
            _jumpCount = 0;
        }

        if( _jumpCount < _maxJumpCount && Input.GetButtonDown("Jump"))
        {
            _jumpCount++;
            moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        _characterController.Move(moveDirection * Time.deltaTime);
    }
}
