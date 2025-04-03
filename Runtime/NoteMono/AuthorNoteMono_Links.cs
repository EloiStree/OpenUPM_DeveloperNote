
using UnityEngine;
namespace Eloi.Note
{
    public class AuthorNoteMono_Links : AuthorNoteMono
    {

        public NoteLink.NamedLinkArray m_links = new NoteLink.NamedLinkArray();

        [ContextMenu("Open Links")]
        public void OpenLinks()
        {
            m_links.OpenLinks();
        }
    }
}