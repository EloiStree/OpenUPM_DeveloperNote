using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateSimpleTextFileForGodSakeEditor : MonoBehaviour
{
    [MenuItem("Assets/ꬲ🧰/Text/Create Text File", priority = 1)]
    private static void CreateTextFile()
    {
        string where = GetSelectedDirectoryPath();
        string fileName = "Text.txt";
        string filePath = Path.Combine(where, fileName);
        if (File.Exists(filePath))
        {
            Debug.LogError($"File already exists: {filePath}");
            return;
        }
        string content = "This is a simple text file.\n\n";
        File.WriteAllText(filePath, content);
        AssetDatabase.Refresh();

    }
    [MenuItem("Assets/ꬲ🧰/Text/Create Text Markdown", priority = 1)]
    private static void CreateMarkdowFile()
    {
        string where = GetSelectedDirectoryPath();
        string fileName = "Text.md";
        string filePath = Path.Combine(where, fileName);
        if (File.Exists(filePath))
        {
            Debug.LogError($"File already exists: {filePath}");
            return;
        }
        string content = "# Title\n\n## Subtitle\n\n- List item 1\n- List item 2\n\n";
        File.WriteAllText(filePath, content);
        AssetDatabase.Refresh();

    }


    public static string GetSelectedDirectoryPath()
    {
        string p = GetSelectedFilePathMethod();
        if (File.Exists(p))
        {
            return Path.GetDirectoryName(p);
        }
        if (Directory.Exists(p))
        {
            return p;
        }
        return "";
    }
    private static string GetSelectedFilePathMethod()
    {
        // Get the selected object(s) in the Project window
        UnityEngine.Object[] selectedObjects = Selection.objects;

        foreach (UnityEngine.Object obj in selectedObjects)
        {
            // Get the path of the selected object
            string assetPath = AssetDatabase.GetAssetPath(obj);

            if (!string.IsNullOrEmpty(assetPath))
            {
                // Convert the asset path to an absolute path
                string absolutePath = Path.GetFullPath(assetPath);
                return absolutePath;
            }

        }
        return "";
    }
}
