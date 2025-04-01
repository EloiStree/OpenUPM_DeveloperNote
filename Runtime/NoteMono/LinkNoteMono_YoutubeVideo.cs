using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.Note
{
    public class LinkNoteMono_YoutubeVideo : NoteMonoBehaviour
{
    public LinkNote_YoutubeVideo m_videoLink;

    [ContextMenu("Open Youtube page")]
    public void OpenYoutube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=" + m_videoLink.GetVideoId());
    }

    protected  void OnValidate()
    {

        CheckForIdInGivenText();
    }
    private void CheckForIdInGivenText()
    {
            if (m_videoLink == null)
                return;
            if (m_videoLink.m_youtubeVideoId == null || m_videoLink.m_youtubeVideoId.Length <= 0)
            return;

        //https://www.youtube.com/watch?v=dQw4w9WgXcQ
        if (m_videoLink.m_youtubeVideoId.IndexOf("youtube.com/watch?v=") > -1)
        {
            int startIndex = m_videoLink.m_youtubeVideoId.LastIndexOf("v=");
            m_videoLink.m_youtubeVideoId = m_videoLink.m_youtubeVideoId.Substring(startIndex + 2);
        }
        //https://youtu.be/dQw4w9WgXcQ
        if (m_videoLink.m_youtubeVideoId.IndexOf("youtu.be/") > -1)
        {
            int startIndex = m_videoLink.m_youtubeVideoId.LastIndexOf("/");
            m_videoLink.m_youtubeVideoId = m_videoLink.m_youtubeVideoId.Substring(startIndex + 1);
        }
    }
}

}