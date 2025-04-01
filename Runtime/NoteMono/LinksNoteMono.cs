using Eloi.Note;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LinksNoteMono : NoteMonoBehaviour
{

    public NoteLink.NameLinkArray m_links = new NoteLink.NameLinkArray();

    [ContextMenu("Open Links")]
    public void OpenLinks()
    {
        m_links.OpenLinks();
    }
}
