using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace Eloi.Note

{
    [CustomEditor(typeof(LinksNoteMono), true)]
    public class NoteEditor_Links : Editor
    {
        public override void OnInspectorGUI()
        {
            LinksNoteMono myScript = (LinksNoteMono)target;
            DrawLinks(myScript);

            base.DrawDefaultInspector();
        }

        public static void DrawLinks(LinksNoteMono myScript, string titleMaintButton=null)
        {
            //GUILayout.BeginHorizontal();
            //if (GUILayout.Button(titleMaintButton==null? "Open all Link(s)": titleMaintButton))
            //{
            //    myScript.OpenLinks();
            //}

            //GUILayout.EndHorizontal();
            foreach (var item in myScript.m_links.m_namedUrls)
            {

                GUILayout.BeginHorizontal();
                GUILayout.Space(10);
                if (!string.IsNullOrEmpty(item.m_linkUrl) && GUILayout.Button(item.m_linkName.Length==0? item.m_linkUrl: item.m_linkName))
                    Application.OpenURL(item.m_linkUrl);

                GUILayout.Space(10);
                GUILayout.EndHorizontal();

            }
           
            
           
        }
    }
}
