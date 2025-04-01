//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//namespace Eloi
//{
//    [CustomEditor(typeof(LinksNoteMono),true)]
//    public class AbstractDevCreditEditor_SocialLink : Editor
//    {


//        public override void OnInspectorGUI()
//        {

//            AbstractCreditMono_SocialLink myScript = (AbstractCreditMono_SocialLink)target;
            
//            GUILayout.BeginHorizontal();
//            if (GUILayout.Button(myScript.m_link.m_socialLink))
//            {
//                myScript.OpenUrl();
//            }
//            GUILayout.EndHorizontal();
//            base.DrawDefaultInspector();
//        }
//    }
//}
