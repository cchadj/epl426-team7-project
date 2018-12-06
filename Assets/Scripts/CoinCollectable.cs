using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour, ICollectable
{
    public Animator energyCollectedAnimator;
    public GameEvent onBeingCollectedEvent;
    private Collider _collider;
    private Rotator _rotator;
    private Animator _animator;
    private int _collectedAnimHash;

    private Vector3 _randomDir;
    private float _randomForce;

    private void Start()
    {
        _collectedAnimHash = Animator.StringToHash("Collected");
        _collider = GetComponent<Collider>();
        _rotator = GetComponent<Rotator>();
        _animator = GetComponent<Animator>();
        _randomForce = Random.Range(3f, 6f);
        _randomDir = Vector3.up + Vector3.forward;
    }

    public void AddRigidbody()
    {
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        if(_animator)
        {
            _animator.enabled = false;
            GameObject.Destroy(_animator);
        }
        if (_collider)
        {
            GameObject.Destroy(_collider);
        }
        if(_rotator)
        {
            _rotator.enabled = false;
            GameObject.Destroy(_rotator);

        }
        rb.AddForce(_randomDir * _randomForce, ForceMode.Impulse);
    }


    public void Collect()
    {
        onBeingCollectedEvent.Raise();
        energyCollectedAnimator.SetTrigger(_collectedAnimHash);
    }

    /// <summary>
    /// Destroys this collectable.
    /// Is called by the collection animation from an animation event.
    /// </summary>
    public void DestroyObject()
    {

        GameObject.Destroy(gameObject);
    }
}
