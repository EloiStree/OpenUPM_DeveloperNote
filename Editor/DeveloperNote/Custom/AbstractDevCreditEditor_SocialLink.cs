using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Eloi
{
    [CustomEditor(typeof(AbstractDevCreditMono_SocialLink),true)]
    public class AbstractDevCreditEditor_SocialLink : Editor
    {


        public override void OnInspectorGUI()
        {

            AbstractDevCreditMono_SocialLink myScript = (AbstractDevCreditMono_SocialLink)target;
            
            GUILayout.BeginHorizontal();
            if (GUILayout.Button(myScript.m_setup.m_developerSocialLink))
            {
                myScript.OpenUrl();
            }
            GUILayout.EndHorizontal();
            base.DrawDefaultInspector();
        }
    }
}
