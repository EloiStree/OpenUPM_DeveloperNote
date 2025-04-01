using Eloi.Note;
using UnityEngine;

public class TextNoteMono_Links : TextNoteMono
{

    public NoteLink.NameLinkArray m_links = new NoteLink.NameLinkArray();

    [ContextMenu("Open Links")]
    public void OpenLinks()
    {
        m_links.OpenLinks();
    }
}
