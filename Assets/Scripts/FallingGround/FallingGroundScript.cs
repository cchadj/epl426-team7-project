using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGroundScript : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        Fall();
    }


    private void Fall()
    {
        Debug.Log("STEPPING!");
    }
}
