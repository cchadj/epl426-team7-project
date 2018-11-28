using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private Transform _transform;
    public List<Collider> ignoredColliders;
    private Collider _collider;
    public Vector3 collisionDirection;

    void Start()
    {
        _transform = transform;
        _collider = GetComponent<Collider>();
        foreach (Collider c in ignoredColliders)
        {
            Physics.IgnoreCollision(_collider, c.GetComponent<Collider>());
        }
    }


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
        if (other.CompareTag("Collectable"))
        {
            Debug.Log("Collectable found.");
            return;
        }

        
        Debug.Log("WALL FOUND CANT WALK");
        collisionDirection = other.transform.position - _transform.position;
        _isTouchingWall = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _isTouchingWall = false;
    }


}
