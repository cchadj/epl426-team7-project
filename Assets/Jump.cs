using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{

    private Transform _transform;
    private Rigidbody _rb;
    public float jumpImpulseForce;

    [Range(0f, 1f)]
    public float doubleJumpDiscount;
    [Range(0f, 1f)]
    public float downwardsGravity;

    private float _prevHeight;
    private int jumpCount = 0;
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hey force is " + jumpImpulseForce);
            float curHeight = _transform.position.y;

            _rb.AddForce(Vector3.up * jumpImpulseForce, ForceMode.Impulse);
            /*
            if (jumpCount == 0)
            {
                _rb.AddForce(Vector3.up * jumpImpulseForce, ForceMode.Impulse);
                jumpCount++;
            }
            else if(jumpCount == 1)
            {
                _rb.AddForce(Vector3.up * jumpImpulseForce * 0.5f, ForceMode.Impulse);
                jumpCount++;
            }
            else
            {
                return;
            }
            */

            if (Mathf.Approximately(_prevHeight, curHeight))
            {
                //_rb.AddForce(Vector3.down * jumpImpulseForce * downwardsGravity, ForceMode.Impulse);
            }
            _prevHeight = curHeight;

        }

    }

}
