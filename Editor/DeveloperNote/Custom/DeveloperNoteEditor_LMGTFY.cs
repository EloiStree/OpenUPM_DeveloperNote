using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Eloi
{
    [CustomEditor(typeof(DeveloperNote_LMGTFY))]
    public class DeveloperNoteEditor_LMGTFY : Editor
    {


        public override void OnInspectorGUI()
        {
            DeveloperNote_LMGTFY myScript = (DeveloperNote_LMGTFY)target;

            if (GUILayout.Button("Let's me google that for you"))
            {
                myScript.OpenLMGTFY();
            }
            
           
            base.DrawDefaultInspector();
        }
    }
}
