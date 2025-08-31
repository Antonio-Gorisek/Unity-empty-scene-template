using System;

namespace user.playerprefs
{
	[Serializable]
	public class User
	{
		public SerializableDictionary<string, bool> boolData = new SerializableDictionary<string, bool>();
		public SerializableDictionary<string, int> intData = new SerializableDictionary<string, int>();
		public SerializableDictionary<string, float> floatData = new SerializableDictionary<string, float>();
		public SerializableDictionary<string, string> stringData = new SerializableDictionary<string, string>();

		public void Save(string key, bool value) => boolData[key] = value;

		public void Save(string key, int value) => intData[key] = value;

		public void Save(string key, float value) => floatData[key] = value;

		public void Save(string key, string value) => stringData[key] = value;

		public bool LoadBool(string key, bool defaultValue)
		{
			if (boolData.ContainsKey(key))
				return boolData[key];
			else
				return defaultValue;
		}

		public int LoadInt(string key, int defaultValue)
		{
			if (intData.ContainsKey(key))
				return intData[key];
			else
				return defaultValue;
		}

		public float LoadFloat(string key, float defaultValue)
		{
			if (floatData.ContainsKey(key))
				return floatData[key];
			else
				return defaultValue;
		}

		public string LoadString(string key, string defaultValue)
		{
			if (stringData.ContainsKey(key))
				return stringData[key];
			else
				return defaultValue;
		}

		public void DeleteKey(string key)
		{
			boolData.Remove(key);
			intData.Remove(key);
			floatData.Remove(key);
			stringData.Remove(key);
		}

	}
}
