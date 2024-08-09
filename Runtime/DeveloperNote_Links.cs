using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LinksClass {
    public Setup m_setup = new Setup();
    [System.Serializable]
    public class Setup
    {
        public Links m_links = new Links();
    }
    [System.Serializable]
    public class Links
    {


        public NameLink[] m_namedUrls = new NameLink[] { new NameLink("Hello", @"https://en.wikipedia.org/wiki/""Hello,_World!") };

        public Links(string label, string url)
        {
            m_namedUrls = new NameLink[] { new NameLink(label, url) };

        }
        public Links(): this(" ", "https://")
        {


        }

        public void OpenLinks()
        {

            for (int i = 0; i < m_namedUrls.Length; i++)
            {
                if (!string.IsNullOrEmpty(m_namedUrls[i].m_urls))
                    Application.OpenURL(m_namedUrls[i].m_urls);
            }
        }
    }
    [System.Serializable]
    public class NameLink
    {
        public string m_linkName;
        public string m_urls;

        public NameLink(string linkName, string urls)
        {
            m_linkName = linkName;
            m_urls = urls;
        }

        public NameLink()
        {
        }
    }

}

public class DeveloperNote_Links : DeveloperNoteObjectMono
{

    public LinksClass.Setup m_setup = new LinksClass.Setup();

    [ContextMenu("Open Links")]
    public void OpenLinks()
    {
        m_setup. m_links.OpenLinks();
    }
}


public class DeveloperNote_LinksWithNoteCredited : DeveloperNoteWithAuthorMono
{

    public LinksClass.Setup m_setup = new LinksClass.Setup();

    [ContextMenu("Open Links")]
    public void OpenLinks()
    {
        m_setup.m_links.OpenLinks();
    }
}