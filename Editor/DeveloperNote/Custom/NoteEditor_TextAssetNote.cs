using Eloi.Note;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
namespace Eloi.Note
{
    [CustomEditor(typeof(TextAssetNoteMono), true)]
    public class NoteEditor_TextAssetNote : Editor
    {

        public override void OnInspectorGUI()
        {
            base.DrawDefaultInspector();
            TextAssetNoteMono myScript = (TextAssetNoteMono)target;

            if (myScript.m_note != null && myScript.m_note.m_textNote==null)
            {
                if (GUILayout.Button("Create note")) { 
                
                    string projectPath = Directory.GetCurrentDirectory();
                    string relativeFolder = "Assets/Resources/Note";
                    string fullPath = Path.Combine(projectPath, relativeFolder);
                    string guid = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string fileName = "Note_" + guid + ".txt";
                    string path = Path.Combine(fullPath, fileName);
                    string projectRelativePath = Path.Combine(relativeFolder, fileName);
                    string directory = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    File.WriteAllText(path, "New Note");

                    AssetDatabase.Refresh();
                    Thread.Sleep(2000);
                    TextAsset t = AssetDatabase.LoadAssetAtPath<TextAsset>(projectRelativePath);
                    myScript.m_note.m_textNote = t;
                }

            }

            if (GUILayout.Button("Edit")) {

                string filePath = AssetDatabase.GetAssetPath(myScript.m_note.m_textNote);
                string fullFilePath = Directory.GetCurrentDirectory() + "/" + filePath;
                if (string.IsNullOrEmpty(fullFilePath))
                {
                    Debug.LogError("TextAsset is not assigned or not a valid path.");
                    return;
                }
                Application.OpenURL("file://" + fullFilePath);
            }
            if (myScript.m_note == null)
            {
                EditorGUILayout.HelpBox("No Note", MessageType.Warning);
                return;
            }
            else { 
                GUILayout.TextField(myScript.m_note.GetNote(), GUILayout.Height(400));
            }
        }
    }
}
