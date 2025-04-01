using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Eloi.Note
{
    [CustomEditor(typeof(LinkNoteMono_LMGTFY))]
    public class NoteEditor_LMGTFY : Editor
    {


        public override void OnInspectorGUI()
        {
            LinkNoteMono_LMGTFY myScript = (LinkNoteMono_LMGTFY)target;

            if (GUILayout.Button("Let's me google that for you"))
            {
                myScript.OpenLMGTFY();
            }
            
           
            base.DrawDefaultInspector();
        }
    }
}
