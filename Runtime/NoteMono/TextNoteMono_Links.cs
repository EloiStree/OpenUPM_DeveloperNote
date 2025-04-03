using Eloi.Note;
using UnityEngine;
namespace Eloi.Note
{
    public class TextNoteMono_Links : TextNoteMono
    {

        public NoteLink.NamedLinkArray m_links = new NoteLink.NamedLinkArray();

        [ContextMenu("Open Links")]
        public void OpenLinks()
        {
            m_links.OpenLinks();
        }
    }
}