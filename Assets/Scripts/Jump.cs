using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{

    private Transform _transform;
    private Rigidbody _rb;
    public float jumpImpulseForce;




    private float _prevHeight;
    private int jumpCount = 0;
    private int _groundLayerMask = 0;

    public float  fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    [Range(0f, 1f)]
    public float doubleJumpDiscount;
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
        _groundLayerMask = LayerMask.NameToLayer("Ground");
    }

    void Update()
    {
        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1f) * Time.deltaTime;
        }
        else if (_rb.velocity.y > 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1f) * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hey force is " + jumpImpulseForce);
            float curHeight = _transform.position.y;


            if (jumpCount == 0)
            {
                _rb.AddForce(Vector3.up * jumpImpulseForce, ForceMode.Impulse);
                jumpCount++;
            }
            else if (jumpCount == 1)
            {
                _rb.AddForce(Vector3.up * jumpImpulseForce * doubleJumpDiscount, ForceMode.Impulse);
                jumpCount++;
            }
            else
            {
                return;
            }

            _prevHeight = curHeight;

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == _groundLayerMask)
        {
            ResetJumpCounter();
        }        
    }
    private void ResetJumpCounter()
    {
        jumpCount = 0;
    }
}
