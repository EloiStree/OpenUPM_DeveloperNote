using System;
using UnityEngine;
namespace Eloi.Note
{
    public static class NoteLink
    {
        [System.Serializable]

        public class LinksArray
        {

            public string[] m_links;
        }
        [System.Serializable]
        public class Link
        {

            public string m_link;
        }
        [System.Serializable]
        public class NamedLinkArray
        {


            public NamedLink[] m_namedUrls = new NamedLink[] { new NamedLink("Hello", @"https://en.wikipedia.org/wiki/""Hello,_World!") };

            public NamedLinkArray(string label, string url)
            {
                m_namedUrls = new NamedLink[] { new NamedLink(label, url) };

            }
            public NamedLinkArray() : this(" ", "https://")
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
        public class NamedLink
        {
            public string m_linkName = "";
            public string m_linkUrl = "";

            public NamedLink(string linkName, string url)
            {
                m_linkName = linkName;
                m_linkUrl = url;
            }

            public NamedLink()
            {
            }

            public void OpenLink()
            {
                Application.OpenURL(m_linkUrl);
            }
        }

    }
}