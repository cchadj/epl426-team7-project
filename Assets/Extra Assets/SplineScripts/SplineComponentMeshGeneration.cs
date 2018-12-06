using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineComponentMeshGeneration : ISpline
{
    public int ControlPointCount { get { throw new System.NotImplementedException(); } }

    public Vector3 FindClosest(Vector3 worldPoint)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetBackward(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetControlPoint(int index)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetDistance(float distance)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetDown(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetForward(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetLeft(float t)
    {
        throw new System.NotImplementedException();
    }

    public float GetLength(float stepSize)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetNonUniformPoint(float t)
    {
        throw new System.NotImplementedException();
    }


    Vector3 GetPoint(Vector3[] pts, float t)
    {
        float omt = 1f - t;
        float omt2 = omt * omt;
        float t2 = t * t;
        return pts[0] * (omt2 * omt) +
                pts[1] * (3f * omt2 * t) +
                pts[2] * (3f * omt * t2) +
                pts[3] * (t2 * t);
    }

    public Vector3 GetPoint(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetRight(float t)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetUp(float t)
    {
        throw new System.NotImplementedException();
    }

    public void InsertControlPoint(int index, Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveControlPoint(int index)
    {
        throw new System.NotImplementedException();
    }

    public void SetControlPoint(int index, Vector3 position)
    {
        throw new System.NotImplementedException();
    }
}
