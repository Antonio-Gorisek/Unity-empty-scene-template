using UnityEditor;
using UnityEngine;

public class DeleteMissingScripts
{
    [MenuItem("Tools/Missing Scripts/Delete")]
    static void FindAndDeleteMissingScripts()
    {
        foreach(GameObject gameObject in GameObject.FindObjectsOfType<GameObject>())
        {
            foreach(Component component in gameObject.GetComponentsInChildren<Component>())
            {
                if(component == null)
                {
                    GameObjectUtility.RemoveMonoBehavioursWithMissingScript(gameObject);
                    break;
                }
            }
        }
    }

    [MenuItem("Tools/Refresh scripts in 'Scripts' folder")]
    static void RefreshScriptsInSpecificFolder()
    {
        string folderPath = "Assets/Scripts";

        string[] scriptGUIDs = AssetDatabase.FindAssets("t:script", new[] { folderPath });
        foreach (var guid in scriptGUIDs)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);

            AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
        }

        Debug.Log("All scripts in 'Scripts' folder have been refreshed!");
    }
}
