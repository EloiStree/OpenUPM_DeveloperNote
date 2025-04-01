using UnityEngine;

namespace Eloi.Note
{
    [System.Serializable]
    public class LinkNote_LMGTFY 
    {
        public string m_sentenceToSearch = "";
        public void OpenLMGTFY()
        {
            string url = "https://letmegoogleforyou.com/?q=" + m_sentenceToSearch.Replace(" ", "+");
            Application.OpenURL(url);

        }
    }
}
