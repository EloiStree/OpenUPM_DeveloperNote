using UnityEngine;

namespace Eloi.Note
{
    [System.Serializable]
public class LinkNote_YoutubeVideo
{
    public string m_youtubeVideoId="";
    public ENUM_YoutubeThumbnailType m_thumbnailType= ENUM_YoutubeThumbnailType.Default;
   
    
    [ContextMenu("Open Youtube page")]
    public void OpenYoutube() {
        Application.OpenURL("https://www.youtube.com/watch?v="+m_youtubeVideoId);
    }

    public  void CheckForIdInGivenText()
    {
        if (m_youtubeVideoId == null || m_youtubeVideoId.Length <= 0)
            return;

        //https://www.youtube.com/watch?v=dQw4w9WgXcQ
        if (m_youtubeVideoId.IndexOf("youtube.com/watch?v=") > -1)
        {
            int startIndex = m_youtubeVideoId.LastIndexOf("v=");
            m_youtubeVideoId = m_youtubeVideoId.Substring(startIndex + 2);
        }
        //https://youtu.be/dQw4w9WgXcQ
        if (m_youtubeVideoId.IndexOf("youtu.com/") > -1) {
            int startIndex = m_youtubeVideoId.LastIndexOf("/");
            m_youtubeVideoId = m_youtubeVideoId.Substring(startIndex + 1);
        }
    }

    public  string GetVideoId()
    {
        return m_youtubeVideoId;
    }
}

}