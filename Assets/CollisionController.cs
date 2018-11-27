using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{

    public List<Collider> ignoredColliders;
    private Collider _collider;


    void Start()
    {
        _collider = GetComponent<Collider>();
        foreach (Collider c in ignoredColliders)
        {
            Physics.IgnoreCollision(_collider, c.GetComponent<Collider>());
        }
    }

    public Vector3 collisionDirection;
    [SerializeField]
    private bool _isTouchingWall = false;
    public bool IsTouchingWall
    {
        get
        {
            return _isTouchingWall;
        }

        set
        {
            _isTouchingWall = value;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isTouchingWall = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _isTouchingWall = false;
    }


}
