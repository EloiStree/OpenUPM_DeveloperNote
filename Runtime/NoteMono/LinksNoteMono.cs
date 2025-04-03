using Eloi.Note;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Note
{
    public class LinksNoteMono : NoteMonoBehaviour
    {

        public NoteLink.NamedLinkArray m_links = new NoteLink.NamedLinkArray();

        [ContextMenu("Open Links")]
        public void OpenLinks()
        {
            m_links.OpenLinks();
        }
    }
}