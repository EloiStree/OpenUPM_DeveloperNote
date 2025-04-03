using Eloi.Note;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(LinkNoteMono_YoutubeVideo))]
    public class NoteEditor_YoutubeVideo : Editor
    {


        public override void OnInspectorGUI()
        {

            LinkNoteMono_YoutubeVideo myScript = (LinkNoteMono_YoutubeVideo)target;
            
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Open on Youtube"))
            {
                myScript.OpenYoutube();
            }
            GUILayout.EndHorizontal();
            base.DrawDefaultInspector();
        }
    }
}
