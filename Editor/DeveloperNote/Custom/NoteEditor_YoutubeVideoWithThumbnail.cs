using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(LinkNoteMono_YoutubeVideoWithThumbnail))]
    public class NoteEditor_YoutubeVideoWithThumbnail : Editor
    {

        //https://www.youtube.com/watch?v=s6TMa33niJo&t=133s
        public override void OnInspectorGUI()
        {
            LinkNoteMono_YoutubeVideoWithThumbnail myScript = (LinkNoteMono_YoutubeVideoWithThumbnail)target;
            if (myScript.m_link.m_thumbnail != null)
                DeveloperNoteEditorImageUtility.DrawImage(myScript.m_link.m_thumbnail, Open);
            if (GUILayout.Button("Open On youtube"))
            {
                myScript.OpenYoutube();
            }
            base.DrawDefaultInspector();
        }

        private void Open()
        {
            LinkNoteMono_YoutubeVideoWithThumbnail myScript = (LinkNoteMono_YoutubeVideoWithThumbnail)target;
            myScript.OpenYoutube();

        }

    }
}
