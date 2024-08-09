using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public abstract class AbstractDevCreditMono_SocialLink : MonoBehaviour
{
    public Setup m_setup = new Setup();

    [System.Serializable]
    public class Setup { 
    public string m_developerSocialLink = "";
    [HideInInspector] public  string m_previousUrl= "";
    }
    public void OnValidate()
    {
        GetPathToStoreLink();
        if (m_setup.m_previousUrl != m_setup.m_developerSocialLink)
            {
            m_setup.m_previousUrl = m_setup.m_developerSocialLink;
            SaveLink();
        }
    }

    private void SaveLink()
    {
        if (m_setup.m_developerSocialLink != null && m_setup.m_developerSocialLink !=null) { 
        
            File.WriteAllText(GetPathToStoreLink(), m_setup.m_developerSocialLink);
        }
    }
    public abstract string GetFileName();
    private void Reset()
    {

        m_setup.m_previousUrl = m_setup.m_developerSocialLink = GetTextStore();
    }

    [ContextMenu("Open Url")]
    public void OpenUrl()
    {

        Application.OpenURL(m_setup.m_developerSocialLink);
    }


    private string GetTextStore()
    {
        if (!File.Exists(GetPathToStoreLink()))
        {
            return "";
        }
        return File.ReadAllText(GetPathToStoreLink());
    }

    private  string GetPathToStoreLink()
    {
       return Path.Combine(Application.temporaryCachePath, GetFileName());
    }
}
