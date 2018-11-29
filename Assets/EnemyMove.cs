using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public Spline spline;
    private Transform _transform;
    private float _t = 0f;
    private float speed = 5f;
    private bool back = false;
    private float move;
    private bool flag1 = true;
    private bool flag2 = false;


    void Start () {
        _transform = GetComponent<Transform>();
	}
	
	void Update () {
        Vector3 direction = spline.GetTangentAlongSplineAtDistance(_t);
        move = Time.deltaTime * speed;

        

        if (_t >= spline.Length && flag1)
        {
            back = true;
            flag1 = false;
            flag2 = true;
        }

        if (_t <= 0 && flag2)
        {
            back = false;
            flag1 = true;
            flag2 = false;
        }

        if (back)
        {
            _t -= move;
            _transform.forward = -direction;
        }
        else
        {
            _t += move;
            _transform.forward = direction;
        }


        _t = Mathf.Clamp(_t, 0f, spline.Length);

        _transform.position = spline.GetLocationAlongSplineAtDistance(_t);

    }
}
