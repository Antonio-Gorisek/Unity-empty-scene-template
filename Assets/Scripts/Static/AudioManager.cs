using UnityEngine;

public static class AudioManager
{
    public static void PlayFromResources(string soundFileName, float volume = 1.0f, float pitch = 1.0f)
    {
        AudioClip soundClip = Resources.Load<AudioClip>($"Sound Effects/{soundFileName}");

        if (soundClip == null)
        {
            Debug.LogError($"Sound clip with name {soundFileName} not found in Resources folder.");
            return;
        }

        GameObject soundGameObject = new GameObject("SoundEffect");
        AudioSource soundSource = soundGameObject.AddComponent<AudioSource>();
        soundSource.clip = soundClip;
        soundSource.pitch = pitch;
        soundSource.volume = volume;
        soundSource.Play();

        Object.Destroy(soundGameObject, soundClip.length);
    }

    public static void PlayAudioClip(AudioClip soundClipFile, float volume = 1.0f, float pitch = 1.0f)
    {
        if (soundClipFile == null)
        {
            Debug.LogError($"Sound clip not found.");
            return;
        }

        GameObject soundGameObject = new GameObject("SoundEffect");
        AudioSource soundSource = soundGameObject.AddComponent<AudioSource>();
        soundSource.clip = soundClipFile;
        soundSource.pitch = pitch;
        soundSource.volume = volume;
        soundSource.Play();

        Object.Destroy(soundGameObject, soundClipFile.length);
    }
}
