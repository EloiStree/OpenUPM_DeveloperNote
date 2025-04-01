using Eloi.Note;
using UnityEngine;

namespace Eloi.Note { 
public class LinkNoteMono : NoteMonoBehaviour
{

    public NoteLink.NameLink m_link =new NoteLink.NameLink();

    [ContextMenu("Open Links")]
    public void OpenLinks()
    {
        m_link.OpenLink();
    }
}
}