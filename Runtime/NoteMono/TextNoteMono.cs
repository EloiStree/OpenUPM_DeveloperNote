using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Eloi.Note
{

    [System.Serializable]
    public class TextNoteMono : NoteMonoBehaviour , I_HasTextNote
{
        [Tooltip("The note to be share on the current gameobject")]
       
        public TextNote m_note;
         public void GetNote(out string note)
        {
            m_note.GetNote(out note);
        }
        public void SetNote(string note)
        {
            m_note.SetNote(note);
        }
        public string GetNote() {

            GetNote(out string note);
            return note;
        }
    }

}