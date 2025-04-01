using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.Note
{
    public class LinkNoteMono_LMGTFY : NoteMonoBehaviour
    {
        public LinkNote_LMGTFY m_letMeGoogleThatForYou;

        [ContextMenu("Let's me google that for you")]
        public void OpenLMGTFY()
        {
            string url = "https://letmegooglethat.com/?q=" + m_letMeGoogleThatForYou.m_sentenceToSearch.Replace(" ", "+");
            Application.OpenURL(url);

        }


    }
}
