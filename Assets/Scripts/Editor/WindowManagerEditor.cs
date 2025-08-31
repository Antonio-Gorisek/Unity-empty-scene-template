using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WindowsManager))]
public class WindowManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        WindowsManager windowManager = (WindowsManager)target;
        DrawDefaultInspector();
        int newWindowIndex = windowManager.currentWindowIndex;

        if (windowManager.windows.Count > 0)
        {
            windowManager.currentWindowIndex = EditorGUILayout.IntSlider(
                "Current Window Index",
                windowManager.currentWindowIndex,
                0,
                windowManager.windows.Count - 1
            );
        }
        else
        {
            windowManager.currentWindowIndex = 0;
        }

        if(newWindowIndex != windowManager.currentWindowIndex)
        {
            windowManager.OnWindowChange();
        }

        if (GUILayout.Button("Create New Window"))
        {
            windowManager.CreateNewWindow();
        }

        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
    }
}