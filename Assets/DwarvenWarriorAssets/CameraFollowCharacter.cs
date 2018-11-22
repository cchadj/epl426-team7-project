using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCharacter : MonoBehaviour {
    Vector3 offset = new Vector3(6f,5f,0.5f);
    public Transform target;
    // Use this for initialization
    void Start () {
		
	}

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, Mathf.Abs(target.transform.position.z)) + offset;
    }
}

