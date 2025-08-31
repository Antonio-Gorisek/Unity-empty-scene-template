using user.playerprefs;
using UnityEngine;
using System.IO;
using System;

/// <summary>
/// Provides static methods for loading photo textures and JSON data.
/// </summary>
public static class Load
{
	/// <summary>
	/// Loads data of type T from the saved user data based on the provided key.
	/// If the data does not exist, returns the provided defaultValue.
	/// </summary>
	/// <typeparam name="T">The type of data to load.</typeparam>
	/// <param name="key">The key used to identify the data.</param>
	/// <param name="defaultValue">The default value to return if the data does not exist.</param>
	/// <returns>The loaded data of type T, or the default value if not found.</returns>
	public static T Data<T>(string key)
	{
		// Load user data from file
		User userData = LoadUserData();

		// If user data is not available, return default value
		if (userData == null)
			return default;

		// Load the value based on its type
		switch (Type.GetTypeCode(typeof(T)))
		{
			case TypeCode.Boolean:
				return (T)(object)userData.LoadBool(key, default);
			case TypeCode.Int32:
				return (T)(object)userData.LoadInt(key, default);
			case TypeCode.Single:
				return (T)(object)userData.LoadFloat(key, default);
			case TypeCode.String:
				return (T)(object)userData.LoadString(key, default);
			default:
				Debug.LogError($"Type '{typeof(T).Name}' is not supporetd. Only: bool, int, float, string.");
				return default;
		}
	}

	/// <summary>
	/// Loads user data from the file system.
	/// </summary>
	/// <returns>The loaded User object, or null if the file does not exist.</returns>
	private static User LoadUserData()
	{
		string filePath = Save.GetSaveFilePath();
		if (File.Exists(filePath))
		{
			string json = File.ReadAllText(filePath);
			return JsonUtility.FromJson<User>(json);
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Retrieves the JSON data as a string for the specified file name.
	/// </summary>
	/// <param name="fileName">The name of the JSON file to load.</param>
	/// <returns>The JSON data as a string or null if the file is not found.</returns>
	public static string GetJson(string fileName)
	{
		string jsonFolderPath = Path.Combine(Application.persistentDataPath, "Json");
		if (!Directory.Exists(jsonFolderPath))
		{
			Debug.LogWarning("Json folder not found.");
			Directory.CreateDirectory(jsonFolderPath);
			return null;
		}
		string jsonFilePath = Path.Combine(jsonFolderPath, fileName + ".json");
		if (!File.Exists(jsonFilePath))
		{
			Debug.LogWarning("Json file not found: " + jsonFilePath);
			return null;
		}
		string jsonData = File.ReadAllText(jsonFilePath);

		return jsonData;
	}


    public static bool HasKey(string key)
	{
		// Load user data from file
		User userData = LoadUserData();

		// If user data is not available, return false
		if (userData == null)
			return false; 

		// Check if the key exists in any of the dictionaries
		return userData.boolData.ContainsKey(key) ||
			   userData.intData.ContainsKey(key) ||
			   userData.floatData.ContainsKey(key) ||
			   userData.stringData.ContainsKey(key);
	}
}
