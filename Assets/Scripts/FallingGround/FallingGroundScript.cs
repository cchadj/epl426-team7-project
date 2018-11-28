using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGroundScript : MonoBehaviour {

    public Animator animator;
    private bool _alreadyTriggered=false;
    private void OnTriggerEnter(Collider other)
    {
        if (!_alreadyTriggered){
            Shake();
        }

    }

    private void Shake()
    {
        animator.SetBool("isSteppedOn",true);
    }


    private void Fall()
    {
        Rigidbody gameObjectsRigidBody = this.gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
    }
}
