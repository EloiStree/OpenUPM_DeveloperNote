using Eloi.Note;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Note
{
    public class NoteMono_KeyWordsToGoogle : TextNoteMono
    {
        [TextArea(0, 2)]
        [Tooltip("Split by , ; \\n")]
        public string m_keywordsUseToSearch;
        char[] m_spliter = new char[] { ',', ';', '\n' };
        Note_KeyWordsToGoogle m_note;

        private void RefreshKeyWorks()
        {
            m_note.m_keywordsToSearch = m_keywordsUseToSearch.Replace(" ", "%20").Split(m_spliter);
        }

        [ContextMenu("Search On Google")]
        public void SearchOnGoogle()
        {
            RefreshKeyWorks();
            Application.OpenURL("https://www.google.com/search?q=" + string.Join("+", m_note.m_keywordsToSearch));
        }
        [ContextMenu("Search On Duck Duck")]
        public void SearchOnDuckDuck()
        {
            RefreshKeyWorks();
            Application.OpenURL("https://duckduckgo.com/?q=" + string.Join("+", m_note.m_keywordsToSearch));
        }
        [ContextMenu("Search On All")]
        public void SearchOnAll()
        {
            SearchOnGoogle();
            SearchOnDuckDuck();
        }
    }
}
