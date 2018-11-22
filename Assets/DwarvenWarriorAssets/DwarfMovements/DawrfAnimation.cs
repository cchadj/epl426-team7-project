using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DawrfAnimation : MonoBehaviour {

    public Animation animation;
    private float _horizontalInput = 0f;
    private float _progress = 0f;
    bool jumpLock = false;
    enum State { jumping, running, idle };

    // Use this for initialization
    void Start () {
		
	}

    void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }


    void Update()
    {
        GetInput();

        if (animation.IsPlaying("jump"))
            jumpLock = true;
        else
            jumpLock = false;


        if (Input.GetKey(KeyCode.Space))
        {
           
            animation.CrossFade("jump", 1.7f);
            animation.Blend("run fast", 0.02f, 0f);

            
            //animation.CrossFadeQueued("idle break");
        }

        

        if ((_horizontalInput > 0 || _horizontalInput < 0)&& !jumpLock)
        {


            if (Input.GetKey(KeyCode.Space))
            {
                animation.CrossFade("jump", 0.0f);
                animation.CrossFadeQueued("idle break");
            }

            animation.CrossFade("run fast");
        }

        else if (Mathf.Approximately(_horizontalInput, 0) && !jumpLock)
        {
            animation.CrossFade("idle break");
        }


     
        
    }

}
