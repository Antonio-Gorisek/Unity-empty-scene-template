using System;

/// <summary>
/// **Warning:** This class is used to block the usage of PlayerPrefs.
/// The reason for this is that some Android devices retain saved values even after the application is deleted.
/// This causes various issues when the application is reinstalled because it takes values from the old APK, 
/// for example, skipping the introduction where the user needs to accept camera and notification permissions, and much more.
/// For data storage, we use classes (Save & Load) that function on the same principle as PlayerPrefs but save data in JSON format.
/// </summary>
[Obsolete("Usage of PlayerPrefs is not allowed in this project.", true)]
public static class PlayerPrefs
{
	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static void SetInt(string key, int value) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static void SetFloat(string key, float value) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static void SetString(string key, string value) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static void DeleteKey(string key) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static void DeleteAll() => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static void Save() => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static string GetString(string key, string defaultValue = "") => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static float GetFloat(string key, float defaultValue = 0.0f) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static bool HasKey(string key) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

	[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
	public static int GetInt(string key, int defaultValue = 0) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");
}

// Additionally, block access to UnityEngine.PlayerPrefs to prevent usage
namespace UnityEngine
{
	public class PlayerPrefs
	{
		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static void SetInt(string key, int value) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static void SetFloat(string key, float value) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static void SetString(string key, string value) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static void DeleteKey(string key) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static void DeleteAll() => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static void Save() => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static string GetString(string key, string defaultValue = "") => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static float GetFloat(string key, float defaultValue = 0.0f) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static bool HasKey(string key) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");

		[Obsolete("Usage of UnityEngine.PlayerPrefs is not allowed in this project.", true)]
		public static int GetInt(string key, int defaultValue = 0) => throw new InvalidOperationException("UnityEngine.PlayerPrefs should not be used.");
	}
}