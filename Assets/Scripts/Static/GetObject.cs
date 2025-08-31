using System.Collections.Generic;
using UnityEngine;
using System;

public static class GetObject
{
    public static List<GameObject> GetChildByLevel(Transform parent, int level = -1)
    {
        List<GameObject> children = new List<GameObject>();
        try
        {
            if(level == -1)
            {
                foreach (Transform child in parent)
                {
                    children.Add(child.gameObject);
                }
            }
            else
            {
                foreach (Transform child in parent.GetChild(level))
                {
                    children.Add(child.gameObject);
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            throw;
        }

        return children;
    }

    public static GameObject GetFirstChild(Transform parent)
    {
        try
        {
            return parent.GetChild(0).gameObject;
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            throw;
        }
    }

    public static GameObject GetParent(Transform parent)
    {
        try
        {
            return parent.parent.gameObject;
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            throw;
        }
    }


    public static GameObject GetLastChild(Transform parent) 
    {
        try
        {
            return parent.GetChild(parent.childCount - 1).gameObject;
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            throw;
        }
    }
    
    public static GameObject GetNextSibling(Transform currentSibling)
    {
        try
        {
            int siblingIndex = currentSibling.GetSiblingIndex();
            int nextSiblingIndex = siblingIndex + 1;
            return currentSibling.parent.GetChild(nextSiblingIndex).gameObject;
        }
        catch(Exception ex)
        {
            Debug.LogError(ex);
            throw;
        }
    }
}
