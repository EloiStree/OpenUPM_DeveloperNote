using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(NoteMono_ImageInProject), true)]
    public class NoteEditor_ImageInProject : Editor
    {


        public override void OnInspectorGUI()
        {
            NoteMono_ImageInProject myScript = (NoteMono_ImageInProject)target;
            DeveloperNoteEditorImageUtility.DrawImage(myScript.m_note.m_image, () => { DeveloperNoteEditorImageUtility.OpenInBrowser(myScript.m_note.m_image); });
            base.DrawDefaultInspector();
        }
    }
}
