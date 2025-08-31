using UnityEditor;

public static class CustomScriptTemplates
{
    [MenuItem("Assets/Create/CustomCode/Class", priority = 80)]
    public static void CreateClass()
    {
        string templatePath = "Assets/Editor/ScriptTemplates/Class.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "Class.cs");
    }

    [MenuItem("Assets/Create/CustomCode/StaticClass", priority = 80)]
    public static void CreateStaticClass()
    {
        string templatePath = "Assets/Editor/ScriptTemplates/Static-Class.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "StaticClass.cs");
    }

    [MenuItem("Assets/Create/CustomCode/InterfaceClass", priority = 80)]
    public static void CreateInterfaceClass()
    {
        string templatePath = "Assets/Editor/ScriptTemplates/Interface-Class.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "InterfaceClass.cs");
    }

    [MenuItem("Assets/Create/CustomCode/StructClass", priority = 80)]
    public static void CreateStructClass()
    {
        string templatePath = "Assets/Editor/ScriptTemplates/Struct-Class.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "Struct-Class.cs");
    }
    
    [MenuItem("Assets/Create/CustomCode/AbstractClass", priority = 80)]
    public static void CreateAbstractClass()
    {
        string templatePath = "Assets/Editor/ScriptTemplates/Abstract-Class.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "AbstractClass.cs");
    }

    [MenuItem("Assets/Create/CustomCode/ScriptableObject", priority = 80)]
    public static void CreateScriptableObject()
    {
        string templatePath = "Assets/Editor/ScriptTemplates/Scriptable-Object.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "Scriptable-Object.cs");
    }
}
