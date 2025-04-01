using UnityEditor;
using UnityEngine;

namespace Eloi.Note
{
    [CustomEditor(typeof(LinkNoteMono), true)]
    public class NoteEditor_Link : Editor
    {
        public override void OnInspectorGUI()
        {
            LinkNoteMono myScript = (LinkNoteMono)target;
            DrawLinks(myScript);

            base.DrawDefaultInspector();
        }

        public static void DrawLinks(LinkNoteMono myScript, string titleMaintButton = null)
        {
         

                GUILayout.BeginHorizontal();
                GUILayout.Space(10);
            string display = "";    
                if (!string.IsNullOrWhiteSpace(myScript.m_link.m_linkName))
                    display = myScript.m_link.m_linkName;
            else if (!string.IsNullOrWhiteSpace(myScript.m_link.m_linkUrl))
                display = myScript.m_link.m_linkUrl;
            else
                display = "No Link";
                 if ( GUILayout.Button(display))
                    Application.OpenURL(myScript.m_link.m_linkUrl);

                GUILayout.Space(10);
                GUILayout.EndHorizontal();

        }
    }
}
