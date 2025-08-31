using System.Collections.Generic;
using UnityEngine;

public static class Log
{
    public static void Message(string message, LogColors color = LogColors.None, MessageType messageType = MessageType.None)
    {
        string prefix = messageType == MessageType.None ? "" : $"[{messageType}]";
        Debug.Log(color == LogColors.None ? $"{prefix} {message}" : $"<color={color}>{prefix} {message}</color>");
    }

    public static void List<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            Debug.Log("The list is empty or null");
            return;
        }

        foreach (T item in list)
        {
            Debug.Log(item.ToString());
        }
    }

    public static void Array<T>(T[] array)
    {
        if (array == null || array.Length == 0)
        {
            Debug.Log("The array is empty or null");
            return;
        }

        foreach (T item in array)
        {
            Debug.Log(item.ToString());
        }
    }
}

public enum MessageType
{
    Error,
    Warning,
    Info,
    None
}

public enum LogColors
{
    None,
    Red,
    Green,
    Blue,
    Yellow,
    Gray,
    Pink,
    Purple,
    White,
    Black
}