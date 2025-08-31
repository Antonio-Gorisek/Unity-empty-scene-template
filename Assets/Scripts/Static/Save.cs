using user.playerprefs;
using UnityEngine;
using System.IO;
using System;

/// <summary>
/// Provides static methods for saving photo and JSON data.
/// </summary>
public static class Save
{
	private static readonly string saveFileName = "LocalUser/UserData.json";

	/// <summary>
	/// Saves data of type T with the provided key.
	/// </summary>
	/// <typeparam name="T">The type of data to save.</typeparam>
	/// <param name="key">The key used to identify the data.</param>
	/// <param name="value">The value to save.</param>
	public static void Data<T>(string key, T value)
	{
		// Load user data from file
		User userData = LoadUserData();

		// If user data is not available, create new instance
		if (userData == null)
			userData = new User();

		// Save the value based on its type
		if (typeof(T) == typeof(bool))
			userData.Save(key, (bool)(object)value);
		else if (typeof(T) == typeof(int))
			userData.Save(key, (int)(object)value);
		else if (typeof(T) == typeof(float))
			userData.Save(key, (float)(object)value);
		else if (typeof(T) == typeof(string))
			userData.Save(key, (string)(object)value); 
		else
			Debug.LogError($"Type '{typeof(T).Name}' is not supporetd. Only: bool, int, float, string.");

		// Save user data to file
		SaveUserData(userData);
	}

	/// <summary>
	/// Deletes the data associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the data to delete.</param>
	public static void DeleteKey(string key)
	{
		// Load user data from file
		User userData = LoadUserData();

		// If user data is not available, return
		if (userData == null)
			return;

		// Delete data associated with the key
		userData.DeleteKey(key);

		// Save updated user data to file
		SaveUserData(userData);
	}

	/// <summary>
	/// Deletes all saved data.
	/// </summary>
	public static void DeleteAll()
	{
		// Delete the save file
		File.Delete(GetSaveFilePath());
	}

	/// <summary>
	/// Loads user data from the file system.
	/// </summary>
	/// <returns>The loaded User object, or null if the file does not exist.</returns>
	private static User LoadUserData()
	{
		// Get the file path for saving
		string filePath = GetSaveFilePath();

		// If the file exists, load and deserialize user data
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
    /// Saves user data to the file system.
    /// </summary>
    /// <param name="userData">The User object to save.</param>
    private static void SaveUserData(User userData)
    {
        // Get the file path for saving
        string filePath = GetSaveFilePath();

        // Create directory if it doesn't exist
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Serialize and save user data to file
        string json = JsonUtility.ToJson(userData);
        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// Gets the file path for saving user data.
    /// </summary>
    /// <returns>The file path for saving user data.</returns>
    public static string GetSaveFilePath()
	{
		return Path.Combine(Application.persistentDataPath, saveFileName);
	}
}
