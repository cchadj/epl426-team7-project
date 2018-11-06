using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SplineComponent))]
public class SplineComponentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox("Hold Shift and click to append and insert curve points. Backspace to delete points.", MessageType.Info);
        var spline = target as SplineComponent;
        GUILayout.BeginHorizontal();
        var closed = GUILayout.Toggle(spline.closed, "Closed", "button");
        if (spline.closed != closed)
        {
            spline.closed = closed;
            spline.ResetIndex();
        }
        if (GUILayout.Button("Flatten Y Axis"))
        {
            Undo.RecordObject(target, "Flatten Y Axis");
            //TODO: Flatten(spline.points);
            spline.ResetIndex();
        }
        if (GUILayout.Button("Center around Origin"))
        {
            Undo.RecordObject(target, "Center around Origin");
            //TODO: CenterAroundOrigin(spline.points);
            spline.ResetIndex();
        }
        GUILayout.EndHorizontal();
    }


    [DrawGizmo(GizmoType.NonSelected)]
    static void DrawGizmosLoRes(SplineComponent spline, GizmoType gizmoType)
    {
        Gizmos.color = Color.white;
        DrawGizmo(spline, 64);
    }

    [DrawGizmo(GizmoType.Selected)]
    static void DrawGizmosHiRes(SplineComponent spline, GizmoType gizmoType)
    {
        Gizmos.color = Color.white;
        DrawGizmo(spline, 1024);
    }

    static void DrawGizmo(SplineComponent spline, int stepCount)
    {
        if (spline.points.Count > 0)
        {
            var P = 0f;
            var start = spline.GetNonUniformPoint(0);
            var step = 1f / stepCount;
            do
            {
                P += step;
                var here = spline.GetNonUniformPoint(P);
                Gizmos.DrawLine(start, here);
                start = here;
            } while (P + step <= 1);
        }
    }

    void OnSceneGUI()
    {
        var spline = target as SplineComponent;


        var e = Event.current;
        GUIUtility.GetControlID(FocusType.Passive);


        var mousePos = (Vector2)Event.current.mousePosition;
        var view = SceneView.currentDrawingSceneView.camera.ScreenToViewportPoint(Event.current.mousePosition);
        var mouseIsOutside = view.x < 0 || view.x > 1 || view.y < 0 || view.y > 1;
        if (mouseIsOutside) return;

        var points = serializedObject.FindProperty("points");
        if (Event.current.shift)
        {
            if (spline.closed)
                ShowClosestPointOnClosedSpline(points);
            else
                ShowClosestPointOnOpenSpline(points);
        }
        for (int i = 0; i < spline.points.Count; i++)
        {
            var prop = points.GetArrayElementAtIndex(i);
            var point = prop.vector3Value;
            var wp = spline.transform.TransformPoint(point);

            if (hotIndex == i)
            {
                var newWp = Handles.PositionHandle(wp, Tools.pivotRotation == PivotRotation.Global ? Quaternion.identity : spline.transform.rotation);
                var delta = spline.transform.InverseTransformDirection(newWp - wp);
                if (delta.sqrMagnitude > 0)
                {
                    prop.vector3Value = point + delta;
                    spline.ResetIndex();
                }
                HandleCommands(wp);
            }

            Handles.color = i == 0 | i == spline.points.Count - 1 ? Color.red : Color.white;
            var buttonSize = HandleUtility.GetHandleSize(wp) * 0.1f;
            if (Handles.Button(wp, Quaternion.identity, buttonSize, buttonSize, Handles.SphereHandleCap))
                hotIndex = i;
        }


    }
}
