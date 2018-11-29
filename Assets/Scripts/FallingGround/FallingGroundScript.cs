using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGroundScript : MonoBehaviour {

    public Animator animator;
    private bool _alreadyTriggered=false;
    private void OnTriggerEnter(Collider other)
    {
        if (!_alreadyTriggered && other.CompareTag("PlayerFeet")){
            Shake();
        }

    }

    private void Shake()
    {
        animator.SetBool("isSteppedOn",true);
    }


    private void Fall()
    {
        if(!_alreadyTriggered)
            this.gameObject.AddComponent<Rigidbody>();
        _alreadyTriggered = true;
    }
}
