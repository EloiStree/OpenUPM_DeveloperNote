using Eloi.Note;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
namespace Eloi.Note
{
    public class LinkNoteMono_YoutubeVideoWithThumbnail : NoteMonoBehaviour
    {
        public LinkNote_YoutubeVideoWithThumbnail m_link = new LinkNote_YoutubeVideoWithThumbnail();

        [ContextMenu("Open Youtube page")]
        public void OpenYoutube()
        {
            m_link.OpenYoutube();
        }

        [ContextMenu("Download Thumbnail")]
        public void DownloadImageFrom(MonoBehaviour coroutineHolder)
        {
            m_link.DownloadImageFrom(coroutineHolder);
        }
        private void OnValidate()
        {
            m_link.OnValidate(this);
        }
    }
    [System.Serializable]
    public class LinkNote_YoutubeVideoWithThumbnail
    {
        public LinkNote_YoutubeVideo m_videoLink = new LinkNote_YoutubeVideo();
        public Texture2D m_thumbnail = null;
        public string m_thumbnailUrl = "";

        [ContextMenu("Open Youtube page")]
        public void OpenYoutube()
        {
            Application.OpenURL("https://www.youtube.com/watch?v=" + m_videoLink.GetVideoId());
        }

        [ContextMenu("Download Thumbnail")]
        public void DownloadImageFrom(MonoBehaviour coroutineHolder)
        {

            CheckForIdInGivenText();

            //Source:https://stackoverflow.com/questions/2068344/how-do-i-get-a-youtube-video-thumbnail-from-the-youtube-api
            string url = "https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/default.jpg";
            switch (m_videoLink.m_thumbnailType)
            {
                case ENUM_YoutubeThumbnailType.Default:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/default.jpg"); break;
                case ENUM_YoutubeThumbnailType.HqDefault:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/hqdefault.jpg"); break;
                case ENUM_YoutubeThumbnailType.MqDefault:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/mqdefault.jpg"); break;
                case ENUM_YoutubeThumbnailType.SdDefault:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/sddefault.jpg"); break;
                case ENUM_YoutubeThumbnailType.MaxResDefault:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/maxresdefault.jpg");
                    break;
                case ENUM_YoutubeThumbnailType._0:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/0.jpg");
                    break;
                case ENUM_YoutubeThumbnailType._1:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/1.jpg");
                    break;
                case ENUM_YoutubeThumbnailType._2:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/2.jpg");
                    break;
                case ENUM_YoutubeThumbnailType._3:
                    url = ("https://img.youtube.com/vi/" + m_videoLink.m_youtubeVideoId + "/3.jpg");
                    break;
                default:
                    break;
            }
            m_thumbnailUrl = url;
            if (coroutineHolder.gameObject.activeInHierarchy)
                coroutineHolder.StartCoroutine(DownloadImageFrom(url));
            //base.m_imageUrl = url;
            //SetWithURL(url);
        }
        private IEnumerator DownloadImageFrom(string url)
        {
            if (url == null)
            {
                m_thumbnail = null;
                yield break;
            }
            using (UnityWebRequest www = UnityWebRequestTexture.GetTexture(url))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    Debug.LogError(www.error);
                    m_thumbnail = null;
                    Debug.LogError("Failed to download image");
                }
                else
                {
                    m_thumbnail = DownloadHandlerTexture.GetContent(www);

                }
            }
        }

        private string m_previousYoutubeVideoId;
        private ENUM_YoutubeThumbnailType m_previousThumbnailType;
        public void OnValidate(MonoBehaviour coroutineHolder)
        {

            if (m_previousYoutubeVideoId == null)
                m_previousYoutubeVideoId = "";

            if (m_videoLink.m_youtubeVideoId == null)
                m_videoLink.m_youtubeVideoId = "";

            if (m_videoLink.m_youtubeVideoId == "")
            {
                m_previousYoutubeVideoId = "";
                m_thumbnail = null;
            }

            bool hadChanged =
                m_previousThumbnailType != m_videoLink.m_thumbnailType
            || m_previousYoutubeVideoId != m_videoLink.m_youtubeVideoId;

            if (hadChanged)
            {
                CheckForIdInGivenText();
                m_previousYoutubeVideoId = m_videoLink.m_youtubeVideoId;
                m_previousThumbnailType = m_videoLink.m_thumbnailType;
                DownloadImageFrom(coroutineHolder);

            }

        }

        private void CheckForIdInGivenText()
        {
            if (m_videoLink.m_youtubeVideoId == null)
                return;
            //https://www.youtube.com/watch?v=dQw4w9WgXcQ
            if (m_videoLink.m_youtubeVideoId.IndexOf("youtube.com/watch?v=") > -1)
            {
                int startIndex = m_videoLink.m_youtubeVideoId.LastIndexOf("v=");
                m_videoLink.m_youtubeVideoId = m_videoLink.m_youtubeVideoId.Substring(startIndex + 2);

                RemoveLastPart();

            }
            //https://youtu.be/dQw4w9WgXcQ
            if (m_videoLink.m_youtubeVideoId.IndexOf("youtu.be/") > -1)
            {
                int startIndex = m_videoLink.m_youtubeVideoId.LastIndexOf("/");
                m_videoLink.m_youtubeVideoId = m_videoLink.m_youtubeVideoId.Substring(startIndex + 1);
                RemoveLastPart();
            }
        }

        private void RemoveLastPart()
        {
            int andIndex = m_videoLink.m_youtubeVideoId.LastIndexOf("&");
            if (andIndex > 0)
                m_videoLink.m_youtubeVideoId = m_videoLink.m_youtubeVideoId.Substring(0, andIndex);
            andIndex = m_videoLink.m_youtubeVideoId.LastIndexOf("?");
            if (andIndex > 0)
                m_videoLink.m_youtubeVideoId = m_videoLink.m_youtubeVideoId.Substring(0, andIndex);
        }
    }

}