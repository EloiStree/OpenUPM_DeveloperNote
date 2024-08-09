using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi
{
    public class DeveloperNote_LMGTFY : DeveloperNoteObjectMono
    {
        public string m_sentenceToSearch = "";

        [ContextMenu("Let's me google that for you")]
        public void OpenLMGTFY()
        {
            string url = "https://letmegoogleforyou.com/?q=" + m_sentenceToSearch.Replace(" ", "+");
            Application.OpenURL(url);
            
        }

        
    }
}
