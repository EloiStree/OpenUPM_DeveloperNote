using Eloi.Note;
using UnityEngine;

namespace Eloi.Note { 
public class LinkNoteMono : NoteMonoBehaviour
{

    public NoteLink.NamedLink m_link =new NoteLink.NamedLink();

    [ContextMenu("Open Links")]
    public void OpenLinks()
    {
        m_link.OpenLink();
    }
}
}