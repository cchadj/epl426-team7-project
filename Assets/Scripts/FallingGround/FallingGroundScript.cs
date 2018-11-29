using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGroundScript : MonoBehaviour {

   
    public Animator animator;
    private bool _alreadyTriggered=false;
    private const string STEPPED_ON_TRIGGER = "SteppedOnTrigger";
    private int _steppedOnTriggerAnimHash;

    private void Start()
    {
        _steppedOnTriggerAnimHash = Animator.StringToHash(STEPPED_ON_TRIGGER);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_alreadyTriggered && other.CompareTag("PlayerFeet")){
            Shake();
        }

    }

    private void Shake()
    {
        animator.SetTrigger(_steppedOnTriggerAnimHash);
    }


    private void Fall()
    {
        if(!_alreadyTriggered)
            this.gameObject.AddComponent<Rigidbody>();
        _alreadyTriggered = true;
    }

    public void ResetAlreadyTriggered()
    {
        _alreadyTriggered = false;
    }

}
