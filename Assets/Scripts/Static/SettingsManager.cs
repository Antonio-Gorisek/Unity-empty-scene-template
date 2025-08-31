using UnityEngine;

public static class SettingsManager
{
    public static void SetAntiAlisaing(int level)
    {
        QualitySettings.antiAliasing = level;

        Save.Data("Settings_AntiAliasing", level.ToString());
        Debug.Log($"AntiAliasing set to {level}");
    }

    public static void SetDrawDistance(int distance)
    {
        Camera.main.farClipPlane = distance;
        Save.Data("Settings_DrawDistance", distance.ToString());
        Debug.Log($"DrawDistance set to {distance}");
    }

    public static void SetVSync(bool enabled)
    {
        QualitySettings.vSyncCount = enabled ? 1 : 0;
        Save.Data("Settings_VSync", enabled.ToString());
        Debug.Log($"VSync set to {enabled}");
    }

    public static void SetTextureQuality(int level)
    {
        QualitySettings.masterTextureLimit = level;
        Save.Data("Settings_TextureQuality", level.ToString());
        Debug.Log($"TextureQuality set to {level}");
    }

    public static void SetGraphicQuality(int level)
    {
        QualitySettings.SetQualityLevel(level, true);
        Save.Data("Settings_GraphicQuality", level.ToString());
        Debug.Log($"GraphicQuality set to {level}");
    }

    public static void SetResolution(int width, int height, bool fullScreen)
    {
        Screen.SetResolution(width, height, true);
        Save.Data("Settings_ResolutionWidth", width.ToString());
        Save.Data("Settings_ResolutionHeight", height.ToString());
        Save.Data("Settings_FullScreen", fullScreen.ToString());
        Debug.Log($"SetResolution set to {width}x{height} and fullscreen {fullScreen}");
    }
}
