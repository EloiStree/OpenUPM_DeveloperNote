using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Eloi
{
    [CustomEditor(typeof(DeveloperNote_ImageInProject), true)]
    public class DeveloperNoteEditor_ImageInProject : Editor
    {


        public override void OnInspectorGUI()
        {
            DeveloperNote_ImageInProject myScript = (DeveloperNote_ImageInProject)target;
            DeveloperNoteEditorImageUtility.DrawImage(myScript.m_image, () => { DeveloperNoteEditorImageUtility.OpenInBrowser(myScript.m_image); });
            base.DrawDefaultInspector();
        }
    }
}
