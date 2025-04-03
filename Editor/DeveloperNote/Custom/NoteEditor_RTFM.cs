using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(LinksNoteMono_RTFM))]
    public class NoteEditor_RTFM : Editor
    {
        public override void OnInspectorGUI()
        {
            LinksNoteMono_RTFM myScript = (LinksNoteMono_RTFM)target;

            NoteEditor_Links.DrawLinks(myScript, "Read the manuals");
          
            base.DrawDefaultInspector();
        }
    }
}
