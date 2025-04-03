using Eloi.Note;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(NoteMono_MarkDown))]
    public class NoteEditor_MarkDown : Editor
    {

        public string m_text;
        public override void OnInspectorGUI()
        {
            base.DrawDefaultInspector();
            NoteMono_MarkDown myScript = (NoteMono_MarkDown)target;
            GUILayout.BeginHorizontal();
            
            if (GUILayout.Button("View as file"))
            {
                myScript.OpenMarkDownAsMarkdownFile();
            }
            if (GUILayout.Button("View on Browser"))
            {
                myScript.OpenMarkDownInBrowser();
            }

            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();

            if (GUILayout.Button("B"))
            {
                m_text=(" **Text** ");
            }
            if (GUILayout.Button("I"))
            {
                m_text=(" *Text* ");
            }
            if (GUILayout.Button("´"))
            {
                m_text=("´");
            }
            if (GUILayout.Button("Code"))
            {
                m_text=("´´´ Code ´´´");
            }
            if (GUILayout.Button(">"))
            {
                m_text=("\n> Quote\n> Quote\n");
            }
            if (GUILayout.Button("#"))
            {
                m_text=("\n# Title 1   \n");
            }
            if (GUILayout.Button("##"))
            {
                m_text=("\n## Title 2   \n");
            }
            if (GUILayout.Button("###"))
            {
                m_text=("\n### Title 3   \n");
            }
            if (GUILayout.Button("Line"))
            {
                m_text=("\n---------------------------  \n");
            }

            GUILayout.EndHorizontal();

            m_text = GUILayout.TextArea(m_text);


        }
       


    }

}
