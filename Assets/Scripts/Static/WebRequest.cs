using System.Threading.Tasks;
using UnityEngine.Networking;
using UnityEngine;
using System;

public static class WebRequest
{
    public static async Task<string> PostRequest(string link, params string[] fieldAndValues)
    {
        string result = null;
        WWWForm form = CreateDynamicForm(fieldAndValues);

        using (UnityWebRequest www = UnityWebRequest.Post($"{link}", form))
        {
            var asyncOp = www.SendWebRequest();
            while (!asyncOp.isDone)
            {
                await Task.Delay(1);
            }

            if (www.result == UnityWebRequest.Result.Success)
            {
                result = www.downloadHandler.text;
            }
            else
            {
                Debug.LogError("Error: " + www.error);
            }
        }

        return result;
    }

    public static async Task<T> GetRequest<T>(string link, params string[] fieldAndValues)
    {
        WWWForm form = CreateDynamicForm(fieldAndValues);

        using (UnityWebRequest www = UnityWebRequest.Post($"{link}", form))
        {
            var asyncOp = www.SendWebRequest();
            while (!asyncOp.isDone)
            {
                await Task.Delay(1);
            }

            if (www.result == UnityWebRequest.Result.Success)
            {
                T desarializeObject = JsonUtility.FromJson<T>(www.downloadHandler.text);
                return desarializeObject;
            }
            else
            {
                Debug.LogError("Error: " + www.error);
                return default;
            }
        }
    }


    public static WWWForm CreateDynamicForm(params string[] fieldAndValues)
    {
        if (fieldAndValues.Length % 2 != 0)
        {
            throw new ArgumentException("The number of arguments must be even.");
        }

        WWWForm form = new WWWForm();
        for (int i = 0; i < fieldAndValues.Length; i += 2)
        {
            string field = fieldAndValues[i];
            string value = fieldAndValues[i + 1];
            form.AddField(field, value);
        }

        return form;
    }
}