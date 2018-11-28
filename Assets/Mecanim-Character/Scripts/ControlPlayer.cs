using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour {


    public Animator _animator;
	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        bool _move = Input.GetAxis("Horizontal")!=0f;
        bool _die = Input.GetKeyDown(KeyCode.W);
        bool _attack = Input.GetKeyDown(KeyCode.A);

        if (_move)
        {
    
            _animator.SetBool("idle", false);
            _animator.SetBool("move", true);
            _animator.SetBool("die", false);
            _animator.SetBool("attack", false);
        }
        else if (_die)
        {
  
            _animator.SetBool("idle", false);
            _animator.SetBool("move", false);
            _animator.SetBool("die", true);
            _animator.SetBool("attack", false);
        }
        else if (_attack)
        {
     
            _animator.SetBool("idle", false);
            _animator.SetBool("move", false);
            _animator.SetBool("die", false);
            _animator.SetBool("attack", true);
        }
        else // IDLE
        {

            _animator.SetBool("idle", true);
            _animator.SetBool("move", false);
            _animator.SetBool("die", false);
            _animator.SetBool("attack", false);
        }
        // ...
    }
}
