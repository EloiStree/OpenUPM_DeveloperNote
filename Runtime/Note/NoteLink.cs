using System;
using UnityEngine;

public static class NoteLink {
    [System.Serializable]
   
    public class LinksArray {

        public string[] m_links;
    }
    [System.Serializable]
    public class Link { 
    
        public string m_link;
    }
    [System.Serializable]
    public class NameLinkArray
    {


        public NameLink[] m_namedUrls = new NameLink[] { new NameLink("Hello", @"https://en.wikipedia.org/wiki/""Hello,_World!") };

        public NameLinkArray(string label, string url)
        {
            m_namedUrls = new NameLink[] { new NameLink(label, url) };

        }
        public NameLinkArray(): this(" ", "https://")
        {


        }

        public void OpenLinks()
        {

            for (int i = 0; i < m_namedUrls.Length; i++)
            {
                if (!string.IsNullOrEmpty(m_namedUrls[i].m_linkUrl))
                    Application.OpenURL(m_namedUrls[i].m_linkUrl);
            }
        }
    }
    [System.Serializable]
    public class NameLink
    {
        public string m_linkName="";
        public string m_linkUrl="";

        public NameLink(string linkName, string url)
        {
            m_linkName = linkName;
            m_linkUrl = url;
        }

        public NameLink()
        {
        }

        public  void OpenLink()
        {
            Application.OpenURL(m_linkUrl);
        }
    }

}
