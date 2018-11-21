using UnityEngine;

public static class Bezier {

	public static Vector3 GetPoint (Vector3 p0, Vector3 p1, Vector3 p2, float t) {
		t = Mathf.Clamp01(t);
		float oneMinusT = 1f - t;
		return
			oneMinusT * oneMinusT * p0 +
			2f * oneMinusT * t * p1 +
			t * t * p2;
	}

	public static Vector3 GetFirstDerivative (Vector3 p0, Vector3 p1, Vector3 p2, float t) {
		return
			2f * (1f - t) * (p1 - p0) +
			2f * t * (p2 - p1);
	}

	public static Vector3 GetPoint (Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t) {
		t = Mathf.Clamp01(t);
		float OneMinusT = 1f - t;
		return
			OneMinusT * OneMinusT * OneMinusT * p0 +
			3f * OneMinusT * OneMinusT * t * p1 +
			3f * OneMinusT * t * t * p2 +
			t * t * t * p3;
	}

    /// <summary>
    /// Returns the tangent of the point. 
    /// (is the e-d normalized)
    /// </summary>
    /// <param name="p0"></param>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <param name="p3"></param>
    /// <param name="t"></param>
    /// <returns></returns>
	public static Vector3 GetFirstDerivative (Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t) {
		t = Mathf.Clamp01(t);
		float oneMinusT = 1f - t;
		return
			3f * oneMinusT * oneMinusT * (p1 - p0) +
			6f * oneMinusT * t * (p2 - p1) +
			3f * t * t * (p3 - p2);
	}

    /// <summary>
    /// MyAddition https://www.youtube.com/watch?v=o9RK6O2kOKo&fbclid=IwAR19ORO8cKb2P-DcY41SEUZKlkBryvSZpFo_LwJQAnZk7iFwoP-yD2obsfs
    /// 
    /// </summary>
    public static Vector3 GetNormal3D(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t, Vector3 up)
    {
        Vector3 tangent = GetFirstDerivative(p0,p1,p2, p3,t);
        Vector3 binormal = Vector3.Cross(up, tangent).normalized;
        return Vector3.Cross(tangent, binormal);
    }
    /// <summary>
    /// MyAddition https://www.youtube.com/watch?v=o9RK6O2kOKo&fbclid=IwAR19ORO8cKb2P-DcY41SEUZKlkBryvSZpFo_LwJQAnZk7iFwoP-yD2obsfs
    /// 26:30
    /// </summary>
    public static Quaternion GetOrientation3D(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t, Vector3 up)
    {
        Vector3 tangent = GetFirstDerivative(p0, p1, p2, p3, t);
        Vector3 normal = GetNormal3D(p0, p1, p2, p3, t, up);
        return Quaternion.LookRotation(tangent, normal);
    }
}