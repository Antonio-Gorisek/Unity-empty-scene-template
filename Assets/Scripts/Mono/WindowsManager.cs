using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowsManager : MonoBehaviour
{
    // TODO: Dodati ako windows ima praznu vrijednost da je odmah obriše.

    [HideInInspector] public int currentWindowIndex;
    [HideInInspector] public int currentWindowName;
    public List<GameObject> windows = new List<GameObject>();

    private string _defaultWindowName = "NewWindow";
    private string _defaultCloneSufix = "(Clone)";

    public string DefaultWindowName
    {
        private get {  return _defaultWindowName; }
        set { _defaultWindowName = value; }
    }
    public string DefaultCloneSufix
    {
        private get { return _defaultCloneSufix; }
        set { _defaultCloneSufix = value; }
    }

    public string CreateNewWindow()
    {
        GameObject canvas = GameObject.Find("MainCanvas");

        if (canvas != null)
        {
            string objectName = _defaultWindowName;
            if (canvas.transform.childCount > 0)
            {
                objectName += " " + _defaultCloneSufix;
            }

            GameObject gameObject = new GameObject($"{objectName}", typeof(RectTransform));
            gameObject.AddComponent<OnDestroyListener>();
            gameObject.AddComponent<CanvasGroup>();
            gameObject.transform.SetParent(transform);
            
            windows.Add(gameObject);
            return gameObject.name;
        }
        else
        {
            GameObject newMainCanvas = new GameObject("MainCanvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            Canvas newCanvas = newMainCanvas.GetComponent<Canvas>();
            newCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
            newCanvas.GetComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

            CreateNewWindow();
        }
        return null;
    }

    public void OpenWindowByName(string name)
    {
        DisableAllWindows();
        foreach (var window in windows)
        {
            window.SetActive(window.name == name);
        }
    }

    public void OpenWindowByIndex(int index)
    {
        DisableAllWindows();
        windows[index].SetActive(true);
    }

    public void OpenNextWindow()
    {
        DisableAllWindows();
        windows[currentWindowIndex + 1].SetActive(true);
    }
    
    public void OpenPreviousWindow()
    {
        DisableAllWindows();
        windows[currentWindowIndex - 1].SetActive(true);
    }


    private void DisableAllWindows()
    {
        for (int i = 0; i < windows.Count; i++)
        {
            windows[i].SetActive(false);
        }
    }

    /// <summary>
    /// TODO: RIJEŠITI ANIMATOR KLASU
    /// </summary>
    public void OnWindowChange()
    {
        for (int i = 0; i < windows.Count; i++)
        {
            windows[i].SetActive(i == currentWindowIndex);
        }

        if (Application.isPlaying)
        {
            
        }
    }


    public IEnumerator LerpCanvasGroupAlpha(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = endAlpha;
    }


    public void FadeInCanvasGroup(CanvasGroup canvasGroup, float duration)
    {
        StartCoroutine(LerpCanvasGroupAlpha(canvasGroup, 0f, 1f, duration));
    }

    public void FadeOutCanvasGroup(CanvasGroup canvasGroup, float duration)
    {
        StartCoroutine(LerpCanvasGroupAlpha(canvasGroup, 1f, 0f, duration));
    }

}

[ExecuteInEditMode]
public class OnDestroyListener : MonoBehaviour
{
    private void OnDestroy()
    {
        GameObject windowManagerObj = GetObject.GetParent(transform);
        WindowsManager windowManager = windowManagerObj.GetComponent<WindowsManager>();

        windowManager.windows.Remove(gameObject);
    }
}