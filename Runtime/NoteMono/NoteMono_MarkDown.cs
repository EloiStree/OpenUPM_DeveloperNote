using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Eloi.Note
{
    public class NoteMono_MarkDown : NoteMonoBehaviour
    {
        public Note_MarkDown m_note; 
        
        [ContextMenu("OpenInBrowser")]
        public void OpenMarkDownInBrowser()
        {
            m_note.OpenMarkDownInBrowser();
        }
        [ContextMenu("Open as Markdown File")]
        public void OpenMarkDownAsMarkdownFile()
        {
           m_note.OpenMarkDownAsMarkdownFile();
        }
    }
}
